```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26100.6899/24H2/2024Update/HudsonValley)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]    : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=.NET 10.0  Runtime=.NET 10.0  Toolchain=net10.0  

```
| Method                                                  | Mean       | Error     | StdDev      | Gen0   | Gen1   | Allocated |
|-------------------------------------------------------- |-----------:|----------:|------------:|-------:|-------:|----------:|
| ExecuteHashCalculatorWithClassicSmallData               |   301.5 ns |   9.14 ns |    26.66 ns | 0.0315 |      - |     264 B |
| ExecuteHashCalculatorWithStackAllocOrArrayPoolSmallData |   296.4 ns |   8.78 ns |    24.49 ns | 0.0134 |      - |     112 B |
| ExecuteHashCalculatorWithClassicLargeData               | 6,940.6 ns | 397.57 ns | 1,172.26 ns | 1.2207 | 0.0381 |   10232 B |
| ExecuteHashCalculatorWithStackAllocOrArrayPoolLargeData | 7,964.0 ns | 129.51 ns |   108.14 ns |      - |      - |     112 B |
