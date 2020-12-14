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
            //var summary = BenchmarkRunner.Run<SafeCopyBenchmark>();
            var summary = BenchmarkRunner.Run<UnsafeCopyBenchmark>();
            //FastBenchmark.Run();
            Console.WriteLine("finish!");
            Console.ReadLine();
        }
    }
}
