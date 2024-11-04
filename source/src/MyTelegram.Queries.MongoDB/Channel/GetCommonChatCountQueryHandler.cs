﻿namespace MyTelegram.QueryHandlers.MongoDB.Channel;

public class GetCommonChatCountQueryHandler
    (IQueryOnlyReadModelStore<ChannelMemberReadModel> store) : IQueryHandler<GetCommonChatCountQuery, int>
{
    public async Task<int> ExecuteQueryAsync(GetCommonChatCountQuery query,
        CancellationToken cancellationToken)
    {
        var joinedChannelIds = await store.FindAsync(p => p.UserId == query.SelfUserId, p => p.ChannelId, cancellationToken: cancellationToken);
        if (joinedChannelIds.Any())
        {
            return (int)await store.CountAsync(p =>
                joinedChannelIds.Contains(p.ChannelId) && p.UserId == query.TargetUserId, cancellationToken);
        }

        return 0;
    }
}