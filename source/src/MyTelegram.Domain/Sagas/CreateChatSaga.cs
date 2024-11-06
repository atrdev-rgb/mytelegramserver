﻿namespace MyTelegram.Domain.Sagas;

public class CreateChatSaga(CreateChatSagaId id, IEventStore eventStore, IIdGenerator idGenerator)
    : MyInMemoryAggregateSaga<CreateChatSaga, CreateChatSagaId, CreateChatSagaLocator>(id, eventStore),
        ISagaIsStartedBy<ChatAggregate, ChatId, ChatCreatedEvent>
{
    public async Task HandleAsync(IDomainEvent<ChatAggregate, ChatId, ChatCreatedEvent> domainEvent,
        ISagaContext sagaContext,
        CancellationToken cancellationToken)
    {
        var ownerPeerId = domainEvent.AggregateEvent.CreatorUid;
        var chatId = domainEvent.AggregateEvent.ChatId;
        var outMessageId = await idGenerator.NextIdAsync(IdType.MessageId, ownerPeerId, cancellationToken: cancellationToken);

        var messageItem = new MessageItem(
            new Peer(PeerType.User, ownerPeerId),
            new Peer(PeerType.Chat, chatId),
            new Peer(PeerType.User, ownerPeerId),
            ownerPeerId,
            outMessageId,
            string.Empty,
            domainEvent.AggregateEvent.Date,
            domainEvent.AggregateEvent.RandomId,
            true,
            SendMessageType.MessageService,
            MessageType.Text,
            MessageSubType.CreateChat,
            null,
            domainEvent.AggregateEvent.MessageActionData,
            MessageActionType.ChatCreate,
            TtlPeriod: domainEvent.AggregateEvent.TtlPeriod,
            IsTtlFromDefaultSetting: false
        );

        var command = new StartSendMessageCommand(TempId.New,
            domainEvent.AggregateEvent.RequestInfo with { RequestId = Guid.NewGuid() },
            [
                new SendMessageItem(messageItem,
                    ChatMembers: domainEvent.AggregateEvent.MemberUidList.Select(p => p.UserId).ToList())
            ]
        );

        Publish(command);
        await CompleteAsync(cancellationToken);
    }
}