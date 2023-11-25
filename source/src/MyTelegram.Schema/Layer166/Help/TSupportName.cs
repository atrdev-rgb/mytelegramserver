﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;

///<summary>
/// Localized name for telegram support
/// See <a href="https://corefork.telegram.org/constructor/help.supportName" />
///</summary>
[TlObject(0x8c05f1c9)]
public sealed class TSupportName : ISupportName
{
    public uint ConstructorId => 0x8c05f1c9;
    ///<summary>
    /// Localized name
    ///</summary>
    public string Name { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Name);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Name = reader.ReadString();
    }
}