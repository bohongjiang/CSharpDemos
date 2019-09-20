using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new Demo1();

            demo.Func1();
            demo.Func1("hello world;");
            demo.Func1(1111);

            Console.ReadKey();
        }
    }
}
