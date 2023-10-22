﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Statistics value couple; initial and final value for period of time currently in consideration
/// See <a href="https://corefork.telegram.org/constructor/statsAbsValueAndPrev" />
///</summary>
[TlObject(0xcb43acde)]
public sealed class TStatsAbsValueAndPrev : IStatsAbsValueAndPrev
{
    public uint ConstructorId => 0xcb43acde;
    ///<summary>
    /// Current value
    ///</summary>
    public double Current { get; set; }

    ///<summary>
    /// Previous value
    ///</summary>
    public double Previous { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Current);
        writer.Write(Previous);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Current = reader.ReadDouble();
        Previous = reader.ReadDouble();
    }
}