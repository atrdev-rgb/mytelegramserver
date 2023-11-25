﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// An embedded post
/// See <a href="https://corefork.telegram.org/constructor/pageBlockEmbedPost" />
///</summary>
[TlObject(0xf259a80b)]
public sealed class TPageBlockEmbedPost : IPageBlock
{
    public uint ConstructorId => 0xf259a80b;
    ///<summary>
    /// Web page URL
    ///</summary>
    public string Url { get; set; }

    ///<summary>
    /// ID of generated webpage preview
    ///</summary>
    public long WebpageId { get; set; }

    ///<summary>
    /// ID of the author's photo
    ///</summary>
    public long AuthorPhotoId { get; set; }

    ///<summary>
    /// Author name
    ///</summary>
    public string Author { get; set; }

    ///<summary>
    /// Creation date
    ///</summary>
    public int Date { get; set; }

    ///<summary>
    /// Post contents
    ///</summary>
    public TVector<MyTelegram.Schema.IPageBlock> Blocks { get; set; }

    ///<summary>
    /// Caption
    /// See <a href="https://corefork.telegram.org/type/PageCaption" />
    ///</summary>
    public MyTelegram.Schema.IPageCaption Caption { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Url);
        writer.Write(WebpageId);
        writer.Write(AuthorPhotoId);
        writer.Write(Author);
        writer.Write(Date);
        writer.Write(Blocks);
        writer.Write(Caption);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Url = reader.ReadString();
        WebpageId = reader.ReadInt64();
        AuthorPhotoId = reader.ReadInt64();
        Author = reader.ReadString();
        Date = reader.ReadInt32();
        Blocks = reader.Read<TVector<MyTelegram.Schema.IPageBlock>>();
        Caption = reader.Read<MyTelegram.Schema.IPageCaption>();
    }
}