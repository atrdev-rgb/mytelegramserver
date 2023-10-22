﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/messagePeerVote" />
///</summary>
[TlObject(0xb6cc2d5c)]
public sealed class TMessagePeerVote : IMessagePeerVote
{
    public uint ConstructorId => 0xb6cc2d5c;
    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public byte[] Option { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int Date { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(Option);
        writer.Write(Date);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IPeer>();
        Option = reader.ReadBytes();
        Date = reader.ReadInt32();
    }
}