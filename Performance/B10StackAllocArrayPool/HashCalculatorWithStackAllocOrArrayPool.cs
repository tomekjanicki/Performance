using System.Buffers;
using System.Security.Cryptography;
using System.Text;

namespace Performance.B10StackAllocArrayPool;

public static class HashCalculatorWithStackAllocOrArrayPool
{
    public static string GetSha256HashAsBase64EncodedString(Data data)
    {
        var size = GuidFieldSize + GuidFieldSize + GetByteCount(data.Value3);
        const int maxStackSize = 500;
        if (size <= maxStackSize)
        {
            Span<byte> span = stackalloc byte[size];
            
            return GetSha256AsBase64EncodedString(data, span);
        }
        var bytes = ArrayPool<byte>.Shared.Rent(size);
        try
        {
            return GetSha256AsBase64EncodedString(data, bytes);
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(bytes);
        }
    }

    private static string GetSha256AsBase64EncodedString(Data data, Span<byte> span)
    {
        var counter = 0;
        Write(data.Value1, span[counter..], ref counter);
        Write(data.Value2, span[counter..], ref counter);
        Write(data.Value3, span[counter..], ref counter);

        return GetSha256AsBase64EncodedString(span);
    }
    
    private static string GetSha256AsBase64EncodedString(ReadOnlySpan<byte> raw)
    {
        Span<byte> hash = stackalloc byte[32];
        if (!SHA256.TryHashData(raw, hash, out var bytes))
        {
            RaiseSpanCopyFailureException();
        }

        return Convert.ToBase64String(hash[..bytes]);
    }
    
    private static void Write(Guid? value, Span<byte> span, ref int counter)
    {
        if (!BitConverter.TryWriteBytes(span[..1], value is not null))
        {
            RaiseSpanCopyFailureException();
        }
        var val = value ?? Guid.Empty;
        if (!val.TryWriteBytes(span.Slice(1, 16)))
        {
            RaiseSpanCopyFailureException();
        }
        counter += GuidFieldSize;
    }

    private const int GuidFieldSize = 17;

    private static void Write(string value, Span<byte> span, ref int counter) => 
        counter += Encoding.UTF8.GetBytes(value.AsSpan(), span);

    private static int GetByteCount(string value) => 
        Encoding.UTF8.GetByteCount(value);

    private static void RaiseSpanCopyFailureException() => 
        throw new InvalidOperationException("Failed to copy source to span");
}