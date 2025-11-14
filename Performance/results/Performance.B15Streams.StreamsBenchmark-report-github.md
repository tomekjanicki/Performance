```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                          | Mean     | Error    | StdDev   | Median   | Gen0     | Gen1     | Gen2     | Allocated |
|-------------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|----------:|
| AsyncProcessingGetRowsWriteRows | 41.10 ms | 6.307 ms | 18.60 ms | 30.06 ms | 444.4444 | 444.4444 | 444.4444 | 2157.1 KB |
| AsyncStreamProcessingReWrite    | 65.20 ms | 7.293 ms | 21.50 ms | 68.03 ms |        - |        - |        - |  38.65 KB |
