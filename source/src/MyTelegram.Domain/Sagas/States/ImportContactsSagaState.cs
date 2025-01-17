﻿namespace MyTelegram.Domain.Sagas.States;

public class
    ImportContactsSagaState : AggregateState<ImportContactsSaga, ImportContactsSagaId, ImportContactsSagaState>,
        IApply<ImportContactsStartedSagaEvent>,
        IApply<ImportContactsSagaSingleContactImportedSagaEvent>
{
    //public int ImportedCount { get; private set; }
    //public PhoneContact PhoneContact { get; private set; }
    public List<PhoneContact> PhoneContacts { get; private set; } = null!;
    //public long ReqMsgId { get; private set; }
    public RequestInfo RequestInfo { get; private set; }
    public int TotalCount { get; private set; }

    public void Apply(ImportContactsSagaSingleContactImportedSagaEvent aggregateEvent)
    {
        //ImportedCount++;
        PhoneContacts.Add(aggregateEvent.PhoneContact);
    }

    public void Apply(ImportContactsStartedSagaEvent aggregateEvent)
    {
        //ReqMsgId = aggregateEvent.ReqMsgId;
        RequestInfo=aggregateEvent.RequestInfo;
        TotalCount = aggregateEvent.Count;
        PhoneContacts = new List<PhoneContact>();
    }

    public bool IsCompleted()
    {
        return TotalCount == PhoneContacts.Count;
    }
}
