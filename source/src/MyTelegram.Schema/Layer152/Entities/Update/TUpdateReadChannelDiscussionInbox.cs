﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateReadChannelDiscussionInbox" />
///</summary>
[TlObject(0xd6b19546)]
public sealed class TUpdateReadChannelDiscussionInbox : IUpdate
{
    public uint ConstructorId => 0xd6b19546;
    public BitArray Flags { get; set; } = new BitArray(32);
    public long ChannelId { get; set; }
    public int TopMsgId { get; set; }
    public int ReadMaxId { get; set; }
    public long? BroadcastId { get; set; }
    public int? BroadcastPost { get; set; }

    public void ComputeFlag()
    {
        if (BroadcastId != 0 && BroadcastId.HasValue) { Flags[0] = true; }
        if (BroadcastPost != 0 && BroadcastPost.HasValue) { Flags[0] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(ChannelId);
        bw.Write(TopMsgId);
        bw.Write(ReadMaxId);
        if (Flags[0]) { bw.Write(BroadcastId.Value); }
        if (Flags[0]) { bw.Write(BroadcastPost.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        ChannelId = br.ReadInt64();
        TopMsgId = br.ReadInt32();
        ReadMaxId = br.ReadInt32();
        if (Flags[0]) { BroadcastId = br.ReadInt64(); }
        if (Flags[0]) { BroadcastPost = br.ReadInt32(); }
    }
}