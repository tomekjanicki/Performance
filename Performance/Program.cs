using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Performance;
using Serilog;

var configuration = GetConfiguration();
var serviceProvider = GetServiceProvider(configuration);
var testService = serviceProvider.GetRequiredService<TestService>();
testService.DoSth();

return;

static IConfiguration GetConfiguration()
{
    var builder = new ConfigurationBuilder()
        .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true);

    return builder.Build();
}

static IServiceProvider GetServiceProvider(IConfiguration configuration)
{
    var services = new ServiceCollection();
    services.AddSingleton<TestService>();
    services.AddLogging();
    services.AddSerilog(cfg => cfg.ReadFrom.Configuration(configuration));

    return services.BuildServiceProvider();
}