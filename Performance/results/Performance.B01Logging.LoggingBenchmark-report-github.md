```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                                                   | Mean         | Error         | StdDev        | Median      | Gen0    | Allocated |
|--------------------------------------------------------- |-------------:|--------------:|--------------:|------------:|--------:|----------:|
| LogInformationLevelEnabledClassic                        |  8,150.72 μs |    384.115 μs |    991.522 μs | 7,867.12 μs |       - | 928.91 KB |
| LogInformationLevelEnabledStringInterpolation            | 79,085.71 μs | 29,869.311 μs | 88,070.343 μs | 9,074.12 μs |       - | 662.42 KB |
| LogInformationLevelEnabledSourceGenerated                | 10,020.29 μs |    380.232 μs |  1,001.684 μs | 9,751.40 μs |       - | 936.72 KB |
| LogInformationLevelEnabledSourceGeneratedSkipEnableCheck |  9,533.57 μs |    435.534 μs |  1,108.572 μs | 9,192.73 μs |       - | 936.72 KB |
| LogDebugLevelNotEnabledClassic                           |    109.95 μs |      4.444 μs |     12.893 μs |   111.60 μs | 26.6113 | 217.97 KB |
| LogDebugLevelNotEnabledStringInterpolation               |    168.36 μs |      6.215 μs |     18.227 μs |   171.17 μs | 41.7480 | 342.11 KB |
| LogDebugLevelNotEnabledSourceGenerated                   |     26.99 μs |      0.508 μs |      1.003 μs |    26.74 μs |  7.5378 |  61.72 KB |
| LogDebugLevelNotEnabledSourceGeneratedSkipEnableCheck    |     45.10 μs |      0.882 μs |      1.083 μs |    44.82 μs |  7.5073 |  61.72 KB |
