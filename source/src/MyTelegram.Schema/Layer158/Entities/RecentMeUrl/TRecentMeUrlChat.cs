﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/recentMeUrlChat" />
///</summary>
[TlObject(0xb2da71d2)]
public sealed class TRecentMeUrlChat : IRecentMeUrl
{
    public uint ConstructorId => 0xb2da71d2;
    public string Url { get; set; }
    public long ChatId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Url);
        bw.Write(ChatId);
    }

    public void Deserialize(BinaryReader br)
    {
        Url = br.Deserialize<string>();
        ChatId = br.ReadInt64();
    }
}