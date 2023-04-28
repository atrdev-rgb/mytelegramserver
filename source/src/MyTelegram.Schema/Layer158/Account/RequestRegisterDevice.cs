﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.registerDevice" />
///</summary>
[TlObject(0xec86017a)]
public sealed class RequestRegisterDevice : IRequest<IBool>
{
    public uint ConstructorId => 0xec86017a;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool NoMuted { get; set; }
    public int TokenType { get; set; }
    public string Token { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Bool" />
    ///</summary>
    public bool AppSandbox { get; set; }
    public byte[] Secret { get; set; }
    public TVector<long> OtherUids { get; set; }

    public void ComputeFlag()
    {
        if (NoMuted) { Flags[0] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(TokenType);
        bw.Serialize(Token);
        bw.Serialize(AppSandbox);
        bw.Serialize(Secret);
        OtherUids.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { NoMuted = true; }
        TokenType = br.ReadInt32();
        Token = br.Deserialize<string>();
        AppSandbox = br.Deserialize<bool>();
        Secret = br.Deserialize<byte[]>();
        OtherUids = br.Deserialize<TVector<long>>();
    }
}