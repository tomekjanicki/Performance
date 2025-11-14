using BenchmarkDotNet.Attributes;
using System.Collections.ObjectModel;

namespace Performance.B12Serialization;

public class SerializationBenchmark
{
    [Benchmark]
    public ReadOnlyMemory<byte> SerializeDirectlyToUtf8() =>
        Service.SerializeDirectlyToUtf8();
    
    [Benchmark]
    public ReadOnlyMemory<byte> SerializeToStringToUtf8() =>
        Service.SerializeToStringToUtf8();
    
    [Benchmark]
    public ReadOnlyCollection<Dto> DeserializeDirectlyFromUtf8() =>
        Service.DeserializeDirectlyFromUtf8();
    
    [Benchmark]
    public ReadOnlyCollection<Dto> DeserializeFromUtf8FromString() =>
        Service.DeserializeFromUtf8FromString();
}