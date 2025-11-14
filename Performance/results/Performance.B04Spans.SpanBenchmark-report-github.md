```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method           | Mean     | Error     | StdDev    | Gen0   | Gen1   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|-------:|----------:|
| GetResultClassic | 7.267 μs | 0.1440 μs | 0.3793 μs | 3.1738 | 0.1221 |  25.93 KB |
| GetResultSpan    | 3.712 μs | 0.0730 μs | 0.1278 μs | 0.3853 |      - |   3.15 KB |
