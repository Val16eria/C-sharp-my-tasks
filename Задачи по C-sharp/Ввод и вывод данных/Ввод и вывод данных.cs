using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ввод_и_вывод_данных
{
    internal class Ввод_и_вывод_данных
    {
        static void Main()
        {
            Console.Write("Введите любое число:  ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ваше число:  ");
            Console.WriteLine(num);

        }
    }
}
