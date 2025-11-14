```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                                                  | Mean       | Error     | StdDev    | Median     | Gen0   | Gen1   | Allocated |
|-------------------------------------------------------- |-----------:|----------:|----------:|-----------:|-------:|-------:|----------:|
| ExecuteHashCalculatorWithClassicSmallData               |   334.8 ns |  11.13 ns |  32.81 ns |   335.2 ns | 0.0315 |      - |     264 B |
| ExecuteHashCalculatorWithStackAllocOrArrayPoolSmallData |   297.8 ns |   7.12 ns |  20.42 ns |   288.3 ns | 0.0134 |      - |     112 B |
| ExecuteHashCalculatorWithClassicLargeData               | 6,138.1 ns | 122.63 ns | 171.92 ns | 6,081.5 ns | 1.2207 | 0.0381 |   10232 B |
| ExecuteHashCalculatorWithStackAllocOrArrayPoolLargeData | 8,844.8 ns | 201.34 ns | 587.33 ns | 8,613.6 ns |      - |      - |     112 B |
