```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]     : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3


```
| Method                        | Mean      | Error    | StdDev    | Gen0   | Gen1   | Allocated |
|------------------------------ |----------:|---------:|----------:|-------:|-------:|----------:|
| SerializeDirectlyToUtf8       |  47.55 μs | 0.938 μs |  2.486 μs | 1.6479 |      - |  13.94 KB |
| SerializeToStringToUtf8       |  52.71 μs | 1.349 μs |  3.979 μs | 5.0049 | 0.4883 |  41.09 KB |
| DeserializeDirectlyFromUtf8   |  98.32 μs | 2.874 μs |  8.383 μs | 4.8828 | 0.4883 |  40.11 KB |
| DeserializeFromUtf8FromString | 107.04 μs | 4.032 μs | 11.306 μs | 8.1787 | 1.2207 |  67.27 KB |
