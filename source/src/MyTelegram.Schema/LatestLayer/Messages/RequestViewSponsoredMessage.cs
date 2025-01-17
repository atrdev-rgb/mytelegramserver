﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// See <a href="https://corefork.telegram.org/method/messages.viewSponsoredMessage" />
///</summary>
[TlObject(0x673ad8f1)]
public sealed class RequestViewSponsoredMessage : IRequest<IBool>
{
    public uint ConstructorId => 0x673ad8f1;
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public byte[] RandomId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(RandomId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        RandomId = reader.ReadBytes();
    }
}
