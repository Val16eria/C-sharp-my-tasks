using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Необходимо написать консольную программу, 
 * где пользователь будет вводить с клавиатуры 2 числа. 
 * Числа будут сравниваться с последующим выводом в консоль результата этого сравнения 
 * (равны ли значения, а если нет, то какое число больше/меньше).
 */
namespace Сравнение_двух_чисел
{
    internal class Сравнение
    {
        static void Main()
        {
            Console.Write("Введите первое число:  ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число:  ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            if (num1 < num2)
            {
                Console.WriteLine("Первое число меньше второго");
            }
            if (num1 == num2)
            {
                Console.WriteLine("Оба числа равны");
            }
        }
    }
}
