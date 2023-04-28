﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Bots;

///<summary>
///See <a href="https://core.telegram.org/method/bots.reorderUsernames" />
///</summary>
[TlObject(0x9709b1c2)]
public sealed class RequestReorderUsernames : IRequest<IBool>
{
    public uint ConstructorId => 0x9709b1c2;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser Bot { get; set; }
    public TVector<string> Order { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Bot.Serialize(bw);
        Order.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Bot = br.Deserialize<MyTelegram.Schema.IInputUser>();
        Order = br.Deserialize<TVector<string>>();
    }
}