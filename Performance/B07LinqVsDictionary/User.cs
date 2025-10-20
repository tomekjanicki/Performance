namespace Performance.B07LinqVsDictionary;

public sealed class User
{
    public Guid Id { get; init; }

    public string FirstName { get; init; } = string.Empty;
    
    public string LastName { get; init; } = string.Empty;
}