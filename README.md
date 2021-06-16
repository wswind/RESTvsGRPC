# RESTvsGRPC
Evaluating Performance of REST vs gRPC vs WCF

## Starts Services

```
dotnet run -p RestAPI -c Release
dotnet run -p GrpcAPI -c Release
dotnet run -p RESTvsGRPC -c Release
use visual studio to run wcf with release configuration
```


# Benchmark

```ini
dotnet run -p RESTvsGRPC -c Release
use visual studio to run WCFBenchmark with release configuration

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1055 (21H1/May2021Update)
Intel Core i5-8250U CPU 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores

// .NET 5
// Benchmark Process Environment Information:
// Runtime=.NET Core 5.0.7 (CoreCLR 5.0.721.25508, CoreFX 5.0.721.25508), X64 RyuJIT
// GC=Concurrent Workstation
// Job: DefaultJob

|                         Method | IterationCount |        Mean |     Error |    StdDev |
|------------------------------- |--------------- |------------:|----------:|----------:|
|       RestGetSmallPayloadAsync |            100 |    15.19 ms |  0.122 ms |  0.108 ms |
|       RestGetLargePayloadAsync |            100 |   932.95 ms | 17.500 ms | 18.725 ms |
|      RestPostLargePayloadAsync |            100 |   868.20 ms |  8.224 ms |  8.077 ms |
|       GrpcGetSmallPayloadAsync |            100 |    19.72 ms |  0.348 ms |  0.326 ms |
|    GrpcStreamLargePayloadAsync |            100 | 1,675.88 ms | 13.472 ms | 11.943 ms |
| GrpcGetLargePayloadAsListAsync |            100 |   177.79 ms |  0.798 ms |  0.707 ms |
|      GrpcPostLargePayloadAsync |            100 |   185.37 ms |  1.831 ms |  1.713 ms |
|       RestGetSmallPayloadAsync |            200 |    30.29 ms |  0.230 ms |  0.204 ms |
|       RestGetLargePayloadAsync |            200 | 1,903.19 ms | 34.636 ms | 30.704 ms |
|      RestPostLargePayloadAsync |            200 | 1,736.50 ms | 20.820 ms | 16.255 ms |
|       GrpcGetSmallPayloadAsync |            200 |    40.60 ms |  0.801 ms |  0.750 ms |
|    GrpcStreamLargePayloadAsync |            200 | 3,405.77 ms | 67.453 ms | 69.270 ms |
| GrpcGetLargePayloadAsListAsync |            200 |   361.46 ms |  7.012 ms |  7.794 ms |
|      GrpcPostLargePayloadAsync |            200 |   369.86 ms |  3.817 ms |  3.188 ms |

// WCF
// Benchmark Process Environment Information:
// Runtime=.NET Framework 4.8 (4.8.4360.0), X86 LegacyJIT
// GC=Concurrent Workstation
// Job: DefaultJob

|                   Method | IterationCount |        Mean |     Error |    StdDev |
|------------------------- |--------------- |------------:|----------:|----------:|
|  WCFGetSmallPayloadAsync |            100 |    95.41 ms |  1.628 ms |  1.523 ms |
|  WCFGetLargePayloadAsync |            100 | 1,978.89 ms |  7.126 ms |  6.666 ms |
| WCFPostLargePayloadAsync |            100 | 1,312.65 ms |  6.235 ms |  5.206 ms |
|  WCFGetSmallPayloadAsync |            200 |   219.78 ms |  6.726 ms | 19.298 ms |
|  WCFGetLargePayloadAsync |            200 | 4,026.41 ms | 43.369 ms | 40.568 ms |
| WCFPostLargePayloadAsync |            200 | 2,626.32 ms | 14.108 ms | 13.197 ms |
```
