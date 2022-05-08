using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    internal class BMWSeven : ICar
    {
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Creat()
        {
            throw new NotImplementedException();
        }

        public int Move(int distnace)
        {
            return distnace / 100;
        }
    }
}
