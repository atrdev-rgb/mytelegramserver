﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Online status: last seen recently
/// See <a href="https://corefork.telegram.org/constructor/userStatusRecently" />
///</summary>
[TlObject(0xe26f42f1)]
public sealed class TUserStatusRecently : IUserStatus
{
    public uint ConstructorId => 0xe26f42f1;


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