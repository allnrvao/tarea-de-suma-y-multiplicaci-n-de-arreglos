using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzamientoDadosEj1.models
{
    internal class Dado
    {
        private static Random rand = new Random();
        public int Darnumrand()
        {
            return rand.Next(1, 7); // da un numero aleatorio entre 1 y 6

        }
    }


}
