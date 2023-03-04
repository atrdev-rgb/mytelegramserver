﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/photoCachedSize" />
///</summary>
[TlObject(0x21e1ad6)]
public sealed class TPhotoCachedSize : IPhotoSize
{
    public uint ConstructorId => 0x21e1ad6;
    public string Type { get; set; }
    public int W { get; set; }
    public int H { get; set; }
    public byte[] Bytes { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Type);
        bw.Write(W);
        bw.Write(H);
        bw.Serialize(Bytes);
    }

    public void Deserialize(BinaryReader br)
    {
        Type = br.Deserialize<string>();
        W = br.ReadInt32();
        H = br.ReadInt32();
        Bytes = br.Deserialize<byte[]>();
    }
}