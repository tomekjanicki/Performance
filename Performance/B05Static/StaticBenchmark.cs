using BenchmarkDotNet.Attributes;
using System.Collections.ObjectModel;

namespace Performance.B05Static;

public class StaticBenchmark
{
    [Benchmark]
    public ReadOnlyCollection<int> GetValidValuesNotStatic() => 
        Processor.GetValidValuesNotStatic();
    
    [Benchmark]
    public ReadOnlyCollection<int> GetValidValuesStatic() => 
        Processor.GetValidValuesStatic();
}