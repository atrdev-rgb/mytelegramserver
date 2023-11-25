﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Used in updates and in the channel log to indicate when a user is requesting to join or has joined a <a href="https://corefork.telegram.org/api/discussion#requiring-users-to-join-the-group">discussion group</a>
/// See <a href="https://corefork.telegram.org/constructor/chatInvitePublicJoinRequests" />
///</summary>
[TlObject(0xed107ab7)]
public sealed class TChatInvitePublicJoinRequests : IExportedChatInvite
{
    public uint ConstructorId => 0xed107ab7;


    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);

    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {

    }
}