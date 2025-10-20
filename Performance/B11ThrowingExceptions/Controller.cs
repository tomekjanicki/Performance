namespace Performance.B11ThrowingExceptions;

public static class Controller
{
    public static Result<CreateUserCommandWithException> CreateUserWithException(CreateUserDto dto)
    {
        try
        {
            var command = CreateUserCommandWithException.Create(dto);

            return command.CreateSuccess();
        }
        catch (ValidationException e)
        {
            return e.Message.CreateError<CreateUserCommandWithException>();
        }
    }

    public static Result<CreateUserCommandWithResult> CreateUserWithResult(CreateUserDto dto) =>
        CreateUserCommandWithResult.TryCreate(dto);
}