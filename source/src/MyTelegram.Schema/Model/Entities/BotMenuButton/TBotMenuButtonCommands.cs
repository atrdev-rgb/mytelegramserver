﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/botMenuButtonCommands" />
///</summary>
[TlObject(0x4258c205)]
public class TBotMenuButtonCommands : IBotMenuButton
{
    public uint ConstructorId => 0x4258c205;


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