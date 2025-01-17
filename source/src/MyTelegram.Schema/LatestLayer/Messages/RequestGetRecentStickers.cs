﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Get recent stickers
/// See <a href="https://corefork.telegram.org/method/messages.getRecentStickers" />
///</summary>
[TlObject(0x9da9403b)]
public sealed class RequestGetRecentStickers : IRequest<MyTelegram.Schema.Messages.IRecentStickers>
{
    public uint ConstructorId => 0x9da9403b;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Get stickers recently attached to photo or video files
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Attached { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets#hash-generation">Hash used for caching, for more info click here</a>.
    ///</summary>
    public long Hash { get; set; }

    public void ComputeFlag()
    {
        if (Attached) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Hash);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Attached = true; }
        Hash = reader.ReadInt64();
    }
}
