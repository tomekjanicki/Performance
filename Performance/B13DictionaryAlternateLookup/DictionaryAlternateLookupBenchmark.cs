using BenchmarkDotNet.Attributes;
using System.Collections.ObjectModel;

namespace Performance.B13DictionaryAlternateLookup;

public class DictionaryAlternateLookupBenchmark
{
    [Benchmark]
    public ReadOnlyDictionary<string, int> CountWords1() =>
        Service.CountWords1();
    
    [Benchmark]
    public ReadOnlyDictionary<string, int> CountWords2() =>
        Service.CountWords2();
}