﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/channelParticipantBanned" />
///</summary>
[TlObject(0x6df8014e)]
public sealed class TChannelParticipantBanned : IChannelParticipant
{
    public uint ConstructorId => 0x6df8014e;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Left { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }
    public long KickedBy { get; set; }
    public int Date { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ChatBannedRights" />
    ///</summary>
    public MyTelegram.Schema.IChatBannedRights BannedRights { get; set; }

    public void ComputeFlag()
    {
        if (Left) { Flags[0] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Peer.Serialize(bw);
        bw.Write(KickedBy);
        bw.Write(Date);
        BannedRights.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Left = true; }
        Peer = br.Deserialize<MyTelegram.Schema.IPeer>();
        KickedBy = br.ReadInt64();
        Date = br.ReadInt32();
        BannedRights = br.Deserialize<MyTelegram.Schema.IChatBannedRights>();
    }
}