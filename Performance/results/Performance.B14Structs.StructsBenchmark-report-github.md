```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error     | StdDev    | Median   | Gen0     | Gen1     | Gen2     | Allocated |
|------------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|---------:|----------:|
| GetDictionaryKeyAsRecordStruct | 1.119 ms | 0.0507 ms | 0.1488 ms | 1.041 ms | 332.0313 | 332.0313 | 332.0313 |   1.28 MB |
| GetDictionaryKeyAsStruct       | 1.401 ms | 0.0639 ms | 0.1854 ms | 1.327 ms | 332.0313 | 332.0313 | 332.0313 |   1.66 MB |
