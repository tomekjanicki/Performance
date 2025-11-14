using System.Security.Cryptography;
using System.Text;

namespace Performance.B10StackAllocArrayPool;

public static class HashCalculatorWithClassic
{
    public static string GetSha256HashAsBase64EncodedString(Data data)
    {
        var size = GuidFieldSize + GuidFieldSize + GetByteCount(data.Value3);
        var array = new byte[size];
        var counter = 0;
        Write(data.Value1, array, ref counter);
        Write(data.Value2, array, ref counter);
        Write(data.Value3, array, ref counter);

        return GetSha256AsBase64EncodedString(array);
    }
    
    private const int GuidFieldSize = 17;
    
    private static string GetSha256AsBase64EncodedString(ReadOnlyMemory<byte> array) => 
        Convert.ToBase64String(SHA256.HashData(array.Span));

    private static void Write(Guid? value, Memory<byte> array, ref int counter)
    {
        array.Span[counter] = value is not null ? (byte)1 : (byte)0;
        var val = value ?? Guid.Empty;
        if (!val.TryWriteBytes(array.Span.Slice(counter + 1, 16)))
        {
            RaiseSpanCopyFailureException();
        }
        counter += GuidFieldSize;
    }

    private static void Write(string value, Memory<byte> array, ref int counter) => 
        counter += Encoding.UTF8.GetBytes(value.AsSpan(), array.Span[counter..]);

    private static int GetByteCount(string value) => 
        Encoding.UTF8.GetByteCount(value);

    private static void RaiseSpanCopyFailureException() => 
        throw new InvalidOperationException("Failed to copy source to span");
}