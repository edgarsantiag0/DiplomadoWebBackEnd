using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase1
{
    class Sobrecarga
    {

        static void Metodo(int x)
        {
            Console.WriteLine("Metodo(int x)");
        }

        static void Metodo(string y)
        {
            Console.WriteLine("Metodo(string y)");
        }

        static void Metodo(double x, int y)
        {
            Console.WriteLine("Metodo(double x, int y)");
        }
    }
}
