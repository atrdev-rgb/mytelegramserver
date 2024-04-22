﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Smsjobs;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/smsjobs.eligibleToJoin" />
///</summary>
[TlObject(0xdc8b44cf)]
public sealed class TEligibleToJoin : IEligibilityToJoin
{
    public uint ConstructorId => 0xdc8b44cf;
    public string TermsUrl { get; set; }
    public int MonthlySentSms { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(TermsUrl);
        writer.Write(MonthlySentSms);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        TermsUrl = reader.ReadString();
        MonthlySentSms = reader.ReadInt32();
    }
}