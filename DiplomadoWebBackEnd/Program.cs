using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiplomadoWebBackEnd.Clase1.Herencia;

namespace DiplomadoWebBackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");



            // HERENCIA


            // Se crea un Auto con propiedades como Marca, Color, Que son de la clase Vehiculo
            // y tambien CantidadPuertas y NumeroPlaca que son propias de la clase Auto

            // Al momento de crear el objeto auto, se llama al constructor padre y luego al constructor hijo
            var auto = new Auto
            {
                CantidadPuertas = 4,
                NumeroPlaca = "AX1234",
                Modelo = "Corolla S",
                Marca = "Toyota",
                Color = "Blanco"
            };

           
            auto.Acelerar();


            

        }
    }
}
