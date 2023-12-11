﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Information about sparse positions of messages
/// See <a href="https://corefork.telegram.org/constructor/messages.searchResultsPositions" />
///</summary>
[TlObject(0x53b22baf)]
public sealed class TSearchResultsPositions : ISearchResultsPositions
{
    public uint ConstructorId => 0x53b22baf;
    ///<summary>
    /// Total number of found messages
    ///</summary>
    public int Count { get; set; }

    ///<summary>
    /// List of message positions
    ///</summary>
    public TVector<MyTelegram.Schema.ISearchResultsPosition> Positions { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Count);
        writer.Write(Positions);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Count = reader.ReadInt32();
        Positions = reader.Read<TVector<MyTelegram.Schema.ISearchResultsPosition>>();
    }
}