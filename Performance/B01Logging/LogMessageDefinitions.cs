using Microsoft.Extensions.Logging;

namespace Performance.B01Logging;

public static partial class LogMessageDefinitions
{
    [LoggerMessage(Level = LogLevel.Information, Message = "Can I do something with something something something string1 string2 string3 string4. {Field1}, {Field2}, {Field3} {Field4} {Field5}", EventId = 1, SkipEnabledCheck = false)]
    public static partial void LogInformationSourceGenerated(this ILogger logger, string field1, int field2, DateOnly field3, int field4, int field5);
    
    [LoggerMessage(Level = LogLevel.Debug, Message = "Can I do something with something something something string1 string2 string3 string4. {Field1}, {Field2}, {Field3} {Field4} {Field5}", EventId = 1, SkipEnabledCheck = false)]
    public static partial void LogDebugSourceGenerated(this ILogger logger, string field1, int field2, DateOnly field3, int field4, int field5);
    
    [LoggerMessage(Level = LogLevel.Information, Message = "Can I do something with something something something string1 string2 string3 string4. {Field1}, {Field2}, {Field3} {Field4} {Field5}", EventId = 1, SkipEnabledCheck = true)]
    public static partial void LogInformationSourceGeneratedSkipEnableCheck(this ILogger logger, string field1, int field2, DateOnly field3, int field4, int field5);
    
    [LoggerMessage(Level = LogLevel.Debug, Message = "Can I do something with something something something string1 string2 string3 string4. {Field1}, {Field2}, {Field3} {Field4} {Field5}", EventId = 1, SkipEnabledCheck = true)]
    public static partial void LogDebugSourceGeneratedSkipEnableCheck(this ILogger logger, string field1, int field2, DateOnly field3, int field4, int field5);
}