﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Payments;


///<summary>
///See <a href="https://core.telegram.org/constructor/payments.validatedRequestedInfo" />
///</summary>
[TlObject(0xd1451883)]
public sealed class TValidatedRequestedInfo : IValidatedRequestedInfo
{
    public uint ConstructorId => 0xd1451883;
    public BitArray Flags { get; set; } = new BitArray(32);
    public string? Id { get; set; }
    public TVector<MyTelegram.Schema.IShippingOption>? ShippingOptions { get; set; }

    public void ComputeFlag()
    {
        if (Id != null) { Flags[0] = true; }
        if (ShippingOptions?.Count > 0) { Flags[1] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[0]) { bw.Serialize(Id); }
        if (Flags[1]) { ShippingOptions.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Id = br.Deserialize<string>(); }
        if (Flags[1]) { ShippingOptions = br.Deserialize<TVector<MyTelegram.Schema.IShippingOption>>(); }
    }
}