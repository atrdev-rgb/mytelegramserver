﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// channelAdminLogEvent.user_id has set the volume of participant.peer to participant.volume
/// See <a href="https://corefork.telegram.org/constructor/channelAdminLogEventActionParticipantVolume" />
///</summary>
[TlObject(0x3e7f6847)]
public sealed class TChannelAdminLogEventActionParticipantVolume : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0x3e7f6847;
    ///<summary>
    /// The participant whose volume was changed
    /// See <a href="https://corefork.telegram.org/type/GroupCallParticipant" />
    ///</summary>
    public MyTelegram.Schema.IGroupCallParticipant Participant { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Participant);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Participant = reader.Read<MyTelegram.Schema.IGroupCallParticipant>();
    }
}