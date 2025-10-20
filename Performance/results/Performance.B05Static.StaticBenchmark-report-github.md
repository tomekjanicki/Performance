```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26100.6899/24H2/2024Update/HudsonValley)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]    : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=.NET 10.0  Runtime=.NET 10.0  Toolchain=net10.0  

```
| Method                  | Mean        | Error     | StdDev    | Median      | Gen0   | Gen1   | Allocated |
|------------------------ |------------:|----------:|----------:|------------:|-------:|-------:|----------:|
| GetValidValuesNotStatic | 13,069.7 ns | 254.02 ns | 655.70 ns | 12,795.9 ns | 7.9651 | 0.0153 |   66688 B |
| GetValidValuesStatic    |    475.5 ns |   9.53 ns |  19.89 ns |    471.3 ns | 0.0343 |      - |     288 B |
