﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Premium;

///<summary>
/// Returns the lists of boost that were applied to a channel/supergroup by a specific user (admins only)
/// <para>Possible errors</para>
/// Code Type Description
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// See <a href="https://corefork.telegram.org/method/premium.getUserBoosts" />
///</summary>
[TlObject(0x39854d1f)]
public sealed class RequestGetUserBoosts : IRequest<MyTelegram.Schema.Premium.IBoostsList>
{
    public uint ConstructorId => 0x39854d1f;
    ///<summary>
    /// The channel/supergroup
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// The user
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
        writer.Write(Peer);
        writer.Write(UserId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        UserId = reader.Read<MyTelegram.Schema.IInputUser>();
    }
}
