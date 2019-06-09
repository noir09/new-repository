using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string str;
            Console.WriteLine("Введите число x");
            str = Console.ReadLine();
            x = Convert.ToInt32(str);
            Console.WriteLine("Введите число y");
            str = Console.ReadLine();
            y = Convert.ToInt32(str);
            if (x == y) Console.WriteLine("x= y");
            if(x > y)
            {
                Console.WriteLine("x больше y на " +(x-y));
            }
            if (y > x) Console.WriteLine("y больше x на " + (y - x));
        }
    }
}
