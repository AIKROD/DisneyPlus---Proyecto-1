using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Datos.ListaEnlazadaDoble
{
    public class Nodo
    {
        Nodo Anterior;
        Object Objeto;
        Nodo Siguiente;

        public Nodo(Object objeto)
        {
            Anterior = null;
            Objeto = objeto;
            Siguiente = null;
        }
        public Nodo(Nodo anterior, Object objeto)
        {
            Anterior = anterior;
            Objeto = objeto;
            Siguiente = null;
        }
        public Nodo(Nodo anterior, Object objeto, Nodo siguiente)
        {
            Anterior = anterior;
            Objeto = objeto;
            Siguiente = siguiente;
        }
        public Object getObjeto()
        {
            return Objeto;
        }
        public Nodo getAnterior()
        {
            return Anterior;
        }
        public Nodo getSiguiente()
        {
            return Siguiente;
        }
        public void setSiguiente(Nodo nodo)
        {
            Siguiente = nodo;
        }

    }
}
