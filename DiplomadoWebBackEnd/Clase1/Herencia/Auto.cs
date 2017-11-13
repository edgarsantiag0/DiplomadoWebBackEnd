using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase1.Herencia
{
    class Auto : Vehiculo
    {
        public int CantidadPuertas { get; set; }
        public string NumeroPlaca { get; set; }


        public Auto()
        {
            // Utilizando base se puede acceder a la clase Padre por ej:
            base.Encender();
            Console.WriteLine("Constructor Auto");
        }

    }
}
