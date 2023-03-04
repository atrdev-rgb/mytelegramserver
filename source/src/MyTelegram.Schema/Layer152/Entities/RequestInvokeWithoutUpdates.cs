﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
///See <a href="https://core.telegram.org/method/invokeWithoutUpdates" />
///</summary>
[TlObject(0xbf9459b7)]
public sealed class RequestInvokeWithoutUpdates : IRequest<IObject>
{
    public uint ConstructorId => 0xbf9459b7;
    public IObject Query { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Query.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Query = br.Deserialize<IObject>();
    }
}