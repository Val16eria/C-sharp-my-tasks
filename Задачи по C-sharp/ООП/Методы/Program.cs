using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Методы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(3));

            Console.ReadLine();
        }
        
        public static int Factorial(int value)
        {
            if (value <= 1)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }

        }
    }
}
