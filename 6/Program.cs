using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //x=-0.6, D=0.05, k=20
            //3*x-(1+1/x)ln(1-x*x)+2ln((1-x)/(1+x))
            double x =-0.6;
            double d = 0.05;
            int k = 20;
            double f;
            Console.WriteLine("3*x-(1+1/x)ln(1-x*x)+2ln((1-x)/(1+x))");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < k; i++)
            {
                f = 3 * x - (1 + 1 / x) * Math.Log(1 - x * x) + 2 * Math.Log((1 - x) / (1 + x));
                x += d;
                Console.WriteLine("f1(x) = " + f);
            }
        }
    }
}
