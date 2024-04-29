﻿// ReSharper disable All

namespace MyTelegram.Handlers.Messages;

///<summary>
/// Get info about chat invites generated by admins.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHAT_ADMIN_REQUIRED You must be an admin in this chat to do this.
/// 403 CHAT_WRITE_FORBIDDEN You can't write in this chat.
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// See <a href="https://corefork.telegram.org/method/messages.getAdminsWithInvites" />
///</summary>
internal sealed class GetAdminsWithInvitesHandler : RpcResultObjectHandler<MyTelegram.Schema.Messages.RequestGetAdminsWithInvites, MyTelegram.Schema.Messages.IChatAdminsWithInvites>,
    Messages.IGetAdminsWithInvitesHandler
{
    private readonly IQueryProcessor _queryProcessor;
    private readonly IAccessHashHelper _accessHashHelper;
    private readonly IPhotoAppService _photoAppService;
    private readonly ILayeredService<IUserConverter> _layeredUserService;
    private readonly IPrivacyAppService _privacyAppService;
    public GetAdminsWithInvitesHandler(IQueryProcessor queryProcessor, IAccessHashHelper accessHashHelper, IPhotoAppService photoAppService, ILayeredService<IUserConverter> layeredUserService, IPrivacyAppService privacyAppService)
    {
        _queryProcessor = queryProcessor;
        _accessHashHelper = accessHashHelper;
        _photoAppService = photoAppService;
        _layeredUserService = layeredUserService;
        _privacyAppService = privacyAppService;
    }

    protected override async Task<IChatAdminsWithInvites> HandleCoreAsync(IRequestInput input,
        RequestGetAdminsWithInvites obj)
    {
        if (obj.Peer is TInputPeerChannel inputPeerChannel)
        {
            await _accessHashHelper.CheckAccessHashAsync(inputPeerChannel.ChannelId, inputPeerChannel.AccessHash);
            var adminWithInvitesList =
                await _queryProcessor.ProcessAsync(new GetAdminInvitesQuery(inputPeerChannel.ChannelId));
            var userIds = adminWithInvitesList.Select(p => p.AdminId).ToList();
            var userReadModels = await _queryProcessor.ProcessAsync(new GetUsersByUidListQuery(userIds));
            var contactReadModels = await _queryProcessor.ProcessAsync(new GetContactListQuery(input.UserId, userIds));
            var photoReadModels = await _photoAppService.GetPhotosAsync(userReadModels, contactReadModels);
            var privacyList = await _privacyAppService.GetPrivacyListAsync(userIds);

            return new TChatAdminsWithInvites
            {
                Admins = new TVector<IChatAdminWithInvites>(adminWithInvitesList.Select(p => new TChatAdminWithInvites
                {
                    AdminId = p.AdminId,
                    InvitesCount = p.InvitesCount,
                    RevokedInvitesCount = p.RevokedInvitesCount,
                })),
                Users = new TVector<IUser>(_layeredUserService.GetConverter(input.Layer).ToUserList(input.UserId, userReadModels, photoReadModels, contactReadModels, privacyList))
            };
        }

        throw new NotImplementedException();
    }
}
