using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Datos.Colas
{
    class NodoCola
    {
        Object Objeto;
        NodoCola Siguiente;

        public void setObjeto(Object objeto)
        {
            Objeto = objeto;
        }
        public Object getObjeto()
        {
            return Objeto;
        }
        public void setSiguiente(NodoCola nodo)
        {
            Siguiente = nodo;
        }
        public NodoCola getSiguiente()
        {
            return Siguiente;
        }
    }
}
