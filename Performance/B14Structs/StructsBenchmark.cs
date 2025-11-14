using BenchmarkDotNet.Attributes;
using System.Collections.ObjectModel;

namespace Performance.B14Structs;

public class StructsBenchmark
{
    [Benchmark]
    public ReadOnlyDictionary<KeyAsRecordStruct, int> GetDictionaryKeyAsRecordStruct() =>
        Generator.GetDictionaryKeyAsRecordStruct(10000);
    
    [Benchmark]
    public ReadOnlyDictionary<KeyAsStruct, int> GetDictionaryKeyAsStruct() =>
        Generator.GetDictionaryKeyAsStruct(10000);
}