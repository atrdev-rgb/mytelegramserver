﻿// ReSharper disable All

namespace MyTelegram.Handlers.Messages;

///<summary>
/// Obtains information about a chat export file, generated by a foreign chat app, <a href="https://corefork.telegram.org/api/import">click here for more info about imported chats »</a>.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 IMPORT_FORMAT_UNRECOGNIZED The specified chat export file was exported from an unsupported chat app.
/// See <a href="https://corefork.telegram.org/method/messages.checkHistoryImport" />
///</summary>
internal sealed class CheckHistoryImportHandler : RpcResultObjectHandler<MyTelegram.Schema.Messages.RequestCheckHistoryImport, MyTelegram.Schema.Messages.IHistoryImportParsed>,
    Messages.ICheckHistoryImportHandler
{
    protected override Task<MyTelegram.Schema.Messages.IHistoryImportParsed> HandleCoreAsync(IRequestInput input,
        MyTelegram.Schema.Messages.RequestCheckHistoryImport obj)
    {
        throw new NotImplementedException();
    }
}