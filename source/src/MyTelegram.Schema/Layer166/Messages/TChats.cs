﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// List of chats with auxiliary data.
/// See <a href="https://corefork.telegram.org/constructor/messages.chats" />
///</summary>
[TlObject(0x64ff9fd5)]
public sealed class TChats : IChats
{
    public uint ConstructorId => 0x64ff9fd5;
    ///<summary>
    /// List of chats
    ///</summary>
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Chats);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Chats = reader.Read<TVector<MyTelegram.Schema.IChat>>();
    }
}