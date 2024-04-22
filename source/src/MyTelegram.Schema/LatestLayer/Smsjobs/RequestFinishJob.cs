﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Smsjobs;

///<summary>
/// See <a href="https://corefork.telegram.org/method/smsjobs.finishJob" />
///</summary>
[TlObject(0x4f1ebf24)]
public sealed class RequestFinishJob : IRequest<IBool>
{
    public uint ConstructorId => 0x4f1ebf24;
    public BitArray Flags { get; set; } = new BitArray(32);
    public string JobId { get; set; }
    public string? Error { get; set; }

    public void ComputeFlag()
    {
        if (Error != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(JobId);
        if (Flags[0]) { writer.Write(Error); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        JobId = reader.ReadString();
        if (Flags[0]) { Error = reader.ReadString(); }
    }
}