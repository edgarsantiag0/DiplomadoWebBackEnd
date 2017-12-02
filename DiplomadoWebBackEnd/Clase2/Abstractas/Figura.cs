using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase2.Abstractas
{
    public abstract class Figura
    {
        protected double x;
        protected double y;

        public Figura(double x, double y)
        {
            this.x = x;
            this.y = y;            
        }

        public abstract double Area();

        //public virtual int ImprimeAlgo()
        //{
        //    Console.WriteLine("Este es un metodo virtual, puedo implementarlo");

        //    return 10;
        //}


    }

    public class Circulo : Figura
    {
        private double Radio;

        public Circulo(double x, double y, double radio) : base(x, y)
        {            
            this.Radio = radio;
        }


        public override double Area()
        {
            return Math.PI * this.Radio * this.Radio; // pi * r^2
        }

    }

    public class Cuadrado : Figura
    {
        private double Lado;

        public Cuadrado(double x, double y, double lado) : base(x, y)
        {
            this.Lado = lado;
        }


        public override double Area()
        {
            return this.Lado * this.Lado; 
        }

    }
}
