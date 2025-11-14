```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                     | Mean      | Error     | StdDev    | Median    | Gen0   | Allocated |
|--------------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
| GetClassResultAsInterface  | 5.0894 ns | 0.3588 ns | 1.0523 ns | 5.1137 ns | 0.0048 |      40 B |
| GetStructResultAsInterface | 5.4628 ns | 0.2005 ns | 0.5849 ns | 5.3965 ns | 0.0048 |      40 B |
| GetClassResultDirectly     | 5.7475 ns | 0.2546 ns | 0.7347 ns | 5.8358 ns | 0.0048 |      40 B |
| GetStructResultDirectly    | 0.0064 ns | 0.0082 ns | 0.0230 ns | 0.0000 ns |      - |         - |
