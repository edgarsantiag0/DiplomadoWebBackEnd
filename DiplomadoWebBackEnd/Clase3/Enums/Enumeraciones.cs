using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase3.Enums
{
    enum Tamaño : int
    {
        Pequeño = 0,
        Mediano = 1,
        Grande = 2
    }

    // Por defecto al ser entero su valor es cero
    // y los siguientes se incrementan en 1 
    // Grande vale 6

    enum Tamaño2
    {
        Pequeño,
        Mediano = 5,
        Grande
    }

    enum ModificadorArchivo
    {
        Lectura = 1,
        Escritura = 2,
        Oculto = 4,
        Sistema = 8
    }

    public class PruebaEnum
    {


        public void Play()
        {
            Tamaño t = Tamaño.Grande;   // Ahora t vale Tamaño.Grande 

            int i = (int) Tamaño.Pequeño;     // Ahora i vale 0


            Tamaño t2 = (Tamaño) 0;      // Ahora t vale Tamaño.Pequeño (=0)

            t = (Tamaño) 100;           // Ahora t vale 100, que no se corresponde con ningún literal 
           

        }



    }
}
