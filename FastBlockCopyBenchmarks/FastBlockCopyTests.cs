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
            Stopwatch w = Stopwatch.StartNew();
            for (int n = 1000-1; n < 1000; n++)
            {
                for (int i = 0; i < 10000000; i++)
                {
                    //bufferFrom.BlockCopyUnCheck(0, bufferTo, 0, n);
                    bufferFrom.BlockCopyUnCheckV2(0, bufferTo, 0, 128);
                    //bufferFrom.BlockCopy(0, bufferTo, 0, n);
                    //Buffer.BlockCopy(bufferFrom, 0, bufferTo, 0, 128);
                }
            }
            
            w.Stop();
            Console.WriteLine($"cost:{w.ElapsedMilliseconds}");
            Console.WriteLine(bufferTo);
            
        }


    }
}
