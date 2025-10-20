using System.Collections.Frozen;

namespace Performance.B07LinqVsDictionary;

public static class Repository
{
    public static readonly IReadOnlyCollection<User> Users = [.. Enumerable.Range(0, 10000).Select(i => new User
    {
        Id = Guid.NewGuid(),
        FirstName = $"firstName{i}",
        LastName = $"lastName{i}"
    })];
    
    public static readonly IReadOnlySet<Guid> UserIds = Users.Select(user => user.Id).Take(100).ToHashSet();

    public static IReadOnlyDictionary<Guid, User> GetUsers() => 
        Users.ToDictionary(user => user.Id);

    public static IReadOnlyDictionary<Guid, User> GetUsersAsFrozenDictionary() => 
        GetUsers().ToFrozenDictionary();


    public static readonly IReadOnlyDictionary<Guid, User> UsersDictionary = GetUsers();
    
    public static readonly IReadOnlyDictionary<Guid, User> UsersFrozenDictionary = GetUsersAsFrozenDictionary();
}