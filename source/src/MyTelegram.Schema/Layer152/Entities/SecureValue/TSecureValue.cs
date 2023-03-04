﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/secureValue" />
///</summary>
[TlObject(0x187fa0ca)]
public sealed class TSecureValue : ISecureValue
{
    public uint ConstructorId => 0x187fa0ca;
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    ///See <a href="https://core.telegram.org/type/SecureValueType" />
    ///</summary>
    public MyTelegram.Schema.ISecureValueType Type { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/SecureData" />
    ///</summary>
    public MyTelegram.Schema.ISecureData? Data { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/SecureFile" />
    ///</summary>
    public MyTelegram.Schema.ISecureFile? FrontSide { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/SecureFile" />
    ///</summary>
    public MyTelegram.Schema.ISecureFile? ReverseSide { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/SecureFile" />
    ///</summary>
    public MyTelegram.Schema.ISecureFile? Selfie { get; set; }
    public TVector<MyTelegram.Schema.ISecureFile>? Translation { get; set; }
    public TVector<MyTelegram.Schema.ISecureFile>? Files { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/SecurePlainData" />
    ///</summary>
    public MyTelegram.Schema.ISecurePlainData? PlainData { get; set; }
    public byte[] Hash { get; set; }

    public void ComputeFlag()
    {
        if (Data != null) { Flags[0] = true; }
        if (FrontSide != null) { Flags[1] = true; }
        if (ReverseSide != null) { Flags[2] = true; }
        if (Selfie != null) { Flags[3] = true; }
        if (Translation?.Count > 0) { Flags[6] = true; }
        if (Files?.Count > 0) { Flags[4] = true; }
        if (PlainData != null) { Flags[5] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Type.Serialize(bw);
        if (Flags[0]) { Data.Serialize(bw); }
        if (Flags[1]) { FrontSide.Serialize(bw); }
        if (Flags[2]) { ReverseSide.Serialize(bw); }
        if (Flags[3]) { Selfie.Serialize(bw); }
        if (Flags[6]) { Translation.Serialize(bw); }
        if (Flags[4]) { Files.Serialize(bw); }
        if (Flags[5]) { PlainData.Serialize(bw); }
        bw.Serialize(Hash);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        Type = br.Deserialize<MyTelegram.Schema.ISecureValueType>();
        if (Flags[0]) { Data = br.Deserialize<MyTelegram.Schema.ISecureData>(); }
        if (Flags[1]) { FrontSide = br.Deserialize<MyTelegram.Schema.ISecureFile>(); }
        if (Flags[2]) { ReverseSide = br.Deserialize<MyTelegram.Schema.ISecureFile>(); }
        if (Flags[3]) { Selfie = br.Deserialize<MyTelegram.Schema.ISecureFile>(); }
        if (Flags[6]) { Translation = br.Deserialize<TVector<MyTelegram.Schema.ISecureFile>>(); }
        if (Flags[4]) { Files = br.Deserialize<TVector<MyTelegram.Schema.ISecureFile>>(); }
        if (Flags[5]) { PlainData = br.Deserialize<MyTelegram.Schema.ISecurePlainData>(); }
        Hash = br.Deserialize<byte[]>();
    }
}