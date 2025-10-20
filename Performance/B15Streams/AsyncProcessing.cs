namespace Performance.B15Streams;

public static class AsyncProcessing
{
    public static async Task WriteRows(string fileName, IReadOnlyCollection<Result> results, CancellationToken cancellationToken)
    {
        var buffer = new byte[4];
        await using var stream = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write, FileShare.None,
            bufferSize: 4096, useAsync: true);
        foreach (var result in results)
        {
            await stream.WriteResult(result, buffer, cancellationToken);
        }
    }
    
    public static async Task<IReadOnlyCollection<Result>> GetRows(string fileName, CancellationToken cancellationToken)
    {
        const int rowSize = 3;
        var data = (await File.ReadAllBytesAsync(fileName, cancellationToken)).AsSpan();
        var result = new List<Result>();
        var index = 0;
        while (true)
        {
            if (index >= data.Length)
            {
                break;
            }
            var item = data.Slice(index, rowSize);
            index += rowSize;
            result.Add(new Result
            {
                F1 = item[0],
                F2 = item[1],
                F3 = item[2]
            });
        }

        return result;
    }
}