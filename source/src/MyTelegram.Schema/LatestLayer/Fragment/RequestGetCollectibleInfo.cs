﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Fragment;

///<summary>
/// Fetch information about a <a href="https://corefork.telegram.org/api/fragment#fetching-info-about-fragment-collectibles">fragment collectible, see here »</a> for more info on the full flow.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 COLLECTIBLE_INVALID The specified collectible is invalid.
/// 400 COLLECTIBLE_NOT_FOUND The specified collectible could not be found.
/// See <a href="https://corefork.telegram.org/method/fragment.getCollectibleInfo" />
///</summary>
[TlObject(0xbe1e85ba)]
public sealed class RequestGetCollectibleInfo : IRequest<MyTelegram.Schema.Fragment.ICollectibleInfo>
{
    public uint ConstructorId => 0xbe1e85ba;
    ///<summary>
    /// Collectible to fetch info about.
    /// See <a href="https://corefork.telegram.org/type/InputCollectible" />
    ///</summary>
    public MyTelegram.Schema.IInputCollectible Collectible { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Collectible);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Collectible = reader.Read<MyTelegram.Schema.IInputCollectible>();
    }
}
