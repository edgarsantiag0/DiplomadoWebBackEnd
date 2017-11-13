#define ANCHO //  SE DEFINEN VARIABLES TIPO BANDERAS
#define ALTURA 

#undef ANCHO

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase1.PreProcesadores
{
    class PreProcesadores
    {


        // PODEMOS HACER REGIONES PARA SEGMENTAR EL CODIGO

        public PreProcesadores()
        {

            #region REGION_NUMERO_1

            // Aqui hay una region

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            #endregion

            #region REGION_NUMERO_2

            // Aqui hay una region

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            #endregion

            #if (ANCHO)
                Console.WriteLine("ANCHO esta definido");
            #else
                Console.WriteLine("ANCHO no esta definido");
            #endif

            #if (DEBUG == true)
                Console.WriteLine("Debug is true");
                #warning C++ compiler required.  
                #line 151 "copy.c" 

                //La directiva
                //#line indica al preprocesador que cambie el número de línea y el nombre de archivo almacenados internamente por el compilador a un número de línea y un nombre de archivo especificados.

            #else
                Console.WriteLine("Debug is false");
                #error C++ compiler required.  
            #endif



        }



    }
}
