﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Enable or disable <a href="https://telegram.org/blog/protected-content-delete-by-date-and-more">content protection</a> on a channel or chat
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHAT_NOT_MODIFIED No changes were made to chat information because the new information you passed is identical to the current information.
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// See <a href="https://corefork.telegram.org/method/messages.toggleNoForwards" />
///</summary>
[TlObject(0xb11eafa2)]
public sealed class RequestToggleNoForwards : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xb11eafa2;
    ///<summary>
    /// The chat or channel
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// Enable or disable content protection
    /// See <a href="https://corefork.telegram.org/type/Bool" />
    ///</summary>
    public bool Enabled { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(Enabled);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        Enabled = reader.Read();
    }
}