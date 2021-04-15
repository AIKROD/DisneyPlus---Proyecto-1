using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Datos.ListaEnlazadaDoble
{
    public class Lista
    {
        Nodo Inicio;
        Object Objeto;
        Nodo Final;
        public Lista()
        {
            Inicio = null;
        }
        public Lista(Object objeto)
        {
            Inicio = new Nodo(objeto);
            Objeto = Inicio;
            Final = Inicio;
        }
        public void insertarAlFinal(Object objeto)
        {
            Nodo aux = Final;            

            Nodo nodo = new Nodo(aux, objeto);
            aux.setSiguiente(nodo);
        }
        public Object getInicio()
        {
            return Inicio;
        }
        public Object getSiguiente(Object nodo)
        {
            Nodo nd = (Nodo)nodo;
            return nd.getSiguiente();            
        }
        public Object getObjeto()
        {
            return Objeto;
        }
    }
}
