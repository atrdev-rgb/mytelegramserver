﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateReadChannelOutbox" />
///</summary>
[TlObject(0xb75f99a9)]
public sealed class TUpdateReadChannelOutbox : IUpdate
{
    public uint ConstructorId => 0xb75f99a9;
    public long ChannelId { get; set; }
    public int MaxId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(ChannelId);
        bw.Write(MaxId);
    }

    public void Deserialize(BinaryReader br)
    {
        ChannelId = br.ReadInt64();
        MaxId = br.ReadInt32();
    }
}