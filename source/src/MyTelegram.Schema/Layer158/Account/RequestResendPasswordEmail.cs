﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.resendPasswordEmail" />
///</summary>
[TlObject(0x7a7f2a15)]
public sealed class RequestResendPasswordEmail : IRequest<IBool>
{
    public uint ConstructorId => 0x7a7f2a15;

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}