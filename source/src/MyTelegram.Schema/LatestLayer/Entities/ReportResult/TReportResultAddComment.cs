﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/reportResultAddComment" />
///</summary>
[TlObject(0x6f09ac31)]
public sealed class TReportResultAddComment : IReportResult
{
    public uint ConstructorId => 0x6f09ac31;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Optional { get; set; }
    public byte[] Option { get; set; }

    public void ComputeFlag()
    {
        if (Optional) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Option);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Optional = true; }
        Option = reader.ReadBytes();
    }
}