﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageActionPaymentSentMe" />
///</summary>
[TlObject(0x8f31b327)]
public sealed class TMessageActionPaymentSentMe : IMessageAction
{
    public uint ConstructorId => 0x8f31b327;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool RecurringInit { get; set; }
    public bool RecurringUsed { get; set; }
    public string Currency { get; set; }
    public long TotalAmount { get; set; }
    public byte[] Payload { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PaymentRequestedInfo" />
    ///</summary>
    public MyTelegram.Schema.IPaymentRequestedInfo? Info { get; set; }
    public string? ShippingOptionId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PaymentCharge" />
    ///</summary>
    public MyTelegram.Schema.IPaymentCharge Charge { get; set; }

    public void ComputeFlag()
    {
        if (RecurringInit) { Flags[2] = true; }
        if (RecurringUsed) { Flags[3] = true; }
        if (Info != null) { Flags[0] = true; }
        if (ShippingOptionId != null) { Flags[1] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Serialize(Currency);
        bw.Write(TotalAmount);
        bw.Serialize(Payload);
        if (Flags[0]) { Info.Serialize(bw); }
        if (Flags[1]) { bw.Serialize(ShippingOptionId); }
        Charge.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[2]) { RecurringInit = true; }
        if (Flags[3]) { RecurringUsed = true; }
        Currency = br.Deserialize<string>();
        TotalAmount = br.ReadInt64();
        Payload = br.Deserialize<byte[]>();
        if (Flags[0]) { Info = br.Deserialize<MyTelegram.Schema.IPaymentRequestedInfo>(); }
        if (Flags[1]) { ShippingOptionId = br.Deserialize<string>(); }
        Charge = br.Deserialize<MyTelegram.Schema.IPaymentCharge>();
    }
}