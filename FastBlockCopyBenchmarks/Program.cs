using BenchmarkDotNet;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastBlockCopyBenchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<FastBlockCopyBench>();
            Console.WriteLine("finish!");

            //FastBlockCopyTests.Run();
            //FastBlockCopyTests.TestCopy();
            Console.ReadLine();
        }
    }
}
