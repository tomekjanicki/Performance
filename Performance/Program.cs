using BenchmarkDotNet.Running;
BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

//dotnet run -c Release --project .\Performance\Performance.csproj -- --memory true