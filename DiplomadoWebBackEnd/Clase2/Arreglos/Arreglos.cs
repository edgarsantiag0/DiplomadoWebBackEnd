using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase2.Arreglos
{
    class Arreglos
    {
        private int[] Montos = {1,2,3};

        public void LlenarValores()
        {

            Montos = new int[10]; //[0] [2] [4] [] [] []

            Montos[0] = 1;
            Montos[1] = 2;
            Montos[2] = 3;

            for (int i = 0; i < 10; i++)
            {
                Montos[i] = i * 2 ; // (0,2,4,6,8)
            }
        }

        public void ImprimirArreglo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Montos[i]);
            }            
        }
    }
}
