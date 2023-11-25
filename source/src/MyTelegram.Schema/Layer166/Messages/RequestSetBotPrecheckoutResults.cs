﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Once the user has confirmed their payment and shipping details, the bot receives an <a href="https://corefork.telegram.org/constructor/updateBotPrecheckoutQuery">updateBotPrecheckoutQuery</a> update.<br>
/// Use this method to respond to such pre-checkout queries.<br>
/// <strong>Note</strong>: Telegram must receive an answer within 10 seconds after the pre-checkout query was sent.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 ERROR_TEXT_EMPTY The provided error message is empty.
/// See <a href="https://corefork.telegram.org/method/messages.setBotPrecheckoutResults" />
///</summary>
[TlObject(0x9c2dd95)]
public sealed class RequestSetBotPrecheckoutResults : IRequest<IBool>
{
    public uint ConstructorId => 0x9c2dd95;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Set this flag if everything is alright (goods are available, etc.) and the bot is ready to proceed with the order, otherwise do not set it, and set the <code>error</code> field, instead
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Success { get; set; }

    ///<summary>
    /// Unique identifier for the query to be answered
    ///</summary>
    public long QueryId { get; set; }

    ///<summary>
    /// Required if the <code>success</code> isn't set. Error message in human readable form that explains the reason for failure to proceed with the checkout (e.g. "Sorry, somebody just bought the last of our amazing black T-shirts while you were busy filling out your payment details. Please choose a different color or garment!"). Telegram will display this message to the user.
    ///</summary>
    public string? Error { get; set; }

    public void ComputeFlag()
    {
        if (Success) { Flags[1] = true; }
        if (Error != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(QueryId);
        if (Flags[0]) { writer.Write(Error); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { Success = true; }
        QueryId = reader.ReadInt64();
        if (Flags[0]) { Error = reader.ReadString(); }
    }
}