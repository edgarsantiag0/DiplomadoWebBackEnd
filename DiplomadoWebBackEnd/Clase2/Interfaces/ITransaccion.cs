using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase2.Interfaces
{
    interface ITransaccion
    {
        void VerTransaccion();
        double ObtenerMonto();
    }





    public class Transaccion : ITransaccion
    {
        private string CodigoTransaccion;
        private string Fecha;
        private double Monto;

        public Transaccion()
        {
            CodigoTransaccion = " ";
            Fecha = " ";
            Monto = 0.0;
        }

        public Transaccion(string c, string d, double a)
        {
            CodigoTransaccion = c;
            Fecha = d;
            Monto = a;
        }

        public double ObtenerMonto()
        {
            return Monto;
        }

        public void VerTransaccion()
        {
            Console.WriteLine("Transaccion: {0}", CodigoTransaccion);
            Console.WriteLine("Fecha: {0}", Fecha);
            Console.WriteLine("Monto: {0}", ObtenerMonto());
        }
    }
}
