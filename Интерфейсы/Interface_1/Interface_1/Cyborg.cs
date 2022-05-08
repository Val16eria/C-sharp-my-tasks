using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    internal class Cyborg : ICar, IPerson
    {
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Creat()
        {
            throw new NotImplementedException();
        }

        int ICar.Move(int distnace)
        {
            return distnace / 100;
        }

        int IPerson.Move(int distance)
        {
            return distance / 5;
        }
    }
}
