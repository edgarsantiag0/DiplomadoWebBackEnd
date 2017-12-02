using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase2.Delegados
{

    delegate int Operar(int x1, int x2);

    class Delegados1
    {
        public int Sumar(int x, int y)
        {
            return x + y;
        }

        public int Restar(int x, int y)
        {
            return x - y;
        }

        static void MainDelegado(string[] args)
        {
            Delegados1 p = new Delegados1();
            Console.WriteLine("Suma y resta de dos valores " +
                              "llamando directamente a los métodos.");

            Console.WriteLine(p.Sumar(10, 5));
            Console.WriteLine(p.Restar(10, 5));

            // Delegados

            

            Console.WriteLine("Suma y resta de dos valores llamando a los " +
                              "métodos a través de delegados");

            Operar delegado = p.Sumar;
            Console.WriteLine(delegado(10, 5));

            delegado = p.Restar; // En tiempo de ejecución
            Console.WriteLine(delegado(10, 5));



            Console.ReadKey();
        }
    }
}
