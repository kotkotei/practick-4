using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {//Даны натуральные числа от 101 до 321. Напечатать те из них,которые делятся БЕЗ ОСТАТКА на 4, но не делятся на 6.
            Console.WriteLine("Введите  число от 101");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите  число  321");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            while (a <= b)
            {
                if (a % 4 == 0 && a % 6 != 0)
                    Console.WriteLine(a);
                a++;
            }

            Console.ReadKey();


        }
    }
}
