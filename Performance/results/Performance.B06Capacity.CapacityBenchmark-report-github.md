```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                 | Mean     | Error   | StdDev   | Gen0    | Gen1    | Gen2    | Allocated |
|----------------------- |---------:|--------:|---------:|--------:|--------:|--------:|----------:|
| ProcessWithCapacity    | 118.5 μs | 3.16 μs |  8.86 μs | 47.1191 | 28.1982 |       - | 386.05 KB |
| ProcessWithoutCapacity | 382.2 μs | 7.63 μs | 11.18 μs | 83.0078 | 82.5195 | 41.5039 | 564.19 KB |
