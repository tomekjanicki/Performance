```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26100.6899/24H2/2024Update/HudsonValley)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]    : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=.NET 10.0  Runtime=.NET 10.0  Toolchain=net10.0  

```
| Method                                    | Mean       | Error      | StdDev     | Median     | Gen0     | Gen1     | Gen2     | Allocated  |
|------------------------------------------ |-----------:|-----------:|-----------:|-----------:|---------:|---------:|---------:|-----------:|
| GetUsersByIdsLinq                         |  80.268 μs |  2.6472 μs |  7.8054 μs |  77.912 μs |   0.2441 |        - |        - |    2.34 KB |
| GetUsersByIdsAlreadyBuiltDictionary       |   1.221 μs |  0.0375 μs |  0.1107 μs |   1.208 μs |   0.2670 |        - |        - |    2.19 KB |
| GetUsersByIdsBuildDictionary              | 253.541 μs |  5.0459 μs |  8.7039 μs | 250.714 μs |  82.5195 |  77.6367 |  77.6367 |  358.03 KB |
| GetUsersByIdsAlreadyBuiltFrozenDictionary |   1.011 μs |  0.0271 μs |  0.0798 μs |   1.005 μs |   0.2613 |   0.0010 |        - |    2.14 KB |
| GetUsersByIdsBuildFrozenDictionary        | 730.117 μs | 18.6568 μs | 53.8291 μs | 707.012 μs | 272.4609 | 252.9297 | 248.0469 | 1222.24 KB |
