﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
/// A list of peers that can be used to send messages in a specific group
/// See <a href="https://corefork.telegram.org/constructor/channels.sendAsPeers" />
///</summary>
[TlObject(0xf496b0c6)]
public sealed class TSendAsPeers : ISendAsPeers
{
    public uint ConstructorId => 0xf496b0c6;
    ///<summary>
    /// Peers that can be used to send messages to the group
    ///</summary>
    public TVector<MyTelegram.Schema.ISendAsPeer> Peers { get; set; }

    ///<summary>
    /// Mentioned chats
    ///</summary>
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }

    ///<summary>
    /// Mentioned users
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peers);
        writer.Write(Chats);
        writer.Write(Users);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peers = reader.Read<TVector<MyTelegram.Schema.ISendAsPeer>>();
        Chats = reader.Read<TVector<MyTelegram.Schema.IChat>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
    }
}