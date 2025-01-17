﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Send a <a href="https://corefork.telegram.org/api/business#quick-reply-shortcuts">quick reply shortcut »</a>.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// 403 PREMIUM_ACCOUNT_REQUIRED A premium account is required to execute this action.
/// See <a href="https://corefork.telegram.org/method/messages.sendQuickReplyMessages" />
///</summary>
[TlObject(0x6c750de1)]
public sealed class RequestSendQuickReplyMessages : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x6c750de1;
    ///<summary>
    /// The peer where to send the shortcut (users only, for now).
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// The ID of the quick reply shortcut to send.
    ///</summary>
    public int ShortcutId { get; set; }

    ///<summary>
    /// Specify a subset of messages from the shortcut to send; if empty, defaults to all of them.
    ///</summary>
    public TVector<int> Id { get; set; }

    ///<summary>
    /// Unique client IDs required to prevent message resending, one for each message we're sending, may be empty (but not recommended).
    ///</summary>
    public TVector<long> RandomId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(ShortcutId);
        writer.Write(Id);
        writer.Write(RandomId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        ShortcutId = reader.ReadInt32();
        Id = reader.Read<TVector<int>>();
        RandomId = reader.Read<TVector<long>>();
    }
}
