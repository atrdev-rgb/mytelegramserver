﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Concatenation of rich texts
/// See <a href="https://corefork.telegram.org/constructor/textConcat" />
///</summary>
[TlObject(0x7e6260d7)]
public sealed class TTextConcat : IRichText
{
    public uint ConstructorId => 0x7e6260d7;
    ///<summary>
    /// Concatenated rich texts
    ///</summary>
    public TVector<MyTelegram.Schema.IRichText> Texts { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Texts);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Texts = reader.Read<TVector<MyTelegram.Schema.IRichText>>();
    }
}