```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                | Mean      | Error     | StdDev    | Median    | Gen0   | Allocated |
|---------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
| ExecuteWithClosure    | 3.4160 ns | 0.2267 ns | 0.6650 ns | 3.2546 ns | 0.0038 |      32 B |
| ExecuteWithoutClosure | 0.0781 ns | 0.0332 ns | 0.0938 ns | 0.0573 ns |      - |         - |
