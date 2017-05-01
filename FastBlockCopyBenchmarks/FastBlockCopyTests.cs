using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastBlockCopy;

namespace FastBlockCopyBenchmarks
{
    public static class FastBlockCopyTests
    {
        private readonly static byte[] bufferFrom = new byte[8512];
        private readonly static byte[] bufferTo = new byte[8512];

        public static void Run()
        {
            byte[] from = new byte[1024];
            byte[] to = new byte[1024];
            Stopwatch w = Stopwatch.StartNew();
            for (int i = 0; i < 10000000; i++)
            {
                from.UnsafeBlockCopy(0, to, 0, 32);
                //Buffer.BlockCopy(from, 0, to, 0, 32);
            }
            w.Stop();
            Console.WriteLine($"cost:{w.ElapsedMilliseconds}");
            Console.WriteLine(to);
            
        }

        public static void RunRandom()
        {
            Stopwatch w = Stopwatch.StartNew();
            for (int i = 0; i < 10000000; i++)
            {
                bufferFrom.BlockCopy(0, bufferTo, 0, 256);
                //Buffer.BlockCopy(bufferFrom, 0, bufferTo, 0, 256);
            }

            w.Stop();
            Console.WriteLine($"cost:{w.ElapsedMilliseconds}");
            Console.WriteLine(bufferTo);

        }

        public static void TestCopy()
        {
            for (int i = 0; i < 1024; i++)
            {
                byte[] src = new byte[i];
                for (int n = 0; n < i; n++)
                    src[n] = (byte)n;
                byte[] dst = new byte[i];
                FastBuffer.BlockCopy(src, 0, dst, 0, src.Length);
                for (int n = 0; n < i; n++)
                {
                    if (src[n] != dst[n])
                    {
                        Console.WriteLine("error:" + i);
                    }
                }
            }
            Console.WriteLine("finish");
        }


    }
}
