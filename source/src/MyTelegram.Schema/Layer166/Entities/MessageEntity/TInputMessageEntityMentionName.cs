﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Message entity that can be used to create a user <a href="https://corefork.telegram.org/api/mentions">user mention</a>: received mentions use the <a href="https://corefork.telegram.org/constructor/messageEntityMentionName">messageEntityMentionName</a> constructor, instead.
/// See <a href="https://corefork.telegram.org/constructor/inputMessageEntityMentionName" />
///</summary>
[TlObject(0x208e68c9)]
public sealed class TInputMessageEntityMentionName : IMessageEntity
{
    public uint ConstructorId => 0x208e68c9;
    ///<summary>
    /// Offset of message entity within message (in <a href="https://corefork.telegram.org/api/entities#entity-length">UTF-16 code units</a>)
    ///</summary>
    public int Offset { get; set; }

    ///<summary>
    /// Length of message entity within message (in <a href="https://corefork.telegram.org/api/entities#entity-length">UTF-16 code units</a>)
    ///</summary>
    public int Length { get; set; }

    ///<summary>
    /// Identifier of the user that was mentioned
    /// See <a href="https://corefork.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser UserId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Offset);
        writer.Write(Length);
        writer.Write(UserId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Offset = reader.ReadInt32();
        Length = reader.ReadInt32();
        UserId = reader.Read<MyTelegram.Schema.IInputUser>();
    }
}