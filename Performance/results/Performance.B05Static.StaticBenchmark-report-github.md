```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                  | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------------ |------------:|----------:|----------:|-------:|----------:|
| GetValidValuesNotStatic | 15,245.4 ns | 183.05 ns | 162.27 ns | 7.9346 |   66600 B |
| GetValidValuesStatic    |    619.2 ns |  16.63 ns |  46.90 ns | 0.0238 |     200 B |
