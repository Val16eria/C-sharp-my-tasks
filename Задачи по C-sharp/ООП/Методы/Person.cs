using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Методы
{
    internal class Person
    {
        public string SecondName { get; set; }

        public string Name { get; set; }

        public int X { get; set; }
        public int Y { get; set; }


        public Person(string secondName, string name)
        {
            SecondName = secondName;
            Name = name;

            X = 0;
            Y = 0;
        }

        public string Run()
        {
            var rnd = new Random();

            X += rnd.Next(-2, 2);
            Y += rnd.Next(-2, 2);

            return $"{Name} ({X}, {Y})";
        }

        public string Run(int x, int y)
        {
            X += x;
            Y += y;

            return $"{Name} ({X}, {Y})";
        }

        public string Run(int x)
        {

            return $"{Name} ({X}, {Y})";
        }

        public string Run(double y)
        {

            return $"{Name} ({X}, {Y})";
        }
    }
}
