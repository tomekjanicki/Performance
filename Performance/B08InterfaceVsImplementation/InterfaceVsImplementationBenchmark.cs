using BenchmarkDotNet.Attributes;

namespace Performance.B08InterfaceVsImplementation;

public class InterfaceVsImplementationBenchmark
{
    [Benchmark]
    public IResult GetClassResultAsInterface() =>
        Service.GetClassResultAsInterface(5);
    
    [Benchmark]
    public IResult GetStructResultAsInterface() =>
        Service.GetStructResultAsInterface(5);

    [Benchmark]
    public ClassResult GetClassResultDirectly() =>
        Service.GetClassResultDirectly(5);
    
    [Benchmark]
    public StructResult GetStructResultDirectly() =>
        Service.GetStructResultDirectly(5);
}