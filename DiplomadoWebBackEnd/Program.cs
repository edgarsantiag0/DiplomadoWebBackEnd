using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiplomadoWebBackEnd.Clase1.Genericos;
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


            // METODOS GENERICOS
            // Utilizando metodos genericos me puedo ahorrar la creacion de metodos 
            // que hacen lo mismo pero que cambian el tipo de parametro

            int a = 1;
            int b = 2;

            MetodosGenericos.Swap<int>(ref a, ref b);
            Console.WriteLine("Metodo swap generico");
            System.Console.WriteLine(a + " " + b);

            double c = 4.5;
            double d = 10.8;

            MetodosGenericos.Swap<double>(ref c, ref d);
            System.Console.WriteLine(c + " " + d);


            // CLASES GENERICAS


            var cajaDeEntero = new Caja<int>(5);
            var cajaDeString = new Caja<string>("Hola mundo");

            Console.WriteLine(cajaDeEntero.Contenido); // 5
            Console.WriteLine(cajaDeString.Contenido); // Hola mundo

        }
    }
}
