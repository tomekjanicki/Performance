```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.7171)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method       | Mean     | Error    | StdDev   | Median   | Gen0    | Gen1   | Allocated |
|------------- |---------:|---------:|---------:|---------:|--------:|-------:|----------:|
| WithChunks   | 66.55 μs | 1.271 μs | 3.372 μs | 65.43 μs |  5.6152 |      - |   46.3 KB |
| WithSkipTake | 31.89 μs | 1.311 μs | 3.845 μs | 31.74 μs | 11.2915 | 1.5869 |  92.42 KB |
