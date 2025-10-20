namespace Performance.B11ThrowingExceptions;

public sealed class CreateUserCommandWithException
{
    private CreateUserCommandWithException(string login, string password, string name)
    {
        Login = login;
        Password = password;
        Name = name;
    }

    public string Login { get; }
    public string Password { get; }
    public string Name { get; }

    public static CreateUserCommandWithException Create(CreateUserDto dto)
    {
        var errors = new List<string>();
        if (string.IsNullOrWhiteSpace(dto.Login))
        {
            errors.Add($"{nameof(dto.Login)} is null or whitespace");
        }
        if (string.IsNullOrWhiteSpace(dto.Password))
        {
            errors.Add($"{nameof(dto.Password)} is null or whitespace");
        }
        if (string.IsNullOrWhiteSpace(dto.Name))
        {
            errors.Add($"{nameof(dto.Name)} is null or whitespace");
        }

        return errors.Count > 0 ? throw new ValidationException(string.Join(", ", errors)) : new CreateUserCommandWithException(dto.Login!, dto.Password!, dto.Name!);
    }
}