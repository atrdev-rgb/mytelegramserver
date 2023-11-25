﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Inline image
/// See <a href="https://corefork.telegram.org/constructor/textImage" />
///</summary>
[TlObject(0x81ccf4f)]
public sealed class TTextImage : IRichText
{
    public uint ConstructorId => 0x81ccf4f;
    ///<summary>
    /// Document ID
    ///</summary>
    public long DocumentId { get; set; }

    ///<summary>
    /// Width
    ///</summary>
    public int W { get; set; }

    ///<summary>
    /// Height
    ///</summary>
    public int H { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(DocumentId);
        writer.Write(W);
        writer.Write(H);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        DocumentId = reader.ReadInt64();
        W = reader.ReadInt32();
        H = reader.ReadInt32();
    }
}