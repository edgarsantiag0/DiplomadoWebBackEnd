using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase2.Delegados
{
    class DelegadoMulticast
    {
        public delegate void MiDelegadoMultiCast(int i);

        public void Prueba()
        {
            MiDelegado miClase = new MiDelegado();

            // MiClase cumple con la firma definida en el delegado
            MiDelegadoMultiCast delegado = miClase.MiMetodo1;
            delegado(83); // Se hace la llamada al delegado

            // agregamos ahora el Metodo2 
            delegado += miClase.MiMetodo2;

            // Se hace la llamada al delegado y se ejecutarán en orden secuencial ambos métodos
            delegado(55);

            // eliminamos ahora el Metodo1 
            delegado -= miClase.MiMetodo1;

            // Se hace la llamada al delegado y se ejecutará únicamente el Método2
            delegado(14);
        }
    }

    public class MiDelegado
    {
        public void MiMetodo1(int i)
        {
            Console.WriteLine("El valor pasado al METODO1 como parámetro es: {0}", i);
        }
        public void MiMetodo2(int i)
        {
            Console.WriteLine("El valor pasado al METODO2 como parámetro es: {0}", i);
        }
    }
}
