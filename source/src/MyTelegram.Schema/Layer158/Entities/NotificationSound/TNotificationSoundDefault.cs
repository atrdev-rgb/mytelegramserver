﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/notificationSoundDefault" />
///</summary>
[TlObject(0x97e8bebe)]
public sealed class TNotificationSoundDefault : INotificationSound
{
    public uint ConstructorId => 0x97e8bebe;


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