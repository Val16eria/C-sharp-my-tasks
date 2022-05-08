using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    internal interface ICar : IObject
    {
        /// <summary>
        /// Выполнить перемещение.
        /// </summary>
        /// <param name="distace"> Расстояние. </param>
        /// <returns> Время движения. </returns>
        int Move(int distnace);

        int Speed { get; set; }
    }
}
