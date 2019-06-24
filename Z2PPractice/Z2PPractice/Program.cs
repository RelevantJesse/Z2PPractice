using System;

namespace Z2PPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Add(1, "hello"));
        }
    }

    static class Math
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, string b)
        {
            return a;
        }

        public static int Add(string b, int a)
        {
            return a;
        }
    }
}
