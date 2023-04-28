﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateChannelParticipant" />
///</summary>
[TlObject(0x985d3abb)]
public sealed class TUpdateChannelParticipant : IUpdate
{
    public uint ConstructorId => 0x985d3abb;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool ViaChatlist { get; set; }
    public long ChannelId { get; set; }
    public int Date { get; set; }
    public long ActorId { get; set; }
    public long UserId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ChannelParticipant" />
    ///</summary>
    public MyTelegram.Schema.IChannelParticipant? PrevParticipant { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ChannelParticipant" />
    ///</summary>
    public MyTelegram.Schema.IChannelParticipant? NewParticipant { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ExportedChatInvite" />
    ///</summary>
    public MyTelegram.Schema.IExportedChatInvite? Invite { get; set; }
    public int Qts { get; set; }

    public void ComputeFlag()
    {
        if (ViaChatlist) { Flags[3] = true; }
        if (PrevParticipant != null) { Flags[0] = true; }
        if (NewParticipant != null) { Flags[1] = true; }
        if (Invite != null) { Flags[2] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(ChannelId);
        bw.Write(Date);
        bw.Write(ActorId);
        bw.Write(UserId);
        if (Flags[0]) { PrevParticipant.Serialize(bw); }
        if (Flags[1]) { NewParticipant.Serialize(bw); }
        if (Flags[2]) { Invite.Serialize(bw); }
        bw.Write(Qts);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[3]) { ViaChatlist = true; }
        ChannelId = br.ReadInt64();
        Date = br.ReadInt32();
        ActorId = br.ReadInt64();
        UserId = br.ReadInt64();
        if (Flags[0]) { PrevParticipant = br.Deserialize<MyTelegram.Schema.IChannelParticipant>(); }
        if (Flags[1]) { NewParticipant = br.Deserialize<MyTelegram.Schema.IChannelParticipant>(); }
        if (Flags[2]) { Invite = br.Deserialize<MyTelegram.Schema.IExportedChatInvite>(); }
        Qts = br.ReadInt32();
    }
}