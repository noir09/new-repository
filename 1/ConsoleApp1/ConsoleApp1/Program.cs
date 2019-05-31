using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1;
            bool alive = true;
            sbyte bit1 = -1;
            short n1 = 1;
            ushort n = 1;
            uint x = 10;
            long b = -10;
            ulong a1 = 10;
            float m = 3;
            double d = 3.14159265;
            decimal v = 1/15;
            char j = 'f';
            string hw = "hello world";
            object pi = 3.14;
            pi = d;
            Console.WriteLine(pi);
            d = (double)pi;
            b = a + n;
            Console.WriteLine(b);
        }
    }
}
