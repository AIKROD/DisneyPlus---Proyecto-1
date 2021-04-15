using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estructura_De_Datos.ListasDobles;
using DisneyPlus___Proyecto_1.Clases;
using Estructura_De_Datos.ListasEnlazadas;
using Estructura_De_Datos.Pilas;
using Estructura_De_Datos.Colas;


namespace DisneyPlus___Proyecto_1
{
    public partial class Form1 : Form
    {
        public ListaDoble Usuarios = new ListaDoble();
        public Lista Disney = new Lista();
        public Lista Pixar;
        public Lista Marvel;
        public Lista Star_Wars;
        public Lista National_Geographic;
        Pila Mi_Lista;
        Cola Continuar_Usuario_1;
        Cola Continuar_Usuario_2;
        Cola Continuar_Usuario_3;
        Cola Continuar_Usuario_4;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Perfiles perfil = new Perfiles("astridG","Astrid");
            Usuarios.insertarAlFinal(perfil);
            perfil = new Perfiles("Kevin:)","Kevin");
            Usuarios.insertarAlFinal(perfil);
            perfil = new Perfiles("Michi", "Michael");
            Usuarios.insertarAlFinal(perfil);
            perfil = new Perfiles("Admin", "Administrador");
            Usuarios.insertarAlFinal(perfil);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Admin frm = new Admin(Disney,  Pixar,  Marvel,  Star_Wars,  National_Geographic);
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Disney.NumeroElementos; i++)
            {
                Pelicula pelicula = (Pelicula)Disney.complementarRecorrido();
                Console.Write(pelicula.nombre);
                Console.Write(" -- ");
                Console.Write(pelicula.año);
                Console.Write(" -- ");
                Console.WriteLine(pelicula.categoria);
            }
        }
    }
}
