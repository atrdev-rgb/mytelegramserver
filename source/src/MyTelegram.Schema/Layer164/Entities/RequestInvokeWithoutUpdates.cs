﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Invoke a request without subscribing the used connection for <a href="https://corefork.telegram.org/api/updates">updates</a> (this is enabled by default for <a href="https://corefork.telegram.org/api/files">file queries</a>).
/// See <a href="https://corefork.telegram.org/method/invokeWithoutUpdates" />
///</summary>
[TlObject(0xbf9459b7)]
public sealed class RequestInvokeWithoutUpdates : IRequest<IObject>
{
    public uint ConstructorId => 0xbf9459b7;
    ///<summary>
    /// The query
    ///</summary>
    public IObject Query { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Query);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Query = reader.Read<IObject>();
    }
}