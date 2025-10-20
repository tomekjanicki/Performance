using System.Globalization;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;

namespace Performance.B01Logging;

public static class LoggerHelper
{
    private static readonly ILoggerFactory LoggerFactory;

    static LoggerHelper()
    {
        var serilogLogger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.File("log-.txt", rollingInterval: RollingInterval.Day, formatProvider: CultureInfo.InvariantCulture)
            .CreateLogger();
        LoggerFactory = new SerilogLoggerFactory(serilogLogger);
    }
    
    public static ILogger<T> CreateLogger<T>() => 
        LoggerFactory.CreateLogger<T>();
}