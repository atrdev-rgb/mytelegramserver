﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/groupCallParticipantVideoSourceGroup" />
///</summary>
[TlObject(0xdcb118b7)]
public sealed class TGroupCallParticipantVideoSourceGroup : IGroupCallParticipantVideoSourceGroup
{
    public uint ConstructorId => 0xdcb118b7;
    public string Semantics { get; set; }
    public TVector<int> Sources { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Semantics);
        Sources.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Semantics = br.Deserialize<string>();
        Sources = br.Deserialize<TVector<int>>();
    }
}