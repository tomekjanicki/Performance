```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26100.6899/24H2/2024Update/HudsonValley)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]    : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=.NET 10.0  Runtime=.NET 10.0  Toolchain=net10.0  

```
| Method                | Mean      | Error     | StdDev    | Median    | Gen0   | Allocated |
|---------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
| ExecuteWithClosure    | 3.6079 ns | 0.4598 ns | 1.3558 ns | 3.0877 ns | 0.0038 |      32 B |
| ExecuteWithoutClosure | 0.2430 ns | 0.0369 ns | 0.1088 ns | 0.1908 ns |      - |         - |
