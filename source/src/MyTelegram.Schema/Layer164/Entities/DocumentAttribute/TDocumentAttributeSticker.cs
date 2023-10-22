﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Defines a sticker
/// See <a href="https://corefork.telegram.org/constructor/documentAttributeSticker" />
///</summary>
[TlObject(0x6319d612)]
public sealed class TDocumentAttributeSticker : IDocumentAttribute
{
    public uint ConstructorId => 0x6319d612;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether this is a mask sticker
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Mask { get; set; }

    ///<summary>
    /// Alternative emoji representation of sticker
    ///</summary>
    public string Alt { get; set; }

    ///<summary>
    /// Associated stickerset
    /// See <a href="https://corefork.telegram.org/type/InputStickerSet" />
    ///</summary>
    public MyTelegram.Schema.IInputStickerSet Stickerset { get; set; }

    ///<summary>
    /// Mask coordinates (if this is a mask sticker, attached to a photo)
    /// See <a href="https://corefork.telegram.org/type/MaskCoords" />
    ///</summary>
    public MyTelegram.Schema.IMaskCoords? MaskCoords { get; set; }

    public void ComputeFlag()
    {
        if (Mask) { Flags[1] = true; }
        if (MaskCoords != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Alt);
        writer.Write(Stickerset);
        if (Flags[0]) { writer.Write(MaskCoords); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { Mask = true; }
        Alt = reader.ReadString();
        Stickerset = reader.Read<MyTelegram.Schema.IInputStickerSet>();
        if (Flags[0]) { MaskCoords = reader.Read<MyTelegram.Schema.IMaskCoords>(); }
    }
}