```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                            | Mean       | Error    | StdDev    | Gen0      | Gen1     | Gen2     | Allocated  |
|---------------------------------- |-----------:|---------:|----------:|----------:|---------:|---------:|-----------:|
| InsertItemsAtTheBeginningOneByOne | 2,728.5 μs | 99.92 μs | 294.62 μs |  328.1250 | 328.1250 | 328.1250 | 1172.08 KB |
| InsertItemsAtTheBeginningByRange  |   267.2 μs |  8.25 μs |  23.67 μs |  333.2520 | 333.2520 | 333.2520 | 1172.13 KB |
| InsertItemsAtTheBeginningWithLinq | 2,296.0 μs | 53.77 μs | 153.41 μs | 1019.5313 | 992.1875 | 992.1875 | 5498.88 KB |
| RemoveItemsAtTheBeginningOneByOne | 2,169.3 μs | 62.27 μs | 183.60 μs |  121.0938 | 121.0938 | 121.0938 |  390.74 KB |
| RemoveItemsAtTheBeginningByRange  |   125.9 μs |  4.16 μs |  11.80 μs |  124.8779 | 124.8779 | 124.8779 |  390.74 KB |
| RemoveItemsAtTheBeginningByLinq   |   318.1 μs |  8.22 μs |  23.97 μs |  249.5117 | 249.5117 | 249.5117 |  779.11 KB |
