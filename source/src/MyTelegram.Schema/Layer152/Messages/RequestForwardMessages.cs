﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.forwardMessages" />
///</summary>
[TlObject(0xc661bbc4)]
public sealed class RequestForwardMessages : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xc661bbc4;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Silent { get; set; }
    public bool Background { get; set; }
    public bool WithMyScore { get; set; }
    public bool DropAuthor { get; set; }
    public bool DropMediaCaptions { get; set; }
    public bool Noforwards { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer FromPeer { get; set; }
    public TVector<int> Id { get; set; }
    public TVector<long> RandomId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer ToPeer { get; set; }
    public int? TopMsgId { get; set; }
    public int? ScheduleDate { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer? SendAs { get; set; }

    public void ComputeFlag()
    {
        if (Silent) { Flags[5] = true; }
        if (Background) { Flags[6] = true; }
        if (WithMyScore) { Flags[8] = true; }
        if (DropAuthor) { Flags[11] = true; }
        if (DropMediaCaptions) { Flags[12] = true; }
        if (Noforwards) { Flags[14] = true; }
        if (TopMsgId != 0 && TopMsgId.HasValue) { Flags[9] = true; }
        if (ScheduleDate != 0 && ScheduleDate.HasValue) { Flags[10] = true; }
        if (SendAs != null) { Flags[13] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        FromPeer.Serialize(bw);
        Id.Serialize(bw);
        RandomId.Serialize(bw);
        ToPeer.Serialize(bw);
        if (Flags[9]) { bw.Write(TopMsgId.Value); }
        if (Flags[10]) { bw.Write(ScheduleDate.Value); }
        if (Flags[13]) { SendAs.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[5]) { Silent = true; }
        if (Flags[6]) { Background = true; }
        if (Flags[8]) { WithMyScore = true; }
        if (Flags[11]) { DropAuthor = true; }
        if (Flags[12]) { DropMediaCaptions = true; }
        if (Flags[14]) { Noforwards = true; }
        FromPeer = br.Deserialize<MyTelegram.Schema.IInputPeer>();
        Id = br.Deserialize<TVector<int>>();
        RandomId = br.Deserialize<TVector<long>>();
        ToPeer = br.Deserialize<MyTelegram.Schema.IInputPeer>();
        if (Flags[9]) { TopMsgId = br.ReadInt32(); }
        if (Flags[10]) { ScheduleDate = br.ReadInt32(); }
        if (Flags[13]) { SendAs = br.Deserialize<MyTelegram.Schema.IInputPeer>(); }
    }
}