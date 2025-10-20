using BenchmarkDotNet.Attributes;

namespace Performance.B12Serialization;

public class SerializationBenchmark
{
    [Benchmark]
    public byte[] SerializeDirectlyToUtf8() =>
        Service.SerializeDirectlyToUtf8();
    
    [Benchmark]
    public byte[] SerializeToStringToUtf8() =>
        Service.SerializeToStringToUtf8();
    
    [Benchmark]
    public IReadOnlyCollection<Dto> DeserializeDirectlyFromUtf8() =>
        Service.DeserializeDirectlyFromUtf8();
    
    [Benchmark]
    public IReadOnlyCollection<Dto> DeserializeFromUtf8FromString() =>
        Service.DeserializeFromUtf8FromString();
}