using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd
{
    class Animal
    {

        public string Color { get; set; }
        public string Tipo { get; set; }
        private int[] vec;


        public void Suma(int primerNumero, int segundoNumero)
        {
            Console.Write(primerNumero + segundoNumero);

            int x1 = 10;
            int x2 = 20;
            Console.WriteLine("Los valores antes de intercambiar son " + x1 + " " + x2);
            Swap(ref x1, ref x2);


        
            int ma, me;
            this.MayorMenor(out ma, out me);
            Console.WriteLine("El mayor elemento del vector es:" + ma);
            Console.WriteLine("El menor elemento del vector es:" + me);

            this.Imprimir("Hola Mundo");
            this.Imprimir("Hola Mundo", 40);
            this.Imprimir("Hola Mundo", 40, 12);


        }

        public void Swap(ref int valor1, ref int valor2)
        {
            int aux = valor1;
            valor1 = valor2;
            valor2 = aux;
        }

        public void MayorMenor(out int may, out int men)
        {
            may = vec[0];
            men = vec[0];
            for (var f = 1; f < vec.Length; f++)
            {
                if (vec[f] > may)
                {
                    may = vec[f];
                }
                else
                {
                    if (vec[f] < men)
                    {
                        men = vec[f];
                    }
                }
            }
        }

        public int Sumar(params int[] p)
        {
            int su = 0;
            for (var f = 0; f < p.Length; f++)
            {
                su = su + p[f];
            }
            return su;
        }

        public void Imprimir(string mensaje, int col = 1, int fil = 1)
        {
            Console.SetCursorPosition(col, fil);
            Console.Write(mensaje);
        }

    }
}
