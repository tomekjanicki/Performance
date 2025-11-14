```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                  | Mean       | Error     | StdDev    | Median     | Gen0   | Allocated |
|------------------------ |-----------:|----------:|----------:|-----------:|-------:|----------:|
| ToStringStandard        | 12.2610 ns | 1.0946 ns | 3.2273 ns | 11.3945 ns | 0.0029 |      24 B |
| ToStringSourceGenerated |  0.4704 ns | 0.1937 ns | 0.5650 ns |  0.2721 ns |      - |         - |
| TryParseStandard        | 10.2950 ns | 0.2323 ns | 0.5196 ns | 10.1030 ns |      - |         - |
| TryParseSourceGenerated |  1.6755 ns | 0.0653 ns | 0.1675 ns |  1.6191 ns |      - |         - |
