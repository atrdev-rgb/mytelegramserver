﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;


///<summary>
///See <a href="https://core.telegram.org/constructor/messages.stickerSetNotModified" />
///</summary>
[TlObject(0xd3f924eb)]
public class TStickerSetNotModified : IStickerSet
{
    public uint ConstructorId => 0xd3f924eb;


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