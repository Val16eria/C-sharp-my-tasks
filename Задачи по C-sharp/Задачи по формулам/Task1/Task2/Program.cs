using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// дана сторона квадрата, найти его периметр
// дан радиус окружности, найти её диаметр
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону квадрата  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Периметр квадрата равен {a*4}");

            Console.Write("Введите радиус окружности  ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Диаметр окружности равен {d * 2}");
        }
    }
}
