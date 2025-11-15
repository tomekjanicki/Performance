```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.7171)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                                                   | Mean        | Error      | StdDev       | Median      | Gen0    | Allocated |
|--------------------------------------------------------- |------------:|-----------:|-------------:|------------:|--------:|----------:|
| LogInformationLevelEnabledClassic                        | 7,002.53 μs | 139.842 μs |   332.350 μs | 6,930.30 μs |       - | 928.91 KB |
| LogInformationLevelEnabledStringInterpolation            | 8,361.44 μs | 378.064 μs | 1,022.118 μs | 8,113.50 μs |       - | 662.42 KB |
| LogInformationLevelEnabledSourceGenerated                | 8,623.33 μs | 399.988 μs | 1,039.622 μs | 8,204.73 μs |       - | 936.72 KB |
| LogInformationLevelEnabledSourceGeneratedSkipEnableCheck | 7,043.74 μs | 138.915 μs |   274.206 μs | 6,976.82 μs |       - | 936.72 KB |
| LogDebugLevelNotEnabledClassic                           |    84.47 μs |   1.622 μs |     4.099 μs |    83.11 μs | 26.6113 | 217.97 KB |
| LogDebugLevelNotEnabledStringInterpolation               |   142.28 μs |   2.622 μs |     7.221 μs |   140.19 μs | 41.7480 | 342.11 KB |
| LogDebugLevelNotEnabledSourceGenerated                   |    38.50 μs |   1.529 μs |     4.507 μs |    38.26 μs |  7.5378 |  61.72 KB |
| LogDebugLevelNotEnabledSourceGeneratedSkipEnableCheck    |    72.19 μs |   2.011 μs |     5.897 μs |    72.29 μs |  7.4463 |  61.72 KB |
