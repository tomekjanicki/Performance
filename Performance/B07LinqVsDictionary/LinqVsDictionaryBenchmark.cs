using BenchmarkDotNet.Attributes;

namespace Performance.B07LinqVsDictionary;

public class LinqVsDictionaryBenchmark
{
    [Benchmark]
    public IReadOnlyCollection<User> GetUsersByIdsLinq() =>
        Service.GetUsersByIdsLinq(Repository.UserIds);
    
    [Benchmark]
    public IReadOnlyCollection<User> GetUsersByIdsAlreadyBuiltDictionary() =>
        Service.GetUsersByIdsAlreadyBuiltDictionary(Repository.UserIds);
    
    [Benchmark]
    public IReadOnlyCollection<User> GetUsersByIdsBuildDictionary() =>
        Service.GetUsersByIdsBuildDictionary(Repository.UserIds);
    
    [Benchmark]
    public IReadOnlyCollection<User> GetUsersByIdsAlreadyBuiltFrozenDictionary() =>
        Service.GetUsersByIdsAlreadyBuiltFrozenDictionary(Repository.UserIds);
    
    [Benchmark]
    public IReadOnlyCollection<User> GetUsersByIdsBuildFrozenDictionary() =>
        Service.GetUsersByIdsBuildFrozenDictionary(Repository.UserIds);
}