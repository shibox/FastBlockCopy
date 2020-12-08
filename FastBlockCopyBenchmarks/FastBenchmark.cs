using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FastBlockCopy;

namespace FastBlockCopyBenchmarks
{
    /// <summary>
    /// 快速测试
    /// </summary>
    public static class FastBenchmark
    {
        private readonly static byte[] bufferFrom = new byte[8512];
        private readonly static byte[] bufferTo = new byte[8512];

        public unsafe static void Run()
        {
            BenchSafe();
            //BenchUnsafe();
        }

        public unsafe static void BenchSafe()
        {
            var count = 10000000;
            var from = new byte[1024];
            var to = new byte[1024];
            var w = Stopwatch.StartNew();
            fixed (byte* src = &from[0], dst = &to[0])
            {
                for (int n = 0; n < 100; n++)
                {
                    for (int i = 0; i < count; i++)
                    {
                        FastBuffer.UnsafeBlockCopy(from, 0, to, 0, n);
                    }
                    w.Stop();
                    Console.WriteLine($"FastBuffer.UnsafeBlockCopy {n}bytes cost:{w.ElapsedMilliseconds}");

                    w = Stopwatch.StartNew();
                    for (int i = 0; i < count; i++)
                    {
                        Buffer.BlockCopy(from, 0, to, 0, n);
                    }
                    w.Stop();
                    Console.WriteLine($"Buffer.BlockCopy {n}bytes cost:{w.ElapsedMilliseconds}");
                    Console.WriteLine($"----------------------------{n}-------------------");
                }
            }
        }

        public unsafe static void BenchUnsafe()
        {
            var count = 10000000;
            var from = new byte[1024];
            var to = new byte[1024];
            var w = Stopwatch.StartNew();
            fixed (byte* src = &from[0], dst = &to[0])
            {
                byte* dt = dst;
                for (int n = 0; n < 100; n++)
                {
                    for (int i = 0; i < count; i++)
                    {
                        FastBuffer.UnsafeBlockCopy(src, dst, n);
                    }
                    w.Stop();
                    Console.WriteLine($"FastBuffer.UnsafeBlockCopy {n}bytes cost:{w.ElapsedMilliseconds}");

                    w = Stopwatch.StartNew();
                    for (int i = 0; i < count; i++)
                    {
                        Buffer.MemoryCopy(src, dt, n, n);
                    }
                    w.Stop();
                    Console.WriteLine($"Buffer.MemoryCopy {n}bytes cost:{w.ElapsedMilliseconds}");

                    Console.WriteLine($"----------------------------{n}-------------------");
                }
            }
        }


    }
}
