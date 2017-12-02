using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase2.Abstractas
{
    public abstract class Transporte
    {
        public void Mover()
        {
            Console.WriteLine("Moviendo {0} ruedas", Ruedas);
        }

        public abstract int Ruedas { get; }
    }

    public class Coche : Transporte
    {
        public override int Ruedas
        {
            get { return 4; }
        }
    }

    public class Bicicleta : Transporte
    {
        public override int Ruedas
        {
            get { return 2; }
        }
    }
}
