﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messagePeerReaction" />
///</summary>
[TlObject(0xb156fe9c)]
public sealed class TMessagePeerReaction : IMessagePeerReaction
{
    public uint ConstructorId => 0xb156fe9c;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Big { get; set; }
    public bool Unread { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer PeerId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Reaction" />
    ///</summary>
    public MyTelegram.Schema.IReaction Reaction { get; set; }

    public void ComputeFlag()
    {
        if (Big) { Flags[0] = true; }
        if (Unread) { Flags[1] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        PeerId.Serialize(bw);
        Reaction.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Big = true; }
        if (Flags[1]) { Unread = true; }
        PeerId = br.Deserialize<MyTelegram.Schema.IPeer>();
        Reaction = br.Deserialize<MyTelegram.Schema.IReaction>();
    }
}