﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Contains info about a <a href="https://corefork.telegram.org/api/business#business-chat-links">business chat deep link »</a> created by the current account.
/// See <a href="https://corefork.telegram.org/constructor/businessChatLink" />
///</summary>
[TlObject(0xb4ae666f)]
public sealed class TBusinessChatLink : IBusinessChatLink
{
    public uint ConstructorId => 0xb4ae666f;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/links#business-chat-links">Business chat deep link</a>.
    ///</summary>
    public string Link { get; set; }

    ///<summary>
    /// Message to pre-fill in the message input field.
    ///</summary>
    public string Message { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/entities">Message entities for styled text</a>
    ///</summary>
    public TVector<MyTelegram.Schema.IMessageEntity>? Entities { get; set; }

    ///<summary>
    /// Human-readable name of the link, to simplify management in the UI (only visible to the creator of the link).
    ///</summary>
    public string? Title { get; set; }

    ///<summary>
    /// Number of times the link was resolved (clicked/scanned/etc...).
    ///</summary>
    public int Views { get; set; }

    public void ComputeFlag()
    {
        if (Entities?.Count > 0) { Flags[0] = true; }
        if (Title != null) { Flags[1] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Link);
        writer.Write(Message);
        if (Flags[0]) { writer.Write(Entities); }
        if (Flags[1]) { writer.Write(Title); }
        writer.Write(Views);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Link = reader.ReadString();
        Message = reader.ReadString();
        if (Flags[0]) { Entities = reader.Read<TVector<MyTelegram.Schema.IMessageEntity>>(); }
        if (Flags[1]) { Title = reader.ReadString(); }
        Views = reader.ReadInt32();
    }
}