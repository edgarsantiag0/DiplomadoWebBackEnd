using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase1.Genericos
{
    class Caja<T>
    {

        public T Contenido { get; private set; }

        public Caja(T contenido)
        {
            this.Contenido = contenido;
        }

    }
}
