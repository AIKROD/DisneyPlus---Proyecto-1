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
    public partial class Feed : Form
    {
        Form1 frm1;
        public Feed()
        {
            InitializeComponent();
        }

        public Feed(Form1 frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void Feed_Load(object sender, EventArgs e)
        {

            if(frm1 != null)
            {
                RecorrerLista_feed(frm1.Disney, "Disney");
                RecorrerLista_feed(frm1.Pixar, "Pixar");
                //RecorrerLista_feed(frm1.Marvel, listView1.Groups[2]);
                //RecorrerLista_feed(frm1.Star_Wars, listView1.Groups[3]);
                //RecorrerLista_feed(frm1.National_Geographic, listView1.Groups[4]);
            }
        }

        private void RecorrerLista_feed(Lista lst, string grupo)
        {
            ListViewGroup lvg = new ListViewGroup();
            lvg.Name = grupo;
            lvg.Header = grupo;
            listView1.Groups.Add(lvg);

            for (int i = 0; i < lst.NumeroElementos; i++)
            {
                Pelicula pelicula = (Pelicula)lst.complementarRecorrido();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = pelicula.nombre;
                lvi.Group = lvg;

                listView1.Items.Add(lvi);
            }
            lst.ReiniciarActual();
        }
    }
}
