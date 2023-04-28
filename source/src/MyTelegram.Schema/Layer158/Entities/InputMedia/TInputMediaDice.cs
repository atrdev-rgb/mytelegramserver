﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputMediaDice" />
///</summary>
[TlObject(0xe66fbf7b)]
public sealed class TInputMediaDice : IInputMedia
{
    public uint ConstructorId => 0xe66fbf7b;
    public string Emoticon { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Emoticon);
    }

    public void Deserialize(BinaryReader br)
    {
        Emoticon = br.Deserialize<string>();
    }
}