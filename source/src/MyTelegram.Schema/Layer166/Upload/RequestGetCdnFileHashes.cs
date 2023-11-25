﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Upload;

///<summary>
/// Get SHA256 hashes for verifying downloaded <a href="https://corefork.telegram.org/cdn">CDN</a> files
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CDN_METHOD_INVALID You can't call this method in a CDN DC.
/// 400 RSA_DECRYPT_FAILED Internal RSA decryption failed.
/// See <a href="https://corefork.telegram.org/method/upload.getCdnFileHashes" />
///</summary>
[TlObject(0x91dc3f31)]
public sealed class RequestGetCdnFileHashes : IRequest<TVector<MyTelegram.Schema.IFileHash>>
{
    public uint ConstructorId => 0x91dc3f31;
    ///<summary>
    /// File
    ///</summary>
    public byte[] FileToken { get; set; }

    ///<summary>
    /// Offset from which to start getting hashes
    ///</summary>
    public long Offset { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(FileToken);
        writer.Write(Offset);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        FileToken = reader.ReadBytes();
        Offset = reader.ReadInt64();
    }
}