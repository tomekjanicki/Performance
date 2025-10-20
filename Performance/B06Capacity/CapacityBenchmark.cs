using BenchmarkDotNet.Attributes;

namespace Performance.B06Capacity;

public class CapacityBenchmark
{
    [Benchmark]
    public IReadOnlyCollection<string> ProcessWithCapacity() =>
        Processor.ProcessWithCapacity(Processor.Items);
    
    [Benchmark]
    public IReadOnlyCollection<string> ProcessWithoutCapacity() =>
        Processor.ProcessWithoutCapacity(Processor.Items);
}