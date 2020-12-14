# FastBlockCopy
Copy is optimized for small data,such as 32 bytes. in 32 bytes it can 1.5x than Buffer.BlockCopy(),in 100 bytes,it fast than 1.2x,is is more,use Buffer.BlockCopy(),is fast.

use:

1 FastBuffer.UnsafeBlockCopy(from, 0, to, 0, 100); without bounds checking,also it more fast

2 FastBuffer.BlockCopy(from, 0, to, 0, 100); with bounds checking

and it also can use:from.UnsafeBlockCopy(0, to, 0, 100)

# 但是：在NET5下测试，无论是在小字节还是在多字节下，性能基本都差不多了，直接用系统的就可以了

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.17763.1282 (1809/October2018Update/Redstone5)
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  Job-CNKWTZ : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  RyuJitX64  : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

Jit=RyuJit  Platform=X64

|                    Method |        Job | IterationCount | LaunchCount | RunStrategy | UnrollFactor | WarmupCount | Size |        N |      Mean |    Error |    StdDev | Ratio | RatioSD | Rank |
|-------------------------- |----------- |--------------- |------------ |------------ |------------- |------------ |----- |--------- |----------:|---------:|----------:|------:|--------:|-----:|
| UnsafeFastBufferCopyFixed | Job-CNKWTZ |              2 |           1 |   ColdStart |            1 |           1 |   96 | 10000000 |  64.83 ms |       NA | 23.979 ms |  1.00 |    0.00 |    2 |
|                 BlockCopy | Job-CNKWTZ |              2 |           1 |   ColdStart |            1 |           1 |   96 | 10000000 |  44.28 ms |       NA |  1.697 ms |  0.74 |    0.30 |    1 |
|                           |            |                |             |             |              |             |      |          |           |          |           |       |         |      |
| UnsafeFastBufferCopyFixed |  RyuJitX64 |        Default |     Default |     Default |           16 |     Default |   96 | 10000000 |  45.52 ms | 0.597 ms |  0.498 ms |  1.00 |    0.00 |    2 |
|                 BlockCopy |  RyuJitX64 |        Default |     Default |     Default |           16 |     Default |   96 | 10000000 |  41.67 ms | 0.744 ms |  0.696 ms |  0.91 |    0.02 |    1 |
|                           |            |                |             |             |              |             |      |          |           |          |           |       |         |      |
| UnsafeFastBufferCopyFixed | Job-CNKWTZ |              2 |           1 |   ColdStart |            1 |           1 |  508 | 10000000 | 192.71 ms |       NA |  1.022 ms |  1.00 |    0.00 |    2 |
|                 BlockCopy | Job-CNKWTZ |              2 |           1 |   ColdStart |            1 |           1 |  508 | 10000000 | 135.61 ms |       NA |  4.982 ms |  0.70 |    0.02 |    1 |
|                           |            |                |             |             |              |             |      |          |           |          |           |       |         |      |
| UnsafeFastBufferCopyFixed |  RyuJitX64 |        Default |     Default |     Default |           16 |     Default |  508 | 10000000 | 193.77 ms | 3.392 ms |  2.833 ms |  1.00 |    0.00 |    2 |
|                 BlockCopy |  RyuJitX64 |        Default |     Default |     Default |           16 |     Default |  508 | 10000000 | 142.06 ms | 1.158 ms |  1.083 ms |  0.73 |    0.01 |    1 |


BenchmarkDotNet=v0.12.1, OS=Windows 10.0.17763.1282 (1809/October2018Update/Redstone5)
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]    : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  RyuJitX64 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

Job=RyuJitX64  Jit=RyuJit  Platform=X64

|                    Method | Size |        N |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD | Rank |
|-------------------------- |----- |--------- |---------:|---------:|---------:|---------:|------:|--------:|-----:|
| UnsafeFastBufferCopyFixed |   96 | 10000000 | 48.46 ms | 1.368 ms | 3.881 ms | 47.03 ms |  1.00 |    0.00 |    2 |
|                 BlockCopy |   96 | 10000000 | 41.79 ms | 0.798 ms | 0.819 ms | 41.86 ms |  0.85 |    0.06 |    1 |