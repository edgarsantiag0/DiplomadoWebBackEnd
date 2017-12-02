using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase2.Arreglos
{
    class Matriz
    {

        private int[,] Mat;

        public void LlenarValores()
        {
            Mat = new int[3, 5];

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Mat[f, c] = c * 3;
                }
            }
        }
    }
}
