﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Phone;


///<summary>
///See <a href="https://core.telegram.org/constructor/phone.phoneCall" />
///</summary>
[TlObject(0xec82e140)]
public sealed class TPhoneCall : IPhoneCall
{
    public uint ConstructorId => 0xec82e140;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PhoneCall" />
    ///</summary>
    public MyTelegram.Schema.IPhoneCall PhoneCall { get; set; }
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        PhoneCall.Serialize(bw);
        Users.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        PhoneCall = br.Deserialize<MyTelegram.Schema.IPhoneCall>();
        Users = br.Deserialize<TVector<MyTelegram.Schema.IUser>>();
    }
}