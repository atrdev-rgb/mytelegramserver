﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/botCommandScopeUsers" />
///</summary>
[TlObject(0x3c4f04d8)]
public sealed class TBotCommandScopeUsers : IBotCommandScope
{
    public uint ConstructorId => 0x3c4f04d8;


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