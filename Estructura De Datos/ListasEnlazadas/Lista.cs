using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Datos.ListasEnlazadas
{
    public class Lista
    {
        public NodoLista Inicio;
        public NodoLista Actual;
        public int NumeroElementos = 0;
        public Lista()
        {
            Inicio = null;
            Actual = null;
        }
        
        public void Insertar(Object elemento)
        {
            NodoLista aux = new NodoLista();
            aux.elemento = elemento;
            aux.enlace = null;

            if(Inicio == null)
            {
                Inicio = aux;
            }
            else
            {
                NodoLista NodoActual;
                NodoActual = Inicio;

                while(NodoActual.enlace != null)
                {
                    NodoActual = NodoActual.enlace;
                }
                NodoActual.enlace = aux;
            }
            NumeroElementos++;
        }

        public Object obtenerElemento(NodoLista nodo)
        {
            return nodo.elemento;
        }


        // Esta función sirve para ayudar a recorrer la lista enlazada con objetos dinamicos
        // y que pueda ser reutilizable.
        public Object complementarRecorrido() 
        {
            if (Actual == null)
            {
                Actual = Inicio;
            }
            else 
            {
                Actual = Actual.enlace;
            }
            return obtenerElemento(Actual);
        }

        public void ReiniciarActual()
        {
            Actual = null;
        }
        public Boolean EliminarElemento(NodoLista nodo)
        {
            NodoLista aux = Inicio;
            while(aux != null)
            {
                if(aux.enlace == nodo)
                {
                    aux.enlace = nodo.enlace;
                    NumeroElementos--;
                    return true;
                } 
                else if (aux == nodo)
                {
                    Inicio = nodo.enlace; ;
                    NumeroElementos--;
                    return true;
                }
                else
                {
                    aux = aux.enlace;
                }
            }
            return false;
        }
    }
}
