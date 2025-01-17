﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
/// Get a list of default suggested <a href="https://corefork.telegram.org/api/emoji-status">emoji statuses</a>
/// See <a href="https://corefork.telegram.org/method/account.getDefaultEmojiStatuses" />
///</summary>
[TlObject(0xd6753386)]
public sealed class RequestGetDefaultEmojiStatuses : IRequest<MyTelegram.Schema.Account.IEmojiStatuses>
{
    public uint ConstructorId => 0xd6753386;
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
        writer.Write(Hash);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Hash = reader.ReadInt64();
    }
}
