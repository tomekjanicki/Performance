```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                        | Mean     | Error    | StdDev   | Median   | Gen0   | Gen1   | Allocated |
|------------------------------ |---------:|---------:|---------:|---------:|-------:|-------:|----------:|
| SerializeDirectlyToUtf8       | 45.69 μs | 0.708 μs | 0.592 μs | 45.62 μs | 4.5166 | 0.1831 |  37.37 KB |
| SerializeToStringToUtf8       | 51.55 μs | 1.126 μs | 3.249 μs | 50.27 μs | 7.8735 | 1.0986 |  64.52 KB |
| DeserializeDirectlyFromUtf8   | 79.80 μs | 1.132 μs | 1.059 μs | 79.59 μs | 3.9063 |      - |  32.15 KB |
| DeserializeFromUtf8FromString | 81.78 μs | 1.307 μs | 1.158 μs | 81.48 μs | 7.2021 | 0.7324 |   59.3 KB |
