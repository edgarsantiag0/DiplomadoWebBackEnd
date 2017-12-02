using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase2.RedefinicionOperadores
{
    class Complejo
    {

        public float ParteReal;
        public float ParteImaginaria;

        public Complejo()
        {
            
        }

        public Complejo(float parteReal, float parteImaginaria)
        {
            this.ParteReal = parteReal;
            this.ParteImaginaria = parteImaginaria;
        }

        public Complejo(int a, int b)
        {
            
        }


        public Complejo Sumar(Complejo c)
        {
            return c;
        }

        public static Complejo operator +(Complejo op1, Complejo op2)
        {
            Complejo resultado = new Complejo();
            resultado.ParteReal = op1.ParteReal + op2.ParteReal;
            resultado.ParteImaginaria = op1.ParteImaginaria + op2.ParteImaginaria;
            return resultado;
        }

        public static implicit operator Complejo(float op)
        {
            return (new Complejo(op, 0));
        }

    }

    class Prueba
    {

        public void Probando()
        {

            Complejo c1 = new Complejo(3, 2);  // c1 = 3 + 2i
            Complejo c2 = new Complejo(5, 2);  // c2 = 5 + 2i
            Complejo c3 = c1 + c2;       // c3 = 8 + 4i

            //Complejo c3 = c1.Sumar(c2);       // c3 = 8 + 4i

            Complejo c4 = 6;
            int a = 6;
        }

       
    }
}
