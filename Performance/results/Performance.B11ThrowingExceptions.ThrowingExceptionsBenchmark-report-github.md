```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
AMD Ryzen 5 Pro 7535U with Radeon Graphics 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                  | Mean        | Error      | StdDev     | Median      | Gen0   | Allocated |
|------------------------ |------------:|-----------:|-----------:|------------:|-------:|----------:|
| CreateUserWithException | 2,013.53 ns | 105.823 ns | 308.689 ns | 1,849.78 ns | 0.0763 |     648 B |
| CreateUserWithResult    |    51.55 ns |   3.050 ns |   8.896 ns |    48.04 ns | 0.0344 |     288 B |
