```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                                    | Mean         | Error      | StdDev      | Median       | Gen0     | Gen1     | Gen2     | Allocated  |
|------------------------------------------ |-------------:|-----------:|------------:|-------------:|---------:|---------:|---------:|-----------:|
| GetUsersByIdsLinq                         |   105.789 μs |  2.4866 μs |   7.2928 μs |   105.377 μs |   0.1221 |        - |        - |     1.8 KB |
| GetUsersByIdsAlreadyBuiltDictionary       |     1.446 μs |  0.0375 μs |   0.1071 μs |     1.410 μs |   0.2689 |        - |        - |    2.21 KB |
| GetUsersByIdsBuildDictionary              |   329.859 μs | 17.7942 μs |  52.4667 μs |   340.260 μs |  99.6094 |  99.6094 |  99.6094 |  357.66 KB |
| GetUsersByIdsAlreadyBuiltFrozenDictionary |     1.465 μs |  0.0440 μs |   0.1297 μs |     1.466 μs |   0.2689 |        - |        - |    2.21 KB |
| GetUsersByIdsBuildFrozenDictionary        | 1,514.319 μs | 58.0524 μs | 170.2576 μs | 1,504.905 μs | 546.8750 | 503.9063 | 492.1875 | 2406.49 KB |
