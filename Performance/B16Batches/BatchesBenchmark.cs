using BenchmarkDotNet.Attributes;
using System.Collections.ObjectModel;

namespace Performance.B16Batches;

public class BatchesBenchmark
{
    [Benchmark]
    public ReadOnlyCollection<int> WithChunks() => 
        Service.GetWithChunks(10000, 128);
    
    [Benchmark]
    public ReadOnlyCollection<int> WithSkipTake() => 
        Service.GetWithSkipTake(10000, 128);
}