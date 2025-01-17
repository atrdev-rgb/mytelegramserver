﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Settings used by telegram servers for sending the confirm code.Example implementations: <a href="https://github.com/DrKLO/Telegram/blob/master/TMessagesProj/src/main/java/org/telegram/ui/LoginActivity.java">telegram for android</a>, <a href="https://github.com/tdlib/td/tree/master/td/telegram/SendCodeHelper.cpp">tdlib</a>.
/// See <a href="https://corefork.telegram.org/constructor/codeSettings" />
///</summary>
[TlObject(0xad253d78)]
public sealed class TCodeSettings : ICodeSettings
{
    public uint ConstructorId => 0xad253d78;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether to allow phone verification via <a href="https://corefork.telegram.org/api/auth">phone calls</a>.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool AllowFlashcall { get; set; }

    ///<summary>
    /// Pass true if the phone number is used on the current device. Ignored if allow_flashcall is not set.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool CurrentNumber { get; set; }

    ///<summary>
    /// If a token that will be included in eventually sent SMSs is required: required in newer versions of android, to use the <a href="https://developers.google.com/identity/sms-retriever/overview">android SMS receiver APIs</a>
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool AllowAppHash { get; set; }

    ///<summary>
    /// Whether this device supports receiving the code using the <a href="https://corefork.telegram.org/constructor/auth.codeTypeMissedCall">auth.codeTypeMissedCall</a> method
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool AllowMissedCall { get; set; }

    ///<summary>
    /// Whether Firebase auth is supported
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool AllowFirebase { get; set; }

    ///<summary>
    /// Set this flag if there is a SIM card in the current device, but it is not possible to check whether the specified phone number matches the SIM's phone number.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool UnknownNumber { get; set; }

    ///<summary>
    /// Previously stored future auth tokens, see <a href="https://corefork.telegram.org/api/auth#future-auth-tokens">the documentation for more info »</a>
    ///</summary>
    public TVector<byte[]>? LogoutTokens { get; set; }

    ///<summary>
    /// Used only by official iOS apps for Firebase auth: device token for apple push.
    ///</summary>
    public string? Token { get; set; }

    ///<summary>
    /// Used only by official iOS apps for firebase auth: whether a sandbox-certificate will be used during transmission of the push notification.
    /// See <a href="https://corefork.telegram.org/type/Bool" />
    ///</summary>
    public bool? AppSandbox { get; set; }

    public void ComputeFlag()
    {
        if (AllowFlashcall) { Flags[0] = true; }
        if (CurrentNumber) { Flags[1] = true; }
        if (AllowAppHash) { Flags[4] = true; }
        if (AllowMissedCall) { Flags[5] = true; }
        if (AllowFirebase) { Flags[7] = true; }
        if (UnknownNumber) { Flags[9] = true; }
        if (LogoutTokens?.Count > 0) { Flags[6] = true; }
        if (Token != null) { Flags[8] = true; }
        if (AppSandbox !=null) { Flags[8] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        if (Flags[6]) { writer.Write(LogoutTokens); }
        if (Flags[8]) { writer.Write(Token); }
        if (Flags[8]) { writer.Write(AppSandbox.Value); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { AllowFlashcall = true; }
        if (Flags[1]) { CurrentNumber = true; }
        if (Flags[4]) { AllowAppHash = true; }
        if (Flags[5]) { AllowMissedCall = true; }
        if (Flags[7]) { AllowFirebase = true; }
        if (Flags[9]) { UnknownNumber = true; }
        if (Flags[6]) { LogoutTokens = reader.Read<TVector<byte[]>>(); }
        if (Flags[8]) { Token = reader.ReadString(); }
        if (Flags[8]) { AppSandbox = reader.Read(); }
    }
}