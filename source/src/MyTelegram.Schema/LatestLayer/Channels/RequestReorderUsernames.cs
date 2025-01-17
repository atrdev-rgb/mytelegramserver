﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
/// Reorder active usernames
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNEL_INVALID The provided channel is invalid.
/// 400 CHAT_NOT_MODIFIED No changes were made to chat information because the new information you passed is identical to the current information.
/// See <a href="https://corefork.telegram.org/method/channels.reorderUsernames" />
///</summary>
[TlObject(0xb45ced1d)]
public sealed class RequestReorderUsernames : IRequest<IBool>
{
    public uint ConstructorId => 0xb45ced1d;
    ///<summary>
    /// The supergroup or channel
    /// See <a href="https://corefork.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }

    ///<summary>
    /// The new order for active usernames. All active usernames must be specified.
    ///</summary>
    public TVector<string> Order { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Channel);
        writer.Write(Order);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Channel = reader.Read<MyTelegram.Schema.IInputChannel>();
        Order = reader.Read<TVector<string>>();
    }
}
