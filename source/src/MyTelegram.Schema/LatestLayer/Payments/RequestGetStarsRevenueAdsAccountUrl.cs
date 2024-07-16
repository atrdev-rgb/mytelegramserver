﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Payments;

///<summary>
/// See <a href="https://corefork.telegram.org/method/payments.getStarsRevenueAdsAccountUrl" />
///</summary>
[TlObject(0xd1d7efc5)]
public sealed class RequestGetStarsRevenueAdsAccountUrl : IRequest<MyTelegram.Schema.Payments.IStarsRevenueAdsAccountUrl>
{
    public uint ConstructorId => 0xd1d7efc5;
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
    }
}