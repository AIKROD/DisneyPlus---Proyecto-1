using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Datos.ListasDobles
{
    public class ListaDoble
    {
        NodoListaDoble Inicio;
        NodoListaDoble Actual;
        NodoListaDoble Fin;
        int NumeroElementos = 0;
        public ListaDoble()
        {
            Inicio = null;
            Fin = null;
        }
        public void insertarAlFinal(Object objeto)
        {
            NodoListaDoble aux = new NodoListaDoble(objeto);  
            if(Inicio == null)
            {
                Inicio = aux;
                Fin = aux;
            }
            else
            {
                Fin.setNodoSiguiente(aux);
                aux.setNodoAnterior(Fin);
                Fin = aux;
            }
            NumeroElementos++;
        }
        public Object getInicio()
        {
            return Inicio;
        }
        public Object getFin()
        {
            return Fin;
        }
        public Object getActual()
        {
            return Actual;
        }
        public void reiniciarActual()
        {
            Actual = null;
        }

        public Object obtenerElemento(NodoListaDoble nodo)
        {
            return nodo.getObjeto();
        }

        // Esta función sirve para ayudar a recorrer la lista enlazada doble con objetos dinamicos
        // y que pueda ser reutilizable.
        public Object complementarRecorrido()
        {
            if (Actual == null)
            {
                Actual = Inicio;
            }
            else
            {
                Actual = Actual.getNodoSiguiente();
            }

            //eliminarNodo(Actual);
            if (Actual != null)
            {
                return obtenerElemento(Actual);
            }
            else
            {
                return null;
            }


        }
        
        public void eliminarNodo(Object nodoAEliminar)
        {
            NodoListaDoble nodo = (NodoListaDoble)nodoAEliminar;
            NodoListaDoble aux;
            if(nodo.getNodoAnterior() != null)
            {
                aux = nodo.getNodoAnterior();
                aux.setNodoSiguiente(nodo.getNodoSiguiente());

                if (nodo.getNodoSiguiente() != null)
                {
                    aux = nodo.getNodoSiguiente();
                    aux.setNodoAnterior(nodo.getNodoAnterior());
                }
                else
                {
                    Fin = aux;
                }
            } 
            else if(nodo.getNodoSiguiente() != null)
            {
                aux = nodo.getNodoSiguiente();
                aux.setNodoAnterior(null);
                Inicio = aux;
            }
            else
            {
                Inicio = null;
                Fin = null;
                Actual = null;
            }

            NumeroElementos--;
        }

    }
}
