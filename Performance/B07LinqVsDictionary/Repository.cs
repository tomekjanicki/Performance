using System.Collections.Frozen;
using System.Collections.ObjectModel;

namespace Performance.B07LinqVsDictionary;

public static class Repository
{
    public static readonly ReadOnlyCollection<User> Users = [.. Enumerable.Range(0, 10000).Select(i => new User
    {
        Id = Guid.NewGuid(),
        FirstName = $"firstName{i}",
        LastName = $"lastName{i}"
    })];
    
    public static readonly ReadOnlySet<Guid> UserIds = [.. Users.Select(user => user.Id).Take(100)];

    public static ReadOnlyDictionary<Guid, User> GetUsers() => 
        Users.ToDictionary(user => user.Id).AsReadOnly();

    public static FrozenDictionary<Guid, User> GetUsersAsFrozenDictionary() => 
        GetUsers().ToFrozenDictionary();


    public static readonly ReadOnlyDictionary<Guid, User> UsersDictionary = GetUsers();
    
    public static readonly FrozenDictionary<Guid, User> UsersFrozenDictionary = GetUsersAsFrozenDictionary();
}