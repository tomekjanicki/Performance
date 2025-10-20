namespace Performance.B15Streams;

public readonly record struct Result(byte F1, byte F2, byte F3)
{
    public byte Average => (byte)((F1 + F2 + F3) / 3);
}