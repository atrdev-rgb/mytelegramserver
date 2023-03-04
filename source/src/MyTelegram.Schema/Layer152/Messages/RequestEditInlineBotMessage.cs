﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.editInlineBotMessage" />
///</summary>
[TlObject(0x83557dba)]
public sealed class RequestEditInlineBotMessage : IRequest<IBool>
{
    public uint ConstructorId => 0x83557dba;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool NoWebpage { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputBotInlineMessageID" />
    ///</summary>
    public MyTelegram.Schema.IInputBotInlineMessageID Id { get; set; }
    public string? Message { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputMedia" />
    ///</summary>
    public MyTelegram.Schema.IInputMedia? Media { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ReplyMarkup" />
    ///</summary>
    public MyTelegram.Schema.IReplyMarkup? ReplyMarkup { get; set; }
    public TVector<MyTelegram.Schema.IMessageEntity>? Entities { get; set; }

    public void ComputeFlag()
    {
        if (NoWebpage) { Flags[1] = true; }
        if (Message != null) { Flags[11] = true; }
        if (Media != null) { Flags[14] = true; }
        if (ReplyMarkup != null) { Flags[2] = true; }
        if (Entities?.Count > 0) { Flags[3] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Id.Serialize(bw);
        if (Flags[11]) { bw.Serialize(Message); }
        if (Flags[14]) { Media.Serialize(bw); }
        if (Flags[2]) { ReplyMarkup.Serialize(bw); }
        if (Flags[3]) { Entities.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[1]) { NoWebpage = true; }
        Id = br.Deserialize<MyTelegram.Schema.IInputBotInlineMessageID>();
        if (Flags[11]) { Message = br.Deserialize<string>(); }
        if (Flags[14]) { Media = br.Deserialize<MyTelegram.Schema.IInputMedia>(); }
        if (Flags[2]) { ReplyMarkup = br.Deserialize<MyTelegram.Schema.IReplyMarkup>(); }
        if (Flags[3]) { Entities = br.Deserialize<TVector<MyTelegram.Schema.IMessageEntity>>(); }
    }
}