﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Disallow all users
/// See <a href="https://corefork.telegram.org/constructor/privacyValueDisallowAll" />
///</summary>
[TlObject(0x8b73e763)]
public sealed class TPrivacyValueDisallowAll : IPrivacyRule
{
    public uint ConstructorId => 0x8b73e763;


    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);

    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {

    }
}