using Microsoft.Extensions.Logging;

namespace Performance.B01Logging;

#pragma warning disable CA2254
#pragma warning disable CA1848
public sealed class LoggingService(ILogger<LoggingService> logger, int tries)
{
    private static void InLoop(ILogger logger, int tries, Action<ILogger, string, int, DateOnly, int, int> action)
    {
        for (var counter = 0; counter < tries; counter++)
        {
            action(logger, $"parameter_name_{counter}", counter, DateOnly.FromDateTime(new DateTime(2020, 1, 1).AddDays(counter)), counter * 2, counter * 3);
        }     
    }
    
    public void LogInformationLevelEnabledClassic() =>
        InLoop(logger, tries, static (logger, f1, f2, f3, f4, f5) => logger.LogInformation("Can I do something with something something something string1 string2 string3 string4. {Field1}, {Field2}, {Field3} {Field4} {Field5}",
            f1, f2, f3, f4, f5));

    public void LogDebugLevelNotEnabledClassic() =>
        InLoop(logger, tries, static (logger, f1, f2, f3, f4, f5) => logger.LogDebug("Can I do something with something something something string1 string2 string3 string4. {Field1}, {Field2}, {Field3} {Field4} {Field5}",
            f1, f2, f3, f4, f5));

    public void LogInformationLevelEnabledStringInterpolation() => 
        InLoop(logger, tries, static (logger, f1, f2, f3, f4, f5) => logger.LogInformation($"Can I do something with something something something string1 string2 string3 string4. {f1}, {f2}, {f3}, {f4} {f5}"));

    public void LogDebugLevelNotEnabledStringInterpolation() =>
        InLoop(logger, tries, static (logger, f1, f2, f3, f4, f5) => logger.LogDebug($"Can I do something with something something something string1 string2 string3 string4. {f1}, {f2}, {f3} {f4} {f5}"));    
    public void LogInformationLevelEnabledSourceGenerated() => 
        InLoop(logger, tries, static (logger, f1, f2, f3, f4, f5) => logger.LogInformationSourceGenerated(f1, f2, f3, f4, f5));

    public void LogDebugLevelNotEnabledSourceGenerated() =>
        InLoop(logger, tries, static (logger, f1, f2, f3, f4, f5) => logger.LogDebugSourceGenerated(f1, f2, f3, f4, f5));    
    public void LogInformationLevelEnabledSourceGeneratedSkipEnableCheck() =>
        InLoop(logger, tries, static (logger, f1, f2, f3, f4, f5) => logger.LogInformationSourceGeneratedSkipEnableCheck(f1, f2, f3, f4, f5));
    
    public void LogDebugLevelNotEnabledSourceGeneratedSkipEnableCheck() =>
        InLoop(logger, tries, static (logger, f1, f2, f3, f4, f5) => logger.LogDebugSourceGeneratedSkipEnableCheck(f1, f2, f3, f4, f5));
}