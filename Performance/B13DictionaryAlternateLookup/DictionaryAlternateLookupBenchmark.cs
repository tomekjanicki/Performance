using BenchmarkDotNet.Attributes;

namespace Performance.B13DictionaryAlternateLookup;

public class DictionaryAlternateLookupBenchmark
{
    [Benchmark]
    public IReadOnlyDictionary<string, int> CountWords1() =>
        Service.CountWords1();
    
    [Benchmark]
    public IReadOnlyDictionary<string, int> CountWords2() =>
        Service.CountWords2();
}