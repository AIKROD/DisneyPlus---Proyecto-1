using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estructura_De_Datos.ListasEnlazadas;
using Estructura_De_Datos.Pilas;
using Estructura_De_Datos.Colas;
using DisneyPlus___Proyecto_1.Clases;

namespace DisneyPlus___Proyecto_1
{
    public partial class Admin : Form
    {
        public Lista Disney;
        public Lista Pixar;
        public Lista Marvel;
        public Lista Star_Wars;
        public Lista National_Geographic;

        public Admin()
        {

            InitializeComponent();


        }

        public Admin(Lista disney,Lista pixar,Lista marvel,Lista star_Wars,Lista national_Geographic)
        {
            InitializeComponent();
              Disney = disney;
              Pixar = pixar;
              Marvel = marvel;
              Star_Wars = star_Wars;
              National_Geographic = national_Geographic;

               
        }

        private void btnAgregarPeli_Click(object sender, EventArgs e)
        {
            Pelicula pelicula;

            if (cmbCategoria.Text == "Disney")
            {
                pelicula = new Pelicula(txtNombre.Text, Int16.Parse(txtAnio.Text.ToString()), "Disney");
                Disney.Insertar(pelicula);
            }
            else if (cmbCategoria.Text == "Pixar")
            {
                pelicula = new Pelicula(txtNombre.Text, Int32.Parse(txtAnio.Text), "Pixar");
                Disney.Insertar(pelicula);
            }
            else if (cmbCategoria.Text == "Marvel")
            {
                pelicula = new Pelicula(txtNombre.Text, Int32.Parse(txtAnio.Text), "Marvel");
                Disney.Insertar(pelicula);
            }
            else if (cmbCategoria.Text == "Star_Wars")
            {
                pelicula = new Pelicula(txtNombre.Text, Int32.Parse(txtAnio.Text), cmbCategoria.Text);
                Disney.Insertar(pelicula);
            }
            else
            {
                pelicula = new Pelicula(txtNombre.Text, Int32.Parse(txtAnio.Text), cmbCategoria.Text);
                Disney.Insertar(pelicula);
            }
        }
    }
}
