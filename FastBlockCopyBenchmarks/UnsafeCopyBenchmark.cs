using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using FastBlockCopy;

namespace FastBlockCopyBenchmarks
{
    
    //[RyuJitX64Job]
    [SimpleJob(RunStrategy.Throughput, launchCount: 1, warmupCount: 1, targetCount: 1)]
    [RPlotExporter, RankColumn]
    public class UnsafeCopyBenchmark
    {
        private readonly static byte[] bufferFrom = new byte[1024];
        private readonly static byte[] bufferTo = new byte[1024];

        [Params(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32,
            33, 56, 100
            )]
        //[Params(96
        //    )]
        public int Size;

        [Params(100000000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            var rd = new Random(Guid.NewGuid().GetHashCode());
            rd.NextBytes(bufferFrom);
        }

        [Benchmark(Baseline = true)]
        public unsafe void UnsafeFastBufferCopyFixed()
        {
            fixed (byte* src = &bufferFrom[0], dst = &bufferTo[0])
            {
                for (int i = 0; i < N; i++)
                    FastBuffer.UnsafeBlockCopy(src, dst, Size);
            }
        }

        [Benchmark]
        public unsafe void BlockCopy()
        {
            fixed (byte* src = &bufferFrom[0], dst = &bufferTo[0])
            {
                for (int i = 0; i < N; i++)
                    Buffer.MemoryCopy(src, dst, Size, Size);
            }
        }

    }
}
