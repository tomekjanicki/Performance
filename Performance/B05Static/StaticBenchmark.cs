using BenchmarkDotNet.Attributes;

namespace Performance.B05Static;

public class StaticBenchmark
{
    [Benchmark]
    public IReadOnlyCollection<int> GetValidValuesNotStatic() => 
        Processor.GetValidValuesNotStatic();
    
    [Benchmark]
    public IReadOnlyCollection<int> GetValidValuesStatic() => 
        Processor.GetValidValuesStatic();
}