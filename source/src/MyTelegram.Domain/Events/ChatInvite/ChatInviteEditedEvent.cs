﻿namespace MyTelegram.Domain.Events.ChatInvite;

public class ChatInviteEditedEvent : RequestAggregateEvent2<ChatInviteAggregate, ChatInviteId>
{
    public ChatInviteEditedEvent(RequestInfo requestInfo, long channelId, long inviteId, string hash, string? newHash, long adminId,
        string? title, bool requestNeeded, int? startDate, int? expireDate, int? usageLimit,
        bool permanent, bool revoked, int? requested, int? usage) : base(requestInfo)
    {
        ChannelId = channelId;
        InviteId = inviteId;

        Hash = hash;
        NewHash = newHash;
        AdminId = adminId;
        Title = title;
        RequestNeeded = requestNeeded;
        StartDate = startDate;
        ExpireDate = expireDate;
        UsageLimit = usageLimit;
        Permanent = permanent;
        Revoked = revoked;
        Requested = requested;
        Usage = usage;
    }

    public long ChannelId { get; }
    public long InviteId { get; }
    public string Hash { get; }
    public string? NewHash { get; }
    public long AdminId { get; }
    public string? Title { get; }
    public bool RequestNeeded { get; }
    public int? StartDate { get; }
    public int? ExpireDate { get; }
    public int? UsageLimit { get; }
    public bool Permanent { get; }
    public bool Revoked { get; }
    public int? Requested { get; }
    public int? Usage { get; }
}