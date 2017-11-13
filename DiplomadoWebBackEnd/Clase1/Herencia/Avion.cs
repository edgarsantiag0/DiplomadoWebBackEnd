using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase1.Herencia
{
    class Avion : Vehiculo
    {
        public float PotenciaTurbina { get; set; }
        public float AlturaMaximaVuelo { get; set; }
        public string TrenAterrizaje { get; set; }



        public void Volar()
        {
            // Utilizando base se puede acceder a la clase Padre por ej:
            base.Encender();
            Console.WriteLine("Vuela");
            
        }

        public void Aterrizar()
        {
            Console.WriteLine("Aterriza");
        }




    }
}
