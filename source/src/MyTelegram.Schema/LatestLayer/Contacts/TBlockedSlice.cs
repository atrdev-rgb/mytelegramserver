﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Contacts;

///<summary>
/// Incomplete list of blocked users.
/// See <a href="https://corefork.telegram.org/constructor/contacts.blockedSlice" />
///</summary>
[TlObject(0xe1664194)]
public sealed class TBlockedSlice : IBlocked
{
    public uint ConstructorId => 0xe1664194;
    ///<summary>
    /// Total number of elements in the list
    ///</summary>
    public int Count { get; set; }

    ///<summary>
    /// List of blocked users
    ///</summary>
    public TVector<MyTelegram.Schema.IPeerBlocked> Blocked { get; set; }

    ///<summary>
    /// Blocked chats
    ///</summary>
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }

    ///<summary>
    /// List of users
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Count);
        writer.Write(Blocked);
        writer.Write(Chats);
        writer.Write(Users);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Count = reader.ReadInt32();
        Blocked = reader.Read<TVector<MyTelegram.Schema.IPeerBlocked>>();
        Chats = reader.Read<TVector<MyTelegram.Schema.IChat>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
    }
}