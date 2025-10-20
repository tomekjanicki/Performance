```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26100.6899/24H2/2024Update/HudsonValley)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]    : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=.NET 10.0  Runtime=.NET 10.0  Toolchain=net10.0  

```
| Method                                                   | Mean        | Error        | StdDev       | Median      | Gen0    | Allocated |
|--------------------------------------------------------- |------------:|-------------:|-------------:|------------:|--------:|----------:|
| LogInformationLevelEnabledClassic                        | 8,316.43 μs |   456.369 μs | 1,161.604 μs | 7,999.37 μs |       - | 928.91 KB |
| LogInformationLevelEnabledStringInterpolation            | 7,506.36 μs |   443.183 μs | 1,119.981 μs | 7,288.60 μs |       - | 662.42 KB |
| LogInformationLevelEnabledSourceGenerated                | 8,673.48 μs | 1,118.087 μs | 2,825.548 μs | 7,935.80 μs |       - | 936.72 KB |
| LogInformationLevelEnabledSourceGeneratedSkipEnableCheck | 8,027.30 μs |   388.846 μs |   996.760 μs | 7,700.20 μs |       - | 936.72 KB |
| LogDebugLevelNotEnabledClassic                           |   104.43 μs |     3.087 μs |     9.103 μs |   102.82 μs | 26.6113 | 217.97 KB |
| LogDebugLevelNotEnabledStringInterpolation               |   201.76 μs |    13.471 μs |    39.720 μs |   201.59 μs | 41.7480 | 342.11 KB |
| LogDebugLevelNotEnabledSourceGenerated                   |    32.57 μs |     1.338 μs |     3.840 μs |    31.11 μs |  7.5073 |  61.72 KB |
| LogDebugLevelNotEnabledSourceGeneratedSkipEnableCheck    |    55.87 μs |     3.243 μs |     9.511 μs |    56.09 μs |  7.5073 |  61.72 KB |
