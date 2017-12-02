using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase3.Estructuras
{
    public struct Point
    {
        public int x;
        public int y;

        public Point(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        public void SumaCoordenadas(Point p, int incremento)
        {
            p.x += incremento;
            p.y += incremento;
        }

        public override string ToString()
        {
            return string.Format("Coordenadas del punto ({0},{1})", this.x, this.y);
        }

    }

    public class Prueba
    {

        public void Play()
        {
            Point punto1 = new Point(5, 10);
            punto1.SumaCoordenadas(punto1, 5);
            Console.WriteLine(punto1);

            string s1 = "Hola";
            object o = s1;


            //if (o.Lenght > 0)
            //{
                
            //}

            string s2;

            if (o is string)
                s2 = (string)o;   // unboxing

        }

    }
}
