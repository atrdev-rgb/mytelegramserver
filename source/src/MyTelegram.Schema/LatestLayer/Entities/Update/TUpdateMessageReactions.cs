﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// New <a href="https://corefork.telegram.org/api/reactions">message reactions »</a> are available
/// See <a href="https://corefork.telegram.org/constructor/updateMessageReactions" />
///</summary>
[TlObject(0x5e1b3cb8)]
public sealed class TUpdateMessageReactions : IUpdate
{
    public uint ConstructorId => 0x5e1b3cb8;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Peer
    /// See <a href="https://corefork.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }

    ///<summary>
    /// Message ID
    ///</summary>
    public int MsgId { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/forum#forum-topics">Forum topic ID</a>
    ///</summary>
    public int? TopMsgId { get; set; }

    ///<summary>
    /// Reactions
    /// See <a href="https://corefork.telegram.org/type/MessageReactions" />
    ///</summary>
    public MyTelegram.Schema.IMessageReactions Reactions { get; set; }

    public void ComputeFlag()
    {
        if (/*TopMsgId != 0 && */TopMsgId.HasValue) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Peer);
        writer.Write(MsgId);
        if (Flags[0]) { writer.Write(TopMsgId.Value); }
        writer.Write(Reactions);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Peer = reader.Read<MyTelegram.Schema.IPeer>();
        MsgId = reader.ReadInt32();
        if (Flags[0]) { TopMsgId = reader.ReadInt32(); }
        Reactions = reader.Read<MyTelegram.Schema.IMessageReactions>();
    }
}