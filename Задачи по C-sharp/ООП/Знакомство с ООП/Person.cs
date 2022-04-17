using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Знакомство_с_ООП
{
    public class Person
    {
        public string SecondName { get; set; }

        public string Name { get; set; }

        public Person(string secondName, string name)
        {
            SecondName = secondName;
            Name = name;
        }
    }
}
