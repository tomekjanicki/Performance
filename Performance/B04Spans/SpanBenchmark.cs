using BenchmarkDotNet.Attributes;
using System.Collections.ObjectModel;

namespace Performance.B04Spans;

public class SpanBenchmark
{
    private static readonly string Data = DataProducer.GetData(100);

    [Benchmark]
    public ReadOnlyCollection<Result> GetResultClassic() => 
        ClassicParser.Parse(Data);
    
    [Benchmark]
    public ReadOnlyCollection<Result> GetResultSpan() => 
        SpanParser.Parse(Data);
}