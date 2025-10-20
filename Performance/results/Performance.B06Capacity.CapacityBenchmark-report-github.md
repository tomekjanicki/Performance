```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26100.6899/24H2/2024Update/HudsonValley)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]    : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=.NET 10.0  Runtime=.NET 10.0  Toolchain=net10.0  

```
| Method                 | Mean     | Error   | StdDev   | Median   | Gen0    | Gen1    | Gen2    | Allocated |
|----------------------- |---------:|--------:|---------:|---------:|--------:|--------:|--------:|----------:|
| ProcessWithCapacity    | 140.2 μs | 3.97 μs | 11.51 μs | 136.4 μs | 47.1191 | 28.0762 |       - | 386.03 KB |
| ProcessWithoutCapacity | 325.5 μs | 6.16 μs |  7.33 μs | 323.7 μs | 83.0078 | 82.5195 | 41.5039 | 564.17 KB |
