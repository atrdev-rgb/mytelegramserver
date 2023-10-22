﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/messageReplyStoryHeader" />
///</summary>
[TlObject(0x9c98bfc1)]
public sealed class TMessageReplyStoryHeader : IMessageReplyHeader
{
    public uint ConstructorId => 0x9c98bfc1;
    ///<summary>
    /// &nbsp;
    ///</summary>
    public long UserId { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int StoryId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(UserId);
        writer.Write(StoryId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        UserId = reader.ReadInt64();
        StoryId = reader.ReadInt32();
    }
}