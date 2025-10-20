```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26100.6899/24H2/2024Update/HudsonValley)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]    : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=.NET 10.0  Runtime=.NET 10.0  Toolchain=net10.0  

```
| Method                     | Mean      | Error     | StdDev    | Median    | Gen0   | Allocated |
|--------------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
| GetClassResultAsInterface  | 4.4132 ns | 0.2248 ns | 0.6451 ns | 4.3532 ns | 0.0048 |      40 B |
| GetStructResultAsInterface | 4.2095 ns | 0.1181 ns | 0.2806 ns | 4.1149 ns | 0.0048 |      40 B |
| GetClassResultDirectly     | 4.8114 ns | 0.4767 ns | 1.3980 ns | 4.2825 ns | 0.0048 |      40 B |
| GetStructResultDirectly    | 0.2733 ns | 0.0402 ns | 0.1148 ns | 0.2264 ns |      - |         - |
