using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Datos.Colas
{
    public class Cola
    {
        NodoCola Frente;
        NodoCola Ultimo;
        NodoCola Actual;

        public Cola()
        {
            Frente = null;
            Ultimo = null;
            Actual = null;
        }
        public void insertar(Object objeto)
        {
            NodoCola aux = new NodoCola();
            aux.setObjeto(objeto);

            if (Frente == null)
            {
                Frente = aux;
                Ultimo = Frente;
            }
            else
            {
                Ultimo.setSiguiente(aux);
                Ultimo = aux;
            }
        }
        public Object getFrente()
        {
            return Frente;
        }
        public Object getUltimo()
        {
            return Ultimo;
        }
        public Object getActual()
        {
            return Actual;
        }

        public void reiniciarActual()
        {
            Actual = null;
        }

        public Object obtenerElemento(NodoCola nodo)
        {
            return nodo.getObjeto();
        }

        // Esta función sirve para ayudar a recorrer la pila con objetos dinamicos
        // y que pueda ser reutilizable.
        public Object complementarRecorrido()
        {
            if (Actual == null)
            {
                Actual = Frente;
            }
            else
            {
                Actual = Actual.getSiguiente();
            }
            return obtenerElemento(Actual);
        }
        public void eliminarFrente()
        {
            Frente = Frente.getSiguiente();
        }
    }
}
