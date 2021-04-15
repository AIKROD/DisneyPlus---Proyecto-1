using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estructura_De_Datos.Clases;
using Estructura_De_Datos.ListasEnlazadas;
using Estructura_De_Datos.Pilas;
using Estructura_De_Datos.Colas;
using Estructura_De_Datos.ListasDobles;


namespace Estructura_De_Datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ListaEnlazada_Click(object sender, EventArgs e)
        {
            Lista lst = new Lista();
            Catedratico catedratico = new Catedratico("Cat1", "Catedratico1", "Curso1");
            lst.Insertar(catedratico);
            catedratico = new Catedratico("Cat2", "Catedratico2", "Curso2");
            lst.Insertar(catedratico);
            catedratico = new Catedratico("Cat3", "Catedratico3", "Curso3");
            lst.Insertar(catedratico);
            catedratico = new Catedratico("Cat4", "Catedratico4", "Curso4");
            lst.Insertar(catedratico);


            //// Recorrer la lista enlazada
            for (int i = 0; i < lst.NumeroElementos; i++)
            {
                catedratico = (Catedratico) lst.complementarRecorrido();
                Console.Write(catedratico.CodigoCatedratico);
                Console.Write(" -- ");
                Console.Write(catedratico.Nombre);
                Console.Write(" -- ");
                Console.WriteLine(catedratico.Curso);
            }
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            Pila pla = new Pila();
            Catedratico catedratico = new Catedratico("Cat1", "Catedratico1", "Curso1");
            pla.insertar(catedratico);
            catedratico = new Catedratico("Cat2", "Catedratico2", "Curso2");
            pla.insertar(catedratico);
            catedratico = new Catedratico("Cat3", "Catedratico3", "Curso3");
            pla.insertar(catedratico);
            catedratico = new Catedratico("Cat4", "Catedratico4", "Curso4");
            pla.insertar(catedratico);


            ////// INICIO RECORRER PILA
            while (pla.getActual() != pla.getUltimo()) {
                catedratico = (Catedratico) pla.complementarRecorrido();
                Console.Write(catedratico.CodigoCatedratico);
                Console.Write(" -- ");
                Console.Write(catedratico.Nombre);
                Console.Write(" -- ");
                Console.WriteLine(catedratico.Curso);
            }
            pla.reiniciarActual();
            ////// FINAL RECORRER PILA

            pla.eliminarCima();
            pla.eliminarCima();
            

            while (pla.getActual() != pla.getUltimo())
            {
                catedratico = (Catedratico)pla.complementarRecorrido();
                Console.Write(catedratico.CodigoCatedratico);
                Console.Write(" -- ");
                Console.Write(catedratico.Nombre);
                Console.Write(" -- ");
                Console.WriteLine(catedratico.Curso);
            }
            pla.reiniciarActual();

        }

        private void btn_Colas_Click(object sender, EventArgs e)
        {
            Cola cla = new Cola();
            Catedratico catedratico = new Catedratico("Cat1", "Catedratico1", "Curso1");
            cla.insertar(catedratico);
            catedratico = new Catedratico("Cat2", "Catedratico2", "Curso2");
            cla.insertar(catedratico);
            catedratico = new Catedratico("Cat3", "Catedratico3", "Curso3");
            cla.insertar(catedratico);
            catedratico = new Catedratico("Cat4", "Catedratico4", "Curso4");
            cla.insertar(catedratico);


            ////// INICIO RECORRER COLA
            while (cla.getActual() != cla.getUltimo())
            {
                catedratico = (Catedratico)cla.complementarRecorrido();
                Console.Write(catedratico.CodigoCatedratico);
                Console.Write(" -- ");
                Console.Write(catedratico.Nombre);
                Console.Write(" -- ");
                Console.WriteLine(catedratico.Curso);
            }
            cla.reiniciarActual();
            ////// FINAL RECORRER COLA

            cla.eliminarFrente();
            cla.eliminarFrente();


            while(cla.getActual() != cla.getUltimo())
            {
                catedratico = (Catedratico)cla.complementarRecorrido();
                Console.Write(catedratico.CodigoCatedratico);
                Console.Write(" -- ");
                Console.Write(catedratico.Nombre);
                Console.Write(" -- ");
                Console.WriteLine(catedratico.Curso);
            }
            cla.reiniciarActual();
        }

        private void btn_ListaDoble_Click(object sender, EventArgs e)
        {
            {
                ListaDoble lstd = new ListaDoble();
                Catedratico catedratico = new Catedratico("Cat1", "Catedratico1", "Curso1");
                lstd.insertarAlFinal(catedratico);
                catedratico = new Catedratico("Cat2", "Catedratico2", "Curso2");
                lstd.insertarAlFinal(catedratico);
                catedratico = new Catedratico("Cat3", "Catedratico3", "Curso3");
                lstd.insertarAlFinal(catedratico);
                catedratico = new Catedratico("Cat4", "Catedratico4", "Curso4");
                lstd.insertarAlFinal(catedratico);


                ////// INICIO RECORRER LISTA DOBLE
                //Object auxFinal = lstd.getFin();
                //while (lstd.getActual() != lstd.getFin() && auxFinal == lstd.getFin())
                while (lstd.getActual() != lstd.getFin())
                {
                    catedratico = (Catedratico)lstd.complementarRecorrido();
                    if(catedratico != null)
                    {
                        Console.Write(catedratico.CodigoCatedratico);
                        Console.Write(" -- ");
                        Console.Write(catedratico.Nombre);
                        Console.Write(" -- ");
                        Console.WriteLine(catedratico.Curso);
                    }
                    
                }
                ////PRUEBA PARA ELIMINAR EL ULTIMO NODO
                //lstd.eliminarNodo(lstd.getActual());

                lstd.reiniciarActual();
                ////// FINAL RECORRER LISTA DOBLE

                //while (lstd.getActual() != lstd.getFin())
                //{
                //    catedratico = (Catedratico)lstd.complementarRecorrido();
                //    if (catedratico != null)
                //    {
                //        Console.Write(catedratico.CodigoCatedratico);
                //        Console.Write(" -- ");
                //        Console.Write(catedratico.Nombre);
                //        Console.Write(" -- ");
                //        Console.WriteLine(catedratico.Curso);
                //    }

                //}

            }
        }
    }
}
