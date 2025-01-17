﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Contains info about a <a href="https://corefork.telegram.org/api/business#connected-bots">bot business connection</a>.
/// See <a href="https://corefork.telegram.org/constructor/botBusinessConnection" />
///</summary>
[TlObject(0x896433b4)]
public sealed class TBotBusinessConnection : IBotBusinessConnection
{
    public uint ConstructorId => 0x896433b4;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether the bot can reply on behalf of the user to messages it receives through the business connection
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool CanReply { get; set; }

    ///<summary>
    /// Whether this business connection is currently disabled
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Disabled { get; set; }

    ///<summary>
    /// Business connection ID, used to identify messages coming from the connection and to reply to them as specified <a href="https://corefork.telegram.org/api/business#connected-bots">here »</a>.
    ///</summary>
    public string ConnectionId { get; set; }

    ///<summary>
    /// ID of the user that the bot is connected to via this connection.
    ///</summary>
    public long UserId { get; set; }

    ///<summary>
    /// ID of the datacenter where to send queries wrapped in a <a href="https://corefork.telegram.org/method/invokeWithBusinessConnection">invokeWithBusinessConnection</a> as specified <a href="https://corefork.telegram.org/api/business#connected-bots">here »</a>.
    ///</summary>
    public int DcId { get; set; }

    ///<summary>
    /// When was the connection created.
    ///</summary>
    public int Date { get; set; }

    public void ComputeFlag()
    {
        if (CanReply) { Flags[0] = true; }
        if (Disabled) { Flags[1] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(ConnectionId);
        writer.Write(UserId);
        writer.Write(DcId);
        writer.Write(Date);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { CanReply = true; }
        if (Flags[1]) { Disabled = true; }
        ConnectionId = reader.ReadString();
        UserId = reader.ReadInt64();
        DcId = reader.ReadInt32();
        Date = reader.ReadInt32();
    }
}