```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26100.6899/24H2/2024Update/HudsonValley)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]    : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=.NET 10.0  Runtime=.NET 10.0  Toolchain=net10.0  

```
| Method                            | Mean       | Error    | StdDev   | Median     | Gen0      | Gen1     | Gen2     | Allocated  |
|---------------------------------- |-----------:|---------:|---------:|-----------:|----------:|---------:|---------:|-----------:|
| InsertItemsAtTheBeginningOneByOne | 2,283.1 μs | 31.16 μs | 45.67 μs | 2,276.0 μs |  332.0313 | 332.0313 | 332.0313 | 1172.06 KB |
| InsertItemsAtTheBeginningByRange  |   244.7 μs |  7.80 μs | 22.89 μs |   235.4 μs |  333.2520 | 333.2520 | 333.2520 |  1172.1 KB |
| InsertItemsAtTheBeginningWithLinq | 1,711.5 μs | 20.26 μs | 20.80 μs | 1,707.5 μs | 1031.2500 | 996.0938 | 988.2813 | 5741.88 KB |
| RemoveItemsAtTheBeginningOneByOne | 1,625.5 μs | 16.20 μs | 12.65 μs | 1,626.5 μs |  123.0469 | 123.0469 | 123.0469 |  390.72 KB |
| RemoveItemsAtTheBeginningByRange  |   117.1 μs |  2.33 μs |  6.34 μs |   115.1 μs |  124.8779 | 124.8779 | 124.8779 |  390.72 KB |
| RemoveItemsAtTheBeginningByLinq   |   115.7 μs |  3.83 μs | 10.61 μs |   110.1 μs |  124.8779 | 124.8779 | 124.8779 |  389.62 KB |
