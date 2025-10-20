using BenchmarkDotNet.Attributes;

namespace Performance.B15Streams;

public class StreamsBenchmark
{
    private static readonly string FileName = GetFile();

    private static string GetFile()
    {
        const int rowCount = 200000; 
        var fileName = Guid.NewGuid().ToString();
        Generator.Save(fileName, rowCount);

        return fileName;
    }
    
    [Benchmark]
    public async Task AsyncProcessingGetRowsWriteRows()
    {
        var results = await AsyncProcessing.GetRows(FileName, CancellationToken.None);
        await AsyncProcessing.WriteRows(Guid.NewGuid().ToString(), results, CancellationToken.None);
    }

    [Benchmark]
    public async Task AsyncStreamProcessingReWrite() => 
        await AsyncStreamProcessing.ReWrite(FileName, Guid.NewGuid().ToString(), CancellationToken.None);
}