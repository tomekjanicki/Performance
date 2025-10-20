using BenchmarkDotNet.Attributes;

namespace Performance.B10StackAllocArrayPool;

public class StackAllocArrayPoolBenchmark
{
    private static readonly Data Data1 = new()
    {
        Value1 = Guid.NewGuid(),
        Value2 = Guid.NewGuid(),
        Value3 = "test1 test2 test3 test4 test5 test6"
    };
    
    private static readonly Data Data2 = new()
    {
        Value1 = Guid.NewGuid(),
        Value2 = Guid.NewGuid(),
        Value3 = new string('a', 10000)
    };
    
    [Benchmark]
    public string ExecuteHashCalculatorWithClassicSmallData() => 
        HashCalculatorWithClassic.GetSha256HashAsBase64EncodedString(Data1);
    
    [Benchmark]
    public string ExecuteHashCalculatorWithStackAllocOrArrayPoolSmallData() => 
        HashCalculatorWithStackAllocOrArrayPool.GetSha256HashAsBase64EncodedString(Data1);
    
    [Benchmark]
    public string ExecuteHashCalculatorWithClassicLargeData() => 
        HashCalculatorWithClassic.GetSha256HashAsBase64EncodedString(Data2);
    
    [Benchmark]
    public string ExecuteHashCalculatorWithStackAllocOrArrayPoolLargeData() => 
        HashCalculatorWithStackAllocOrArrayPool.GetSha256HashAsBase64EncodedString(Data2);
}