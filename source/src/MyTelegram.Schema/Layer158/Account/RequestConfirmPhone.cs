﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.confirmPhone" />
///</summary>
[TlObject(0x5f2178c3)]
public sealed class RequestConfirmPhone : IRequest<IBool>
{
    public uint ConstructorId => 0x5f2178c3;
    public string PhoneCodeHash { get; set; }
    public string PhoneCode { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(PhoneCodeHash);
        bw.Serialize(PhoneCode);
    }

    public void Deserialize(BinaryReader br)
    {
        PhoneCodeHash = br.Deserialize<string>();
        PhoneCode = br.Deserialize<string>();
    }
}