﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/starsTransactionPeerAPI" />
///</summary>
[TlObject(0xf9677aad)]
public sealed class TStarsTransactionPeerAPI : IStarsTransactionPeer
{
    public uint ConstructorId => 0xf9677aad;


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