﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/keyboardButtonCopy" />
///</summary>
[TlObject(0x75d2698e)]
public sealed class TKeyboardButtonCopy : IKeyboardButton
{
    public uint ConstructorId => 0x75d2698e;
    public string Text { get; set; }
    public string CopyText { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Text);
        writer.Write(CopyText);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Text = reader.ReadString();
        CopyText = reader.ReadString();
    }
}