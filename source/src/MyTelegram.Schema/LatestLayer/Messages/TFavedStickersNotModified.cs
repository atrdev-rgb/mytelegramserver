﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// No new favorited stickers were found
/// See <a href="https://corefork.telegram.org/constructor/messages.favedStickersNotModified" />
///</summary>
[TlObject(0x9e8fa6d3)]
public sealed class TFavedStickersNotModified : IFavedStickers
{
    public uint ConstructorId => 0x9e8fa6d3;


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