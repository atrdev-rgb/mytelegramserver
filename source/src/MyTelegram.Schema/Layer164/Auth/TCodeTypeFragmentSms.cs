﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Auth;

///<summary>
/// The next time, the authentication code will be delivered via <a href="https://fragment.com/">fragment.com</a>
/// See <a href="https://corefork.telegram.org/constructor/auth.codeTypeFragmentSms" />
///</summary>
[TlObject(0x6ed998c)]
public sealed class TCodeTypeFragmentSms : ICodeType
{
    public uint ConstructorId => 0x6ed998c;


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