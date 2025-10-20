```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26100.6899/24H2/2024Update/HudsonValley)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]    : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=.NET 10.0  Runtime=.NET 10.0  Toolchain=net10.0  

```
| Method                  | Mean       | Error     | StdDev    | Median     | Gen0   | Allocated |
|------------------------ |-----------:|----------:|----------:|-----------:|-------:|----------:|
| ToStringStandard        | 14.3017 ns | 1.1970 ns | 3.5294 ns | 14.4507 ns | 0.0029 |      24 B |
| ToStringSourceGenerated |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      - |         - |
| TryParseStandard        |  9.4991 ns | 0.2790 ns | 0.8139 ns |  9.2233 ns |      - |         - |
| TryParseSourceGenerated |  1.6106 ns | 0.0670 ns | 0.1835 ns |  1.5198 ns |      - |         - |
