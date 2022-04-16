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
            int i = 0;
            Int32 j = new int();

            Person person = new Person();
            person.FirstName = "Валерия";
            person.LastName = "М";

            Person p2 = new Person();
            p2.FirstName = "Иван";
            p2.LastName = "Иванов";

            var d = new Знакомство_с_ОПП.Doctor();
            d.FirstName = "Роман";
            d.Specialization = "333";

            Console.WriteLine(d.FirstName);
            Console.WriteLine(d.Specialization);

            Person p = d; // пример полиморфизма

            Console.WriteLine(p.FirstName);

            Знакомство_с_ОПП.Doctor dd = (Знакомство_с_ОПП.Doctor)p;
            Console.WriteLine(d.FirstName);
            Console.WriteLine(d.Specialization);

            Console.ReadLine();
        }
    }
}
