```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method      | Mean     | Error    | StdDev   | Gen0      | Gen1      | Gen2     | Allocated |
|------------ |---------:|---------:|---------:|----------:|----------:|---------:|----------:|
| CountWords1 | 59.38 ms | 0.826 ms | 0.732 ms | 2750.0000 | 1000.0000 | 375.0000 |  20.67 MB |
| CountWords2 | 54.61 ms | 1.090 ms | 1.631 ms |  100.0000 |         - |        - |   2.54 MB |
