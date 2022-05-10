using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// вычисления значения функции y=7x^2+3x+6 при любом значении x
// вычисления значения функции y=12x^2+7x+12 при любом значении x
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение X для первой функции  ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение X для второй функции  ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            int result1 = ((int)(7 * Math.Pow(x1, 2) + (3 * x1) + 6));
            Console.WriteLine($"Y первой функции равен {result1}");

            int result2 = ((int)(12 * Math.Pow(x2, 2) + (7 * x2) + 12));
            Console.WriteLine($"Y второй функции равен {result2}");

        }
    }
}
