﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/pageBlockHeader" />
///</summary>
[TlObject(0xbfd064ec)]
public sealed class TPageBlockHeader : IPageBlock
{
    public uint ConstructorId => 0xbfd064ec;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/RichText" />
    ///</summary>
    public MyTelegram.Schema.IRichText Text { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Text.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Text = br.Deserialize<MyTelegram.Schema.IRichText>();
    }
}