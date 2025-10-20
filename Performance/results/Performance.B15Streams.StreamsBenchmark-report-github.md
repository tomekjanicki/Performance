```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26100.6899/24H2/2024Update/HudsonValley)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]    : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=.NET 10.0  Runtime=.NET 10.0  Toolchain=net10.0  

```
| Method                          | Mean     | Error    | StdDev   | Median   | Gen0     | Gen1     | Gen2     | Allocated  |
|-------------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|-----------:|
| AsyncProcessingGetRowsWriteRows | 49.14 ms | 6.236 ms | 18.39 ms | 51.08 ms | 500.0000 | 500.0000 | 500.0000 | 2155.67 KB |
| AsyncStreamProcessingReWrite    | 52.91 ms | 6.343 ms | 18.70 ms | 44.15 ms |        - |        - |        - |   37.13 KB |
