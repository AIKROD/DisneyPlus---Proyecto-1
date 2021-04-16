using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisneyPlus___Proyecto_1.Clases;


namespace DisneyPlus___Proyecto_1
{
    public partial class Reproductor : Form
    {
        Form1 frm1;
        Pelicula pelicula;
        public Reproductor()
        {
            InitializeComponent();
        }

        public Reproductor(Form1 frm, Pelicula peli)
        {
            
            InitializeComponent();
            frm1 = frm;
            pelicula = peli;
        }

        private void Reproductor_Load(object sender, EventArgs e)
        {

            lblNombreRep.Text = pelicula.nombre;
            lblCategoriaRep.Text = pelicula.categoria;
            lblAnioRep.Text = pelicula.año.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Feed frm = new Feed(frm1);
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (frm1.numero_usuario == 1)
            {
                frm1.Continuar_Usuario_1.insertar(pelicula);
            }else if (frm1.numero_usuario == 2)
            {
                frm1.Continuar_Usuario_2.insertar(pelicula);
            }
            else if (frm1.numero_usuario == 3)
            {
                frm1.Continuar_Usuario_3.insertar(pelicula);
            }
            Feed frm = new Feed(frm1);
            frm.Show();
            this.Close();
            
        }
    }
}
