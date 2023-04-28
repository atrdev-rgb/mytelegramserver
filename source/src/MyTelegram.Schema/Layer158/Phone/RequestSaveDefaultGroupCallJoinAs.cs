﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Phone;

///<summary>
///See <a href="https://core.telegram.org/method/phone.saveDefaultGroupCallJoinAs" />
///</summary>
[TlObject(0x575e1f8c)]
public sealed class RequestSaveDefaultGroupCallJoinAs : IRequest<IBool>
{
    public uint ConstructorId => 0x575e1f8c;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer JoinAs { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Peer.Serialize(bw);
        JoinAs.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Peer = br.Deserialize<MyTelegram.Schema.IInputPeer>();
        JoinAs = br.Deserialize<MyTelegram.Schema.IInputPeer>();
    }
}