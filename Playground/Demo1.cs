using System;

namespace Playground
{
    public class Demo1
    {
        public void Func1()
        {
            Console.WriteLine("Func1");
        }

        public void Func1(string text)
        {
            Console.WriteLine("Func1 with text: " + text);
        }

        public void Func1(int value)
        {
            Console.WriteLine("Func1 with value: " + value);
        }
    }
}
