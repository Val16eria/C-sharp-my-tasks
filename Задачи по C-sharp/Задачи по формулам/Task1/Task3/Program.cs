using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* дана длина ребра куба, найти
 * объём куба и площадь его боковой поверхности
 */

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Объём куба равен {Math.Pow(a, 3)}, " +
                $"а площадь его боковой поверхности {6 * Math.Pow(a, 2)}");
        }
    }
}
