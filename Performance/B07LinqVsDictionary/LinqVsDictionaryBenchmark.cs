using BenchmarkDotNet.Attributes;
using System.Collections.ObjectModel;

namespace Performance.B07LinqVsDictionary;

public class LinqVsDictionaryBenchmark
{
    [Benchmark]
    public ReadOnlyCollection<User> GetUsersByIdsLinq() =>
        Service.GetUsersByIdsLinq(Repository.UserIds);
    
    [Benchmark]
    public ReadOnlyCollection<User> GetUsersByIdsAlreadyBuiltDictionary() =>
        Service.GetUsersByIdsAlreadyBuiltDictionary(Repository.UserIds);
    
    [Benchmark]
    public ReadOnlyCollection<User> GetUsersByIdsBuildDictionary() =>
        Service.GetUsersByIdsBuildDictionary(Repository.UserIds);
    
    [Benchmark]
    public ReadOnlyCollection<User> GetUsersByIdsAlreadyBuiltFrozenDictionary() =>
        Service.GetUsersByIdsAlreadyBuiltFrozenDictionary(Repository.UserIds);
    
    [Benchmark]
    public ReadOnlyCollection<User> GetUsersByIdsBuildFrozenDictionary() =>
        Service.GetUsersByIdsBuildFrozenDictionary(Repository.UserIds);
}