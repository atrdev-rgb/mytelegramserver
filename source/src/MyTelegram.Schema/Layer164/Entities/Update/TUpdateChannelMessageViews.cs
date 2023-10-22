﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// The view counter of a message in a channel has changed
/// See <a href="https://corefork.telegram.org/constructor/updateChannelMessageViews" />
///</summary>
[TlObject(0xf226ac08)]
public sealed class TUpdateChannelMessageViews : IUpdate
{
    public uint ConstructorId => 0xf226ac08;
    ///<summary>
    /// Channel ID
    ///</summary>
    public long ChannelId { get; set; }

    ///<summary>
    /// ID of the message
    ///</summary>
    public int Id { get; set; }

    ///<summary>
    /// New view counter
    ///</summary>
    public int Views { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(ChannelId);
        writer.Write(Id);
        writer.Write(Views);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        ChannelId = reader.ReadInt64();
        Id = reader.ReadInt32();
        Views = reader.ReadInt32();
    }
}