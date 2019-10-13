using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using FastBlockCopy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FastBlockCopyBenchmarks
{
    [SimpleJob(RunStrategy.Throughput, launchCount: 1,
        warmupCount: 1, targetCount: 1)]
    [RPlotExporter, RankColumn]
    public class FastBlockCopyBench
    {
        private readonly static byte[] bufferFrom = new byte[8512];
        private readonly static byte[] bufferTo = new byte[8512];

        //[Params(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32,
        //    33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64,
        //    65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96,
        //    508, 509, 510, 511, 512, 513, 512 + 31, 512 + 32, 512 + 35, 512 + 64,
        //    1024,
        //    4096,
        //    8512)]
        [Params(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32,
            33, 96,
            508,
            1024,
            4096,
            8512)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {

        }

        [Benchmark(Baseline = true)]
        public void UnsafeFastBufferCopy()
        {
            FastBuffer.UnsafeBlockCopy(bufferFrom, 0, bufferTo, 0, N);
        }

        [Benchmark]
        public void FastBufferCopy()
        {
            FastBuffer.BlockCopy(bufferFrom, 0, bufferTo, 0, N);
        }

        //[Benchmark]
        //public void ArrayCopy()
        //{
        //    Array.Copy(bufferFrom, 0, bufferTo, 0, N);
        //}

        [Benchmark]
        public void BlockCopy()
        {
            Buffer.BlockCopy(bufferFrom, 0, bufferTo, 0, N);
        }

        //[Benchmark]
        //public void VectorCopy()
        //{
        //    FastBuffer.VectorCopy(bufferFrom, 0, bufferTo, 0, N);
        //}


    }

}

