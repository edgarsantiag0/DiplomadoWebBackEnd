using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase2.Arreglos
{
    class MatrizIrregular
    {
        private int[][] Mat;



        public void LlenarValores()
        {

            string[] covTab = {"Edgar", "Paco", "Victor"};

            object[] covTabObj = covTab;


            for (int f = 0; f < Mat.Length; f++)
            {

                int elementos = f * 5;
                Mat[f] = new int[elementos];

                for (int c = 0; c < Mat[f].Length; c++)
                {
                    Mat[f][c] = c*5;
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < Mat.Length; f++)
            {
                for (int c = 0; c < Mat[f].Length; c++)
                {
                    Console.Write(Mat[f][c] + " ");
                }
                Console.WriteLine();
            }         
        }
    }
}
