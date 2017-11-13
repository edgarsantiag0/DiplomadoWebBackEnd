using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase1.Herencia
{
    class Vehiculo
    {
        // forma implicita de get y set
        public string Color { get; set; }
        public string Marca { get; set; }
        public float Velocidad { get; set; }
        public int NumeroPasajeros { get; set; }


        private string modelo; 


        

        // forma explicita de get y set
        public string Modelo
        {
            get { return modelo; }

            set { this.modelo = value; }
        }

        public Vehiculo()
        {
            Console.WriteLine("Constructor clase vehiculo");
        }

        public Vehiculo(string marca, string color)
        {
            Console.WriteLine("Marca: {0}, Color: {1}", marca, color);
        }


        public void Encender()
        {
            Console.WriteLine("Enciende");
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelera");
        }

        public void Apagar()
        {
            Console.WriteLine("Apaga");
        }

    }
}
