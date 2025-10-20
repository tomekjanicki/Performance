```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26100.6899/24H2/2024Update/HudsonValley)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]    : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=.NET 10.0  Runtime=.NET 10.0  Toolchain=net10.0  

```
| Method           | Mean     | Error     | StdDev    | Gen0   | Gen1   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|-------:|----------:|
| GetResultClassic | 6.657 μs | 0.1219 μs | 0.1081 μs | 3.5248 | 0.1602 |   28.8 KB |
| GetResultSpan    | 3.636 μs | 0.0661 μs | 0.1191 μs | 0.6409 | 0.0076 |   5.27 KB |
