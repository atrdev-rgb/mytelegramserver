﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputBotAppID" />
///</summary>
[TlObject(0xa920bd7a)]
public sealed class TInputBotAppID : IInputBotApp
{
    public uint ConstructorId => 0xa920bd7a;
    public long Id { get; set; }
    public long AccessHash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Id);
        bw.Write(AccessHash);
    }

    public void Deserialize(BinaryReader br)
    {
        Id = br.ReadInt64();
        AccessHash = br.ReadInt64();
    }
}