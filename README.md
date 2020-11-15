# RESTvsGRPC
Evaluating Performance of REST vs. gRPC

## dotnet run -p RestAPI.csproj -c Release
Starts the ASP.NET MVC Core REST API

## dotnet run -p GrpcAPI.csproj -c Release
Starts the GRPC Service

## dotnet run -p RESTvsGRPC.csproj -c Release
Runs the benchmark on the above services

# Benchmark for .NET Core 3.1

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.720 (1909/November2018Update/19H2)
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT

```

|                         Method | IterationCount |        Mean |     Error |    StdDev |
|------------------------------- |--------------- |------------:|----------:|----------:|
|   **RestGetSmallPayloadAsync** |        **100** |**19.29 ms** |**0.351 ms** | **0.587 ms** |
|       RestGetLargePayloadAsync |            100 | 1,148.05 ms | 18.455 ms | 16.359 ms |
|      RestPostLargePayloadAsync |            100 | 1,424.61 ms | 12.557 ms | 11.131 ms |
|       GrpcGetSmallPayloadAsync |            100 |    27.04 ms |  0.197 ms |  0.175 ms |
|    GrpcStreamLargePayloadAsync |            100 | 2,183.97 ms | 30.565 ms | 27.095 ms |
| GrpcGetLargePayloadAsListAsync |            100 |   222.20 ms |  4.219 ms |  5.022 ms |
|      GrpcPostLargePayloadAsync |            100 |   228.69 ms |  4.411 ms |  4.529 ms |
|   **RestGetSmallPayloadAsync** |        **200** |   **39.84 ms** |  **0.334 ms** |  **0.261 ms** |
|       RestGetLargePayloadAsync |            200 | 2,504.54 ms | 47.424 ms | 48.701 ms |
|      RestPostLargePayloadAsync |            200 | 2,935.26 ms | 29.985 ms | 26.580 ms |
|       GrpcGetSmallPayloadAsync |            200 |    60.82 ms |  1.070 ms |  1.001 ms |
|    GrpcStreamLargePayloadAsync |            200 | 4,826.83 ms | 38.930 ms | 34.510 ms |
| GrpcGetLargePayloadAsListAsync |            200 |   447.88 ms |  8.778 ms |  8.211 ms |
|      GrpcPostLargePayloadAsync |            200 |   464.99 ms |  9.254 ms |  9.902 ms |

# Benchmark for .NET 5.0
``` ini
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.630 (2004/?/20H1)
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
```
|                         Method | IterationCount |        Mean |     Error |     StdDev |      Median |
|------------------------------- |--------------- |------------:|----------:|-----------:|------------:|
|       RestGetSmallPayloadAsync |            100 |    14.99 ms |  0.102 ms |   0.095 ms |    15.00 ms |
|       RestGetLargePayloadAsync |            100 |   843.40 ms | 13.117 ms |  12.270 ms |   842.57 ms |
|      RestPostLargePayloadAsync |            100 | 1,003.66 ms | 36.444 ms | 106.310 ms | 1,050.47 ms |
|       GrpcGetSmallPayloadAsync |            100 |    24.46 ms |  0.355 ms |   0.314 ms |    24.50 ms |
|    GrpcStreamLargePayloadAsync |            100 | 1,943.34 ms | 16.640 ms |  13.895 ms | 1,945.64 ms |
| GrpcGetLargePayloadAsListAsync |            100 |   176.73 ms |  2.864 ms |   2.679 ms |   176.85 ms |
|      GrpcPostLargePayloadAsync |            100 |   197.12 ms |  3.750 ms |   9.814 ms |   192.89 ms |
|       RestGetSmallPayloadAsync |            200 |    36.06 ms |  0.326 ms |   0.305 ms |    35.97 ms |
|       RestGetLargePayloadAsync |            200 | 1,939.45 ms | 32.492 ms |  25.368 ms | 1,936.97 ms |
|      RestPostLargePayloadAsync |            200 | 2,133.00 ms | 14.917 ms |  12.456 ms | 2,132.37 ms |
|       GrpcGetSmallPayloadAsync |            200 |    49.47 ms |  0.739 ms |   0.691 ms |    49.47 ms |
|    GrpcStreamLargePayloadAsync |            200 | 4,119.07 ms | 90.186 ms | 254.370 ms | 4,006.39 ms |
| GrpcGetLargePayloadAsListAsync |            200 |   354.14 ms |  5.586 ms |   5.225 ms |   356.57 ms |
|      GrpcPostLargePayloadAsync |            200 |   381.60 ms |  5.193 ms |   4.857 ms |   380.72 ms |
