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
        Form1 frm1;

        public Admin()
        {
            InitializeComponent();
        }

        //public Admin(Lista disney,Lista pixar,Lista marvel,Lista star_Wars,Lista national_Geographic)
        public Admin(Form1 frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void btnAgregarPeli_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula(txtNombre.Text, Int32.Parse(txtAnio.Text), cmbCategoria.Text);
            if (cmbCategoria.Text == "Disney")
            {
                frm1.Disney.Insertar(pelicula);
            }
            else if (cmbCategoria.Text == "Pixar")
            {
                frm1.Pixar.Insertar(pelicula);
            }
            else if (cmbCategoria.Text == "Marvel")
            {
                frm1.Marvel.Insertar(pelicula);
            }
            else if (cmbCategoria.Text == "Star Wars")
            {
                frm1.Star_Wars.Insertar(pelicula);
            }
            else if (cmbCategoria.Text == "National Geographic")
            {
                frm1.National_Geographic.Insertar(pelicula);
            }
        }

        private void btnBuscar_Eliminar_Click(object sender, EventArgs e)
        {
            VerificarCategoría();
        }
        private void VerificarCategoría()
        {
            if (cmbCategoria_Eliminar.Text == "Disney")
            {
                LlenarLista_Eliminar(frm1.Disney);
            }
            else if (cmbCategoria_Eliminar.Text == "Pixar")
            {
                LlenarLista_Eliminar(frm1.Pixar);
            }
            else if (cmbCategoria_Eliminar.Text == "Marvel")
            {
                LlenarLista_Eliminar(frm1.Marvel);
            }
            else if (cmbCategoria_Eliminar.Text == "Star Wars")
            {
                LlenarLista_Eliminar(frm1.Star_Wars);
            }
            else if (cmbCategoria_Eliminar.Text == "National Geographic")
            {
                LlenarLista_Eliminar(frm1.National_Geographic);
            }
        }
        private void LlenarLista_Eliminar(Lista lst)
        {
            lbCategorias_Eliminar.Items.Clear();
            for (int i = 0; i < lst.NumeroElementos; i++)
            {
                Pelicula pelicula = (Pelicula)lst.complementarRecorrido();
                lbCategorias_Eliminar.Items.Add(pelicula.nombre);
            }
            lst.ReiniciarActual();
        }

        private void btnEliminar_Eliminar_Click(object sender, EventArgs e)
        {
            if (cmbCategoria_Eliminar.Text == "Disney")
            {
                EliminarDeLista(frm1.Disney, lbCategorias_Eliminar.SelectedItem.ToString());
            }
            else if (cmbCategoria_Eliminar.Text == "Pixar")
            {
                EliminarDeLista(frm1.Pixar, lbCategorias_Eliminar.SelectedItem.ToString());
            }
            else if (cmbCategoria_Eliminar.Text == "Marvel")
            {
                EliminarDeLista(frm1.Marvel, lbCategorias_Eliminar.SelectedItem.ToString());
            }
            else if (cmbCategoria_Eliminar.Text == "Star Wars")
            {
                EliminarDeLista(frm1.Star_Wars, lbCategorias_Eliminar.SelectedItem.ToString());
            }
            else if (cmbCategoria_Eliminar.Text == "National Geographic")
            {
                EliminarDeLista(frm1.National_Geographic, lbCategorias_Eliminar.SelectedItem.ToString());
            }
        }

        private void EliminarDeLista(Lista lst, String NombrePelicula)
        {
            for (int i = 0; i < lst.NumeroElementos; i++)
            {
                Pelicula pelicula = (Pelicula)lst.complementarRecorrido();
                if(pelicula.nombre == NombrePelicula)
                {
                    if (lst.EliminarElemento(lst.Actual))
                    {
                        lst.ReiniciarActual();
                        break;
                    }
                }
            }
            lst.ReiniciarActual();
            VerificarCategoría();
            btnEliminar_Eliminar.Enabled = false;

        }

        private void cmbCategoria_Eliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarCategoría();
        }

        private void lbCategorias_Eliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCategorias_Eliminar.SelectedIndex >= 0 )
            {
                btnEliminar_Eliminar.Enabled = true;
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAgregarPeli.Enabled = true;
        }
    }
}
