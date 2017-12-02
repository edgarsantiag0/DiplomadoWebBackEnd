using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase2.Interfaces
{
    public interface IFigura
    {
        double Area();
    }

    public interface IVehiculo
    {
        double Acelerar();
        double Frenar();


    }

    public interface IVehiculoVolador : IVehiculo
    {
        double Despegar();
        double Aterrizar();


    }

    public class Auto : IVehiculo
    {
        public double Acelerar()
        {
            throw new NotImplementedException();
        }

        public double Frenar()
        {
            throw new NotImplementedException();
        }
    }

    public class Avion : IVehiculoVolador
    {
        public double Acelerar()
        {
            throw new NotImplementedException();
        }

        public double Frenar()
        {
            throw new NotImplementedException();
        }

        public double Despegar()
        {
            throw new NotImplementedException();
        }

        public double Aterrizar()
        {
            throw new NotImplementedException();
        }
    }

    public class Circulo : IFigura
    {
        private double Radio;

        public Circulo(double radio)
        {
            this.Radio = radio;
        }

        public double Area()
        {
            return Math.PI * this.Radio * this.Radio; // pi * r^2
        }
    }

    public class Cuadrado : IFigura
    {
        private double Lado;

        public Cuadrado(double lado)
        {
            this.Lado = lado;
        }

        public double Area()
        {
            return this.Lado * this.Lado; 
        }
    }
}
