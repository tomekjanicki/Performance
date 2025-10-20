using BenchmarkDotNet.Attributes;

namespace Performance.B03Closures;

public class ClosuresBenchmark
{
    [Benchmark]
    public int ExecuteWithClosure() =>
        ClosuresService.ExecuteWithClosure(12, 13, 14);

    [Benchmark]
    public int ExecuteWithoutClosure() =>
        ClosuresService.ExecuteWithoutClosure(12, 13, 14);
}