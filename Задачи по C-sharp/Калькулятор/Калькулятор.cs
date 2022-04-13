using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    internal class Калькулятор
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                try
                {
                    Console.Write("Введите первое число:  ");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.Write("Введите второе число:  ");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный формат ввода!");
                    Console.ReadLine();
                    continue;
                }

                Console.Write("Выберите операцию:  '+' '-' '*' '/'   ");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.Write($"Результат:  {firstValue + secondValue}");
                        break;
                    case "-":
                        Console.Write($"Результат:  {firstValue - secondValue}");
                        break;
                    case "*":
                        Console.Write($"Результат:  {firstValue * secondValue}");
                        break;
                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine("На ноль делить нельзя!");
                        else
                            Console.Write($"Результат:  {firstValue / secondValue}");
                        break;
                    default:
                        Console.WriteLine("Ошибка! Операция не распознана!");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}