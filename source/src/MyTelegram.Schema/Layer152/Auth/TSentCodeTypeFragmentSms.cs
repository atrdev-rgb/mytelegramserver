﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Auth;


///<summary>
///See <a href="https://core.telegram.org/constructor/auth.sentCodeTypeFragmentSms" />
///</summary>
[TlObject(0xd9565c39)]
public sealed class TSentCodeTypeFragmentSms : ISentCodeType
{
    public uint ConstructorId => 0xd9565c39;
    public string Url { get; set; }
    public int Length { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Url);
        bw.Write(Length);
    }

    public void Deserialize(BinaryReader br)
    {
        Url = br.Deserialize<string>();
        Length = br.ReadInt32();
    }
}