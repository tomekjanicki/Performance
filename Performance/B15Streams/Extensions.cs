namespace Performance.B15Streams;

public static class Extensions
{
    public static async Task WriteResult(this Stream stream, Result result, byte[] buffer, CancellationToken cancellationToken)
    {
        buffer[0] = result.F1;
        buffer[1] = result.F2;
        buffer[2] = result.F3;
        buffer[3] = result.Average;
        await stream.WriteAsync(buffer, cancellationToken);
    }
}