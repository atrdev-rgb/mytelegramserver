﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// User left the group.
/// See <a href="https://corefork.telegram.org/constructor/messageActionChatDeleteUser" />
///</summary>
[TlObject(0xa43f30cc)]
public sealed class TMessageActionChatDeleteUser : IMessageAction
{
    public uint ConstructorId => 0xa43f30cc;
    ///<summary>
    /// Leaving user ID
    ///</summary>
    public long UserId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(UserId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        UserId = reader.ReadInt64();
    }
}