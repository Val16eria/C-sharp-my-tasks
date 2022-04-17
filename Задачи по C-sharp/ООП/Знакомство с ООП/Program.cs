using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Знакомство_с_ООП
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            Person p = new Person("Васев", "Вася");

            Console.WriteLine(p.Name);
            Console.WriteLine(p.SecondName); 
            Console.ReadLine(); 
        }
    }
}
