using System;

namespace ConsoleApp1
{
    class triangle
    {
        public int a, b;
        public int P()
        {
            return (a + b) * 2;
        }
        public int S()
        {
            return a * b;
        }
    }
    class square: triangle
    {
        public square(int a)
        {

            b = a;

        }
        public new int P()
        {
            return b * 4;
        }
        public new int S()
        {
            return b * b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            triangle ab = new triangle { a = 5, b = 18 };
            Console.WriteLine(ab.P());
            Console.WriteLine(ab.S());
            square aa = new square(5);
            Console.WriteLine(aa.b);
            Console.WriteLine(aa.P());
            Console.WriteLine(aa.S());

        }
    }
}
