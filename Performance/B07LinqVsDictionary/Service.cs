using System.Collections.Frozen;
using System.Collections.ObjectModel;

namespace Performance.B07LinqVsDictionary;

public static class Service
{
    public static ReadOnlyCollection<User> GetUsersByIdsLinq(ReadOnlySet<Guid> userIds) =>
        [.. Repository.Users.Where(user => userIds.Contains(user.Id))];

    public static ReadOnlyCollection<User> GetUsersByIdsAlreadyBuiltDictionary(ReadOnlySet<Guid> userIds) =>
        GetUsersByIds(userIds, Repository.UsersDictionary);

    public static ReadOnlyCollection<User> GetUsersByIdsAlreadyBuiltFrozenDictionary(ReadOnlySet<Guid> userIds) =>
        GetUsersByIds(userIds, Repository.UsersFrozenDictionary);

    public static ReadOnlyCollection<User> GetUsersByIdsBuildDictionary(ReadOnlySet<Guid> userIds) => 
        GetUsersByIds(userIds, Repository.GetUsers());
    
    public static ReadOnlyCollection<User> GetUsersByIdsBuildFrozenDictionary(ReadOnlySet<Guid> userIds) => 
        GetUsersByIds(userIds, Repository.GetUsersAsFrozenDictionary());
    
    private static ReadOnlyCollection<User> GetUsersByIds(ReadOnlySet<Guid> userIds, ReadOnlyDictionary<Guid, User> dictionary)
    {
        var results = new List<User>();
        foreach (var userId in userIds)
        {
            if (dictionary.TryGetValue(userId, out var user))
            {
                results.Add(user);
            }
        }
        
        return results.AsReadOnly();
    }
    
    private static ReadOnlyCollection<User> GetUsersByIds(ReadOnlySet<Guid> userIds, FrozenDictionary<Guid, User> dictionary)
    {
        var results = new List<User>();
        foreach (var userId in userIds)
        {
            if (dictionary.TryGetValue(userId, out var user))
            {
                results.Add(user);
            }
        }
        
        return results.AsReadOnly();
    }
}