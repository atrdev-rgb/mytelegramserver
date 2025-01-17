﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Get recently used <a href="https://corefork.telegram.org/api/reactions">message reactions</a>
/// See <a href="https://corefork.telegram.org/method/messages.getRecentReactions" />
///</summary>
[TlObject(0x39461db2)]
public sealed class RequestGetRecentReactions : IRequest<MyTelegram.Schema.Messages.IReactions>
{
    public uint ConstructorId => 0x39461db2;
    ///<summary>
    /// Maximum number of results to return, <a href="https://corefork.telegram.org/api/offsets">see pagination</a>
    ///</summary>
    public int Limit { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets#hash-generation">Hash used for caching, for more info click here</a>.
    ///</summary>
    public long Hash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Limit);
        writer.Write(Hash);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Limit = reader.ReadInt32();
        Hash = reader.ReadInt64();
    }
}
