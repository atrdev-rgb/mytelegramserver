﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// The <a href="https://corefork.telegram.org/api/wallpapers">wallpaper »</a> of the current chat was changed.
/// See <a href="https://corefork.telegram.org/constructor/messageActionSetChatWallPaper" />
///</summary>
[TlObject(0x5060a3f4)]
public sealed class TMessageActionSetChatWallPaper : IMessageAction
{
    public uint ConstructorId => 0x5060a3f4;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Same { get; set; }
    public bool ForBoth { get; set; }

    ///<summary>
    /// New <a href="https://corefork.telegram.org/api/wallpapers">wallpaper</a>
    /// See <a href="https://corefork.telegram.org/type/WallPaper" />
    ///</summary>
    public MyTelegram.Schema.IWallPaper Wallpaper { get; set; }

    public void ComputeFlag()
    {
        if (Same) { Flags[0] = true; }
        if (ForBoth) { Flags[1] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Wallpaper);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Same = true; }
        if (Flags[1]) { ForBoth = true; }
        Wallpaper = reader.Read<MyTelegram.Schema.IWallPaper>();
    }
}