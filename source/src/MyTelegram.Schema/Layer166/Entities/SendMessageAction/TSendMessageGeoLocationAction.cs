﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// User is selecting a location to share.
/// See <a href="https://corefork.telegram.org/constructor/sendMessageGeoLocationAction" />
///</summary>
[TlObject(0x176f8ba1)]
public sealed class TSendMessageGeoLocationAction : ISendMessageAction
{
    public uint ConstructorId => 0x176f8ba1;


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