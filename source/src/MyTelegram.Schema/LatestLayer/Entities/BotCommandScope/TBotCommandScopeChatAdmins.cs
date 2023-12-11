﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// The specified bot commands will be valid only for chat administrators, in all <a href="https://corefork.telegram.org/api/channel">groups and supergroups</a>.
/// See <a href="https://corefork.telegram.org/constructor/botCommandScopeChatAdmins" />
///</summary>
[TlObject(0xb9aa606a)]
public sealed class TBotCommandScopeChatAdmins : IBotCommandScope
{
    public uint ConstructorId => 0xb9aa606a;


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