using BenchmarkDotNet.Attributes;
using System.Collections.ObjectModel;

namespace Performance.B06Capacity;

public class CapacityBenchmark
{
    [Benchmark]
    public ReadOnlyCollection<string> ProcessWithCapacity() =>
        Processor.ProcessWithCapacity(Processor.Items);
    
    [Benchmark]
    public ReadOnlyCollection<string> ProcessWithoutCapacity() =>
        Processor.ProcessWithoutCapacity(Processor.Items);
}