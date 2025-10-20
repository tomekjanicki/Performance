using Microsoft.Extensions.Logging;

namespace Performance;

public sealed class TestService(ILogger<TestService> logger)
{
    public void DoSth() => 
        logger.LogInformation("DoSth");
}