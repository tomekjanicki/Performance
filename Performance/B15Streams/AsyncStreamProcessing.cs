using System.Runtime.CompilerServices;

namespace Performance.B15Streams;

public static class AsyncStreamProcessing
{
    public static async Task ReWrite(string fileName, string writeFileName, CancellationToken cancellationToken)
    {
        var buffer = new byte[4];
        await using var stream = new FileStream(writeFileName, FileMode.CreateNew, FileAccess.Write, FileShare.None,
            bufferSize: 4096, useAsync: true);
        await foreach (var row in EnumerateRows(fileName, cancellationToken))
        {
            await stream.WriteResult(row, buffer, cancellationToken);
        }
    }

    private static async IAsyncEnumerable<Result> EnumerateRows(string fileName, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        const int rowSize = 3;
        var buffer = new Memory<byte>(new byte[rowSize]);
        await using var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None,
            bufferSize: 4096, useAsync: true);
        while (true)
        {
            var readResult = await stream.ReadAsync(buffer, cancellationToken);
            if (readResult == 0)
            {
                yield break;
            }

            yield return new Result
            {
                F1 = buffer.Span[0],
                F2 = buffer.Span[1],
                F3 = buffer.Span[2]
            }; 
        }
    }
}