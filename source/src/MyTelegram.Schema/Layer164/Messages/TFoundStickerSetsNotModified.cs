﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// No further results were found
/// See <a href="https://corefork.telegram.org/constructor/messages.foundStickerSetsNotModified" />
///</summary>
[TlObject(0xd54b65d)]
public sealed class TFoundStickerSetsNotModified : IFoundStickerSets
{
    public uint ConstructorId => 0xd54b65d;


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