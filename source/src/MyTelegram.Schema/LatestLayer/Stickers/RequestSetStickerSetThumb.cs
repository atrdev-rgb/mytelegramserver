﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stickers;

///<summary>
/// Set stickerset thumbnail
/// <para>Possible errors</para>
/// Code Type Description
/// 400 STICKERSET_INVALID The provided sticker set is invalid.
/// 400 STICKER_THUMB_PNG_NOPNG Incorrect stickerset thumb file provided, PNG / WEBP expected.
/// 400 STICKER_THUMB_TGS_NOTGS Incorrect stickerset TGS thumb file provided.
/// See <a href="https://corefork.telegram.org/method/stickers.setStickerSetThumb" />
///</summary>
[TlObject(0xa76a5392)]
public sealed class RequestSetStickerSetThumb : IRequest<MyTelegram.Schema.Messages.IStickerSet>
{
    public uint ConstructorId => 0xa76a5392;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Stickerset
    /// See <a href="https://corefork.telegram.org/type/InputStickerSet" />
    ///</summary>
    public MyTelegram.Schema.IInputStickerSet Stickerset { get; set; }

    ///<summary>
    /// Thumbnail (only for normal stickersets, not custom emoji stickersets).
    /// See <a href="https://corefork.telegram.org/type/InputDocument" />
    ///</summary>
    public MyTelegram.Schema.IInputDocument? Thumb { get; set; }

    ///<summary>
    /// Only for <a href="https://corefork.telegram.org/api/custom-emoji">custom emoji stickersets</a>, ID of a custom emoji present in the set to use as thumbnail; pass 0 to fallback to the first custom emoji of the set.
    ///</summary>
    public long? ThumbDocumentId { get; set; }

    public void ComputeFlag()
    {
        if (Thumb != null) { Flags[0] = true; }
        if (/*ThumbDocumentId != 0 &&*/ ThumbDocumentId.HasValue) { Flags[1] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Stickerset);
        if (Flags[0]) { writer.Write(Thumb); }
        if (Flags[1]) { writer.Write(ThumbDocumentId.Value); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Stickerset = reader.Read<MyTelegram.Schema.IInputStickerSet>();
        if (Flags[0]) { Thumb = reader.Read<MyTelegram.Schema.IInputDocument>(); }
        if (Flags[1]) { ThumbDocumentId = reader.ReadInt64(); }
    }
}