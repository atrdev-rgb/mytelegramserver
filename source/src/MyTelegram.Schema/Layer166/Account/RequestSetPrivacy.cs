﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
/// Change privacy settings of current account
/// <para>Possible errors</para>
/// Code Type Description
/// 400 PRIVACY_KEY_INVALID The privacy key is invalid.
/// 400 PRIVACY_TOO_LONG Too many privacy rules were specified, the current limit is 1000.
/// 400 PRIVACY_VALUE_INVALID The specified privacy rule combination is invalid.
/// See <a href="https://corefork.telegram.org/method/account.setPrivacy" />
///</summary>
[TlObject(0xc9f81ce8)]
public sealed class RequestSetPrivacy : IRequest<MyTelegram.Schema.Account.IPrivacyRules>
{
    public uint ConstructorId => 0xc9f81ce8;
    ///<summary>
    /// New privacy rule
    /// See <a href="https://corefork.telegram.org/type/InputPrivacyKey" />
    ///</summary>
    public MyTelegram.Schema.IInputPrivacyKey Key { get; set; }

    ///<summary>
    /// Peers to which the privacy rule will apply.
    ///</summary>
    public TVector<MyTelegram.Schema.IInputPrivacyRule> Rules { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Key);
        writer.Write(Rules);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Key = reader.Read<MyTelegram.Schema.IInputPrivacyKey>();
        Rules = reader.Read<TVector<MyTelegram.Schema.IInputPrivacyRule>>();
    }
}