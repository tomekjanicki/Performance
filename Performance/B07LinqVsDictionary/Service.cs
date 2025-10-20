namespace Performance.B07LinqVsDictionary;

#pragma warning disable CA1859
public static class Service
{
    public static IReadOnlyCollection<User> GetUsersByIdsLinq(IReadOnlySet<Guid> userIds) =>
        [.. Repository.Users.Where(user => userIds.Contains(user.Id))];

    public static IReadOnlyCollection<User> GetUsersByIdsAlreadyBuiltDictionary(IReadOnlySet<Guid> userIds) =>
        GetUsersByIds(userIds, Repository.UsersDictionary);

    public static IReadOnlyCollection<User> GetUsersByIdsAlreadyBuiltFrozenDictionary(IReadOnlySet<Guid> userIds) =>
        GetUsersByIds(userIds, Repository.UsersFrozenDictionary);

    public static IReadOnlyCollection<User> GetUsersByIdsBuildDictionary(IReadOnlySet<Guid> userIds) => 
        GetUsersByIds(userIds, Repository.GetUsers());
    
    public static IReadOnlyCollection<User> GetUsersByIdsBuildFrozenDictionary(IReadOnlySet<Guid> userIds) => 
        GetUsersByIds(userIds, Repository.GetUsersAsFrozenDictionary());
    
    private static IReadOnlyCollection<User> GetUsersByIds(IReadOnlySet<Guid> userIds, IReadOnlyDictionary<Guid, User> dictionary)
    {
        var results = new List<User>();
        foreach (var userId in userIds)
        {
            if (dictionary.TryGetValue(userId, out var user))
            {
                results.Add(user);
            }
        }
        
        return results;
    }
}