﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/secureValueTypePersonalDetails" />
///</summary>
[TlObject(0x9d2a81e3)]
public sealed class TSecureValueTypePersonalDetails : ISecureValueType
{
    public uint ConstructorId => 0x9d2a81e3;


    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}