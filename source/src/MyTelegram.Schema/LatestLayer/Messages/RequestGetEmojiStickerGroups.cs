﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Represents a list of <a href="https://corefork.telegram.org/api/emoji-categories">emoji categories</a>, to be used when choosing a sticker.
/// See <a href="https://corefork.telegram.org/method/messages.getEmojiStickerGroups" />
///</summary>
[TlObject(0x1dd840f5)]
public sealed class RequestGetEmojiStickerGroups : IRequest<MyTelegram.Schema.Messages.IEmojiGroups>
{
    public uint ConstructorId => 0x1dd840f5;
    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets#hash-generation">Hash used for caching, for more info click here</a>.
    ///</summary>
    public int Hash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Hash);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Hash = reader.ReadInt32();
    }
}
