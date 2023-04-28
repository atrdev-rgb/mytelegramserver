﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Auth;

///<summary>
///See <a href="https://core.telegram.org/method/auth.sendCode" />
///</summary>
[TlObject(0xa677244f)]
public sealed class RequestSendCode : IRequest<MyTelegram.Schema.Auth.ISentCode>
{
    public uint ConstructorId => 0xa677244f;
    public string PhoneNumber { get; set; }
    public int ApiId { get; set; }
    public string ApiHash { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/CodeSettings" />
    ///</summary>
    public MyTelegram.Schema.ICodeSettings Settings { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(PhoneNumber);
        bw.Write(ApiId);
        bw.Serialize(ApiHash);
        Settings.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        PhoneNumber = br.Deserialize<string>();
        ApiId = br.ReadInt32();
        ApiHash = br.Deserialize<string>();
        Settings = br.Deserialize<MyTelegram.Schema.ICodeSettings>();
    }
}