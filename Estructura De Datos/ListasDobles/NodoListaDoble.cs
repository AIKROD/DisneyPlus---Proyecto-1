using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Datos.ListasDobles
{
    public class NodoListaDoble
    {
        NodoListaDoble Ant;
        Object Obj;
        NodoListaDoble Sig;

        public NodoListaDoble(Object objeto)
        {
            Ant = null;
            Obj = objeto;
            Sig = null;
        }
        public Object getObjeto()
        {
            return Obj;
        }
        public NodoListaDoble getNodoAnterior()
        {
            return Ant;
        }
        public NodoListaDoble getNodoSiguiente()
        {
            return Sig;
        }
        public void setNodoSiguiente(NodoListaDoble nodo)
        {
            Sig = nodo;
        }
        public void setNodoAnterior(NodoListaDoble nodo)
        {
            Ant = nodo;
        }

    }
}
