﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Details about an accepted authorization request, for more info <a href="https://corefork.telegram.org/api/url-authorization">click here »</a>
/// See <a href="https://corefork.telegram.org/constructor/urlAuthResultAccepted" />
///</summary>
[TlObject(0x8f8c0e4e)]
public sealed class TUrlAuthResultAccepted : IUrlAuthResult
{
    public uint ConstructorId => 0x8f8c0e4e;
    ///<summary>
    /// The URL name of the website on which the user has logged in.
    ///</summary>
    public string Url { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Url);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Url = reader.ReadString();
    }
}