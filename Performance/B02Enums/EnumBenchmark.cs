using BenchmarkDotNet.Attributes;

namespace Performance.B02Enums;

public class EnumBenchmark
{
    [Benchmark]
    public string ToStringStandard() =>
        EnumService.ToStringStandard(TestType1.TestValue1);
    
    [Benchmark]
    public string ToStringSourceGenerated() =>
        EnumService.ToStringSourceGenerated(TestType2.TestValue1);
    
    [Benchmark]
    public TestType1 TryParseStandard()
    {
        var result = EnumService.TryParseStandard("TestValue1", out var type1);
        
        return result ? type1 : throw new InvalidOperationException();
    }

    [Benchmark]
    public TestType2 TryParseSourceGenerated()
    {
        var result = EnumService.TryParseSourceGenerated("TestValue1", out var type2);
        
        return result ? type2 : throw new InvalidOperationException();
    }
}