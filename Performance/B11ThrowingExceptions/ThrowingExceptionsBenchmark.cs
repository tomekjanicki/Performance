using BenchmarkDotNet.Attributes;

namespace Performance.B11ThrowingExceptions;

public class ThrowingExceptionsBenchmark
{
    [Benchmark]
    public Result<CreateUserCommandWithException> CreateUserWithException()
    {
        var dto = new CreateUserDto();

        return Controller.CreateUserWithException(dto);
    }
    
    [Benchmark]
    public Result<CreateUserCommandWithResult> CreateUserWithResult()
    {
        var dto = new CreateUserDto();

        return Controller.CreateUserWithResult(dto);
    }
}