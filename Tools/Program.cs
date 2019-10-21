using System;

namespace Tools
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Convert.ToString(31, 2));
            CodeGen.Create();
            SwitchTests.Run();
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
