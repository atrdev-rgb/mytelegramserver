﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/updateBotNewBusinessMessage" />
///</summary>
[TlObject(0x9ddb347c)]
public sealed class TUpdateBotNewBusinessMessage : IUpdate
{
    public uint ConstructorId => 0x9ddb347c;
    public BitArray Flags { get; set; } = new BitArray(32);
    public string ConnectionId { get; set; }
    public MyTelegram.Schema.IMessage Message { get; set; }
    public MyTelegram.Schema.IMessage? ReplyToMessage { get; set; }
    public int Qts { get; set; }

    public void ComputeFlag()
    {
        if (ReplyToMessage != null) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(ConnectionId);
        writer.Write(Message);
        if (Flags[0]) { writer.Write(ReplyToMessage); }
        writer.Write(Qts);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        ConnectionId = reader.ReadString();
        Message = reader.Read<MyTelegram.Schema.IMessage>();
        if (Flags[0]) { ReplyToMessage = reader.Read<MyTelegram.Schema.IMessage>(); }
        Qts = reader.ReadInt32();
    }
}