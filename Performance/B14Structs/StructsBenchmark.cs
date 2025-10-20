using BenchmarkDotNet.Attributes;

namespace Performance.B14Structs;

public class StructsBenchmark
{
    [Benchmark]
    public IReadOnlyDictionary<KeyAsRecordStruct, int> GetDictionaryKeyAsRecordStruct() =>
        Generator.GetDictionaryKeyAsRecordStruct(10000);
    
    [Benchmark]
    public IReadOnlyDictionary<KeyAsStruct, int> GetDictionaryKeyAsStruct() =>
        Generator.GetDictionaryKeyAsStruct(10000);
}