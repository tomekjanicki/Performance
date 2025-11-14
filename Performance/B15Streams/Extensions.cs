namespace Performance.B15Streams;

public static class Extensions
{
    public static async Task WriteResult(this Stream stream, Result result, Memory<byte> buffer, CancellationToken cancellationToken)
    {
        buffer.Span[0] = result.F1;
        buffer.Span[1] = result.F2;
        buffer.Span[2] = result.F3;
        buffer.Span[3] = result.Average;
        await stream.WriteAsync(buffer, cancellationToken);
    }
}