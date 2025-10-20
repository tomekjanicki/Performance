using BenchmarkDotNet.Attributes;

namespace Performance.B04Spans;

public class SpanBenchmark
{
    private static readonly string Data = DataProducer.GetData(100);

    [Benchmark]
    public IReadOnlyCollection<Result> GetResultClassic() => 
        ClassicParser.Parse(Data);
    
    [Benchmark]
    public IReadOnlyCollection<Result> GetResultSpan() => 
        SpanParser.Parse(Data);
}