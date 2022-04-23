using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_опреаторов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Красное яблоко", 100, 100);
            Apple apple2 = new Apple("Зелёное яблоко", 90, 110);

            var sumApple = Apple.Add(apple, apple2);
            var sumApple2 = apple + apple2;
 

            Console.WriteLine(apple);
            Console.WriteLine(apple2);
            Console.WriteLine(sumApple);
            Console.WriteLine(sumApple2);

            Console.WriteLine(apple == apple2);
            Console.WriteLine(sumApple == sumApple2);

            Console.ReadLine();

        }
    }
}
