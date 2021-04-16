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
        Pelicula pelicula;
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
                RecorrerLista_feed(frm1.Marvel, "Marvel");
                RecorrerLista_feed(frm1.Star_Wars, "Star Wars");
                RecorrerLista_feed(frm1.National_Geographic, "National Geographic");
            }
        }

        private void RecorrerLista_feed(Lista lst, string grupo)
        {
            //ListViewGroup lvg = new ListViewGroup();
            //lvg.Name = grupo;
            //lvg.Header = grupo;
            
            //listView1.Groups.Add(lvg);

            ListView lvCategory = new ListView();
            lvCategory.View = View.LargeIcon;
            lvCategory.BorderStyle = BorderStyle.None;
            lvCategory.Cursor = Cursors.Hand;//Set the mouse to hand

            //lvCategory.Left = 430;
            lvCategory.Width = 590;
            //lvCategory.Dock = (DockStyle.Right && Dock );
            //lvCategory.Dock = DockStyle.Left;
            //lvCategory.Dock = DockStyle.;
            //lvCategory.Dock = DockStyle.Right;

            lvCategory.Height = 55;
            lvCategory.Top = 15;
            //lvCategory.Bottom = 10;
            lvCategory.Left = 10;
            //lvCategory.Right = 10;
            lvCategory.Alignment = ListViewAlignment.Left;
            
            //lvCategory.Anchor = AnchorStyles.Right;
            //lvCategory.BackColor = Color.lFromArgb(216, 222, 230);//Background color
            lvCategory.SelectedIndexChanged += new EventHandler(lvCategory_SelectedIndexChanged);
            lvCategory.View = View.Tile;


            for (int i = 0; i < lst.NumeroElementos; i++)
            {
                Pelicula pelicula = (Pelicula)lst.complementarRecorrido();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = pelicula.nombre;
                //lvi.EnsureVisible();

                //listView1.Items.Add(lvi);


                //Add a click event
                //lvCategory.SelectedIndexChanged += new EventHandler(lvCategory_SelectedIndexChanged);
                //lvCategory.Groups.Add(lvg);
                lvCategory.Items.Add(lvi);

            }
            lst.ReiniciarActual();
            groupBox1.Controls.Add(lvCategory);

        }

        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lvCategory = (ListView)sender;//Get dynamically created listview object


            if (lvCategory.SelectedItems.Count > 0)
            {
                btnVerPeli.Enabled = true;
                btnAgregarList.Enabled = true;
                //if (lvCategory.SelectedItems[0].ToString() == "Disney")
                //{
                    pelicula = buscarPelicula(frm1.Disney, lvCategory.SelectedItems[0].Text.ToString());
                //}
                //else if (lvCategory.SelectedItems[0].ToString() == "Pixar")
                //{
                //    pelicula = buscarPelicula(frm1.Pixar, lvCategory.SelectedItems[0].Text.ToString());
                //}
                //else if (lvCategory.SelectedItems[0].ToString() == "Marvel")
                //{
                //    pelicula = buscarPelicula(frm1.Marvel, lvCategory.SelectedItems[0].Text.ToString());
                //}
                //else if (lvCategory.SelectedItems[0].ToString() == "Star Wars")
                //{
                //    pelicula = buscarPelicula(frm1.Star_Wars, lvCategory.SelectedItems[0].Text.ToString());
                //}
                //else if (lvCategory.SelectedItems[0].ToString() == "National Geographic")
                //{
                //    pelicula = buscarPelicula(frm1.National_Geographic, lvCategory.SelectedItems[0].Text.ToString());
                //}
                //else
                //{
                //    pelicula = null;
                //}

                lblNombreLista.Text = pelicula.nombre;
                lblAnioLista.Text = pelicula.año.ToString();
                lblCategoriaLista.Text = pelicula.categoria.ToString();
            }
        }

        private void btnAgregarList_Click(object sender, EventArgs e)
        {
            
            Pelicula pelicula = new Pelicula(lblNombreLista.Text, Int32.Parse(lblAnioLista.Text),  lblCategoriaLista.Text);
            frm1.Mi_Lista.insertar(pelicula);
            if (frm1.numero_usuario == 1)
            {
                frm1.Mi_Lista.insertar(pelicula);
            }else if (frm1.numero_usuario == 2)
            {
                frm1.Mi_Lista_2.insertar(pelicula);
            }else if (frm1.numero_usuario == 3)
            {
                frm1.Mi_Lista_3.insertar(pelicula);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private Pelicula buscarPelicula(Lista lst, String peli)
        {
            for (int i = 0; i < lst.NumeroElementos; i++)
            {
                pelicula = (Pelicula)lst.complementarRecorrido();
                if (pelicula.nombre == peli)
                {
                    lst.ReiniciarActual();
                    return pelicula;
                }
            }
            lst.ReiniciarActual();
            return null;
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count >0)
            {
                btnVerPeli.Enabled = true;
                btnAgregarList.Enabled = true;
                if (listView1.SelectedItems[0].Group.ToString() == "Disney")
                {
                    pelicula = buscarPelicula(frm1.Disney, listView1.SelectedItems[0].Text.ToString());
                }
                else if (listView1.SelectedItems[0].Group.ToString() == "Pixar")
                {
                    pelicula = buscarPelicula(frm1.Pixar, listView1.SelectedItems[0].Text.ToString());
                }
                else if (listView1.SelectedItems[0].Group.ToString() == "Marvel")
                {
                    pelicula = buscarPelicula(frm1.Marvel, listView1.SelectedItems[0].Text.ToString());
                }
                else if (listView1.SelectedItems[0].Group.ToString() == "Star Wars")
                {
                    pelicula = buscarPelicula(frm1.Star_Wars, listView1.SelectedItems[0].Text.ToString());
                }
                else if (listView1.SelectedItems[0].Group.ToString() == "National Geographic")
                {
                    pelicula = buscarPelicula(frm1.National_Geographic, listView1.SelectedItems[0].Text.ToString());
                }
                else
                {
                    pelicula = null;
                }

                lblNombreLista.Text = pelicula.nombre;
                lblAnioLista.Text = pelicula.año.ToString();
                lblCategoriaLista.Text = pelicula.categoria.ToString();
            }
            
        }

        private void btnVerPeli_Click(object sender, EventArgs e)
        {
            Reproductor frm = new Reproductor(frm1, pelicula);
            frm.Show();
            this.Close();
        }
    }
}
