﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;


///<summary>
///See <a href="https://core.telegram.org/constructor/messages.sentEncryptedFile" />
///</summary>
[TlObject(0x9493ff32)]
public sealed class TSentEncryptedFile : ISentEncryptedMessage
{
    public uint ConstructorId => 0x9493ff32;
    public int Date { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/EncryptedFile" />
    ///</summary>
    public MyTelegram.Schema.IEncryptedFile File { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Date);
        File.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Date = br.ReadInt32();
        File = br.Deserialize<MyTelegram.Schema.IEncryptedFile>();
    }
}