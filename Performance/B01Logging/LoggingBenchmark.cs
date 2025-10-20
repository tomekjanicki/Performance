using BenchmarkDotNet.Attributes;

namespace Performance.B01Logging;

public class LoggingBenchmark
{
    private readonly LoggingService _service = new(LoggerHelper.CreateLogger<LoggingService>(), 1000);

    [Benchmark]
    public void LogInformationLevelEnabledClassic() => 
        _service.LogInformationLevelEnabledClassic();
    
    [Benchmark]
    public void LogInformationLevelEnabledStringInterpolation() => 
        _service.LogInformationLevelEnabledStringInterpolation();
    
    [Benchmark]
    public void LogInformationLevelEnabledSourceGenerated() => 
        _service.LogInformationLevelEnabledSourceGenerated();
    
    [Benchmark]
    public void LogInformationLevelEnabledSourceGeneratedSkipEnableCheck() => 
        _service.LogInformationLevelEnabledSourceGeneratedSkipEnableCheck();
    
    [Benchmark]
    public void LogDebugLevelNotEnabledClassic() => 
        _service.LogDebugLevelNotEnabledClassic();
    
    [Benchmark]
    public void LogDebugLevelNotEnabledStringInterpolation() => 
        _service.LogDebugLevelNotEnabledStringInterpolation();
    
    [Benchmark]
    public void LogDebugLevelNotEnabledSourceGenerated() => 
        _service.LogDebugLevelNotEnabledSourceGenerated();
    
    [Benchmark]
    public void LogDebugLevelNotEnabledSourceGeneratedSkipEnableCheck() => 
        _service.LogDebugLevelNotEnabledSourceGeneratedSkipEnableCheck();
}