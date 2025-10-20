```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26100.6899/24H2/2024Update/HudsonValley)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]    : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=.NET 10.0  Runtime=.NET 10.0  Toolchain=net10.0  

```
| Method                         | Mean     | Error     | StdDev    | Gen0     | Gen1     | Gen2     | Allocated |
|------------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|----------:|
| GetDictionaryKeyAsRecordStruct | 1.041 ms | 0.0278 ms | 0.0812 ms | 332.0313 | 332.0313 | 332.0313 |   1.28 MB |
| GetDictionaryKeyAsStruct       | 1.230 ms | 0.0246 ms | 0.0508 ms | 332.0313 | 332.0313 | 332.0313 |   1.66 MB |
