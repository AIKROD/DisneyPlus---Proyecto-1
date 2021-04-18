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

        private ListView CrearListView()
        {
            ListView lvCategory = new ListView();
            lvCategory.View = View.LargeIcon;
            lvCategory.BorderStyle = BorderStyle.None;
            lvCategory.Cursor = Cursors.Hand;
            lvCategory.Width = 590;
            lvCategory.Height = 55;
            lvCategory.Top = 15;
            lvCategory.Left = 10;
            lvCategory.Alignment = ListViewAlignment.Left;
            lvCategory.BackColor = Color.FromArgb(35, 39, 55);
            lvCategory.ForeColor = Color.White;
            lvCategory.SelectedIndexChanged += new EventHandler(lvCategory_SelectedIndexChanged);
            lvCategory.View = View.Tile;

            return lvCategory;
        }
        private void RecorrerLista_feed(Lista lst, string grupo)
        {
            ListView lvCategory = CrearListView();

            for (int i = 0; i < lst.NumeroElementos; i++)
            {
                Pelicula pelicula = (Pelicula)lst.complementarRecorrido();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = pelicula.nombre;
                lvi.Name = pelicula.categoria + "_" + pelicula.nombre;
                lvCategory.Items.Add(lvi);

            }
            lst.ReiniciarActual();
            if (grupo == "Disney")
            {
                groupBox1.Controls.Add(lvCategory);
            }
            else if (grupo == "Pixar")
            {
                gbPixar.Controls.Add(lvCategory);
            } 
            else if (grupo == "Marvel")
            {
                gbMarvel.Controls.Add(lvCategory);
            }
            else if (grupo == "Star Wars")
            {
                gbStarWars.Controls.Add(lvCategory);
            }
            else if (grupo == "National Geographic")
            {
                gbNationalGeographic.Controls.Add(lvCategory);
            }

        }

        private void RecorrerPila_feed(Pila pla, string grupo)
        {
            ListView lvCategory = CrearListView();

            while (pla.getActual() != pla.getUltimo())
            {
                Pelicula pelicula = (Pelicula)pla.complementarRecorrido();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = pelicula.nombre;
                lvi.Name = pelicula.categoria + "_" + pelicula.nombre;
                lvCategory.Items.Add(lvi);
            }
            pla.reiniciarActual();

            gbMiLista.Controls.Add(lvCategory);
        }

        private void RecorrerCola_feed(Cola cla, string grupo)
        {
            ListView lvCategory = CrearListView();

            while (cla.getActual() != cla.getUltimo())
            {
                Pelicula pelicula = (Pelicula)cla.complementarRecorrido();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = pelicula.nombre;
                lvi.Name = pelicula.categoria + "_" + pelicula.nombre;
                lvCategory.Items.Add(lvi);
            }
            cla.reiniciarActual();

            gbContinuarViendo.Controls.Add(lvCategory);
        }


        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lvCategory = (ListView)sender;

            if (lvCategory.SelectedItems.Count > 0)
            {
                btnVerPeli.Enabled = true;
                btnAgregarList.Enabled = true;
                if (lvCategory.SelectedItems[0].Name.ToString() == "Disney_" + lvCategory.SelectedItems[0].Text)
                {
                    pelicula = buscarPelicula(frm1.Disney, lvCategory.SelectedItems[0].Text.ToString());
                }
                else if (lvCategory.SelectedItems[0].Name.ToString() == "Pixar_" + lvCategory.SelectedItems[0].Text)
                {
                    pelicula = buscarPelicula(frm1.Pixar, lvCategory.SelectedItems[0].Text.ToString());
                }
                else if (lvCategory.SelectedItems[0].Name.ToString() == "Marvel_" + lvCategory.SelectedItems[0].Text)
                {
                    pelicula = buscarPelicula(frm1.Marvel, lvCategory.SelectedItems[0].Text.ToString());
                }
                else if (lvCategory.SelectedItems[0].Name.ToString() == "Star Wars_" + lvCategory.SelectedItems[0].Text)
                {
                    pelicula = buscarPelicula(frm1.Star_Wars, lvCategory.SelectedItems[0].Text.ToString());
                }
                else if (lvCategory.SelectedItems[0].Name.ToString() == "National Geographic_" + lvCategory.SelectedItems[0].Text)
                {
                    pelicula = buscarPelicula(frm1.National_Geographic, lvCategory.SelectedItems[0].Text.ToString());
                }
                else if (lvCategory.SelectedItems[0].Name.ToString() == "Mi Lista_" + lvCategory.SelectedItems[0].Text)
                {
                    if (frm1.numero_usuario == 1)
                    {
                        pelicula = buscarPeliculaMiLista(frm1.Mi_Lista, lvCategory.SelectedItems[0].Text.ToString());
                    }
                    else if (frm1.numero_usuario == 2)
                    {
                        pelicula = buscarPeliculaMiLista(frm1.Mi_Lista_2, lvCategory.SelectedItems[0].Text.ToString());
                    }
                    if (frm1.numero_usuario == 3)
                    {
                        pelicula = buscarPeliculaMiLista(frm1.Mi_Lista_3, lvCategory.SelectedItems[0].Text.ToString());
                    }
                }
                else if (lvCategory.SelectedItems[0].Name.ToString() == "Continuar Viendo_" + lvCategory.SelectedItems[0].Text)
                {
                    if (frm1.numero_usuario == 1)
                    {
                        pelicula = buscarPeliculaContinuarViendo(frm1.Continuar_Usuario_1, lvCategory.SelectedItems[0].Text.ToString());
                    }
                    else if (frm1.numero_usuario == 2)
                    {
                        pelicula = buscarPeliculaContinuarViendo(frm1.Continuar_Usuario_2, lvCategory.SelectedItems[0].Text.ToString());
                    }
                    if (frm1.numero_usuario == 3)
                    {
                        pelicula = buscarPeliculaContinuarViendo(frm1.Continuar_Usuario_3, lvCategory.SelectedItems[0].Text.ToString());
                    }
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

        private void btnAgregarList_Click(object sender, EventArgs e)
        {
            
            Pelicula pelicula = new Pelicula(lblNombreLista.Text, Int32.Parse(lblAnioLista.Text),  lblCategoriaLista.Text);
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

        private Pelicula buscarPeliculaMiLista(Pila pla, String peli)
        {
            while (pla.getActual() != pla.getUltimo())
            {
                pelicula = (Pelicula)pla.complementarRecorrido();
                if (pelicula.nombre == peli)
                {
                    pla.reiniciarActual();
                    return pelicula;
                }
            }
            pla.reiniciarActual();
            return null;
        }

        private Pelicula buscarPeliculaContinuarViendo(Cola cla, String peli)
        {
            while (cla.getActual() != cla.getUltimo())
            {
                pelicula = (Pelicula)cla.complementarRecorrido();
                if (pelicula.nombre == peli)
                {
                    cla.reiniciarActual();
                    return pelicula;
                }
            }
            cla.reiniciarActual();
            return null;
        }

        private void btnVerPeli_Click(object sender, EventArgs e)
        {
            Reproductor frm = new Reproductor(frm1, pelicula);
            if (gbContinuarViendo.Visible == true)
            {
                if (frm1.numero_usuario == 1)
                {
                    frm1.Continuar_Usuario_1.eliminarFrente();
                }
                else if (frm1.numero_usuario == 2)
                {
                    frm1.Continuar_Usuario_2.eliminarFrente();
                }
                else if (frm1.numero_usuario == 3)
                {
                    frm1.Continuar_Usuario_3.eliminarFrente();
                }
            }

            frm.Show();
            this.Close();
        }

        private void LimpiarGrupos()
        {
            pelicula = null;
            lblNombreLista.Text = "";
            lblAnioLista.Text = "";
            lblCategoriaLista.Text = "";
            gbContinuarViendo.Visible = false;
            gbMiLista.Visible = false;
            groupBox1.Visible = false;
            gbPixar.Visible = false;
            gbMarvel.Visible = false;
            gbStarWars.Visible = false;
            gbNationalGeographic.Visible = false;

            if (gbContinuarViendo.Controls.Count > 0)
            {
                gbContinuarViendo.Controls.RemoveAt(0);
            }
            if (gbMiLista.Controls.Count > 0)
            {
                gbMiLista.Controls.RemoveAt(0);
            }
            if (groupBox1.Controls.Count > 0)
            {
                groupBox1.Controls.RemoveAt(0);
            }
            if (gbPixar.Controls.Count > 0)
            {
                gbPixar.Controls.RemoveAt(0);
            }
            if (gbMarvel.Controls.Count > 0)
            {
                gbMarvel.Controls.RemoveAt(0);
            }
            if (gbStarWars.Controls.Count > 0)
            {
                gbStarWars.Controls.RemoveAt(0);
            }
            if (gbNationalGeographic.Controls.Count > 0)
            {
                gbNationalGeographic.Controls.RemoveAt(0);
            }
        }
        private void miListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar_feed();
            gbMiLista.Visible = true;
        }
        private void continuarViendoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar_feed();
            gbContinuarViendo.Visible = true;
        }

        private void disneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar_feed();
            groupBox1.Visible = true;
            gbPixar.Visible = true;
            gbMarvel.Visible = true;
            gbStarWars.Visible = true;
            gbNationalGeographic.Visible = true;
        }
        private void Actualizar_feed()
        {
            LimpiarGrupos();

            if (frm1.numero_usuario == 1)
            {
                RecorrerPila_feed(frm1.Mi_Lista, "Mi Lista");
                RecorrerCola_feed(frm1.Continuar_Usuario_1, "Mi Lista");
            }
            else if (frm1.numero_usuario == 2)
            {
                RecorrerPila_feed(frm1.Mi_Lista_2, "Mi Lista");
                RecorrerCola_feed(frm1.Continuar_Usuario_2, "Mi Lista");
            }
            else if (frm1.numero_usuario == 3)
            {
                RecorrerPila_feed(frm1.Mi_Lista_3, "Mi Lista");
                RecorrerCola_feed(frm1.Continuar_Usuario_3, "Mi Lista");
            }

            RecorrerLista_feed(frm1.Disney, "Disney");
            RecorrerLista_feed(frm1.Pixar, "Pixar");
            RecorrerLista_feed(frm1.Marvel, "Marvel");
            RecorrerLista_feed(frm1.Star_Wars, "Star Wars");
            RecorrerLista_feed(frm1.National_Geographic, "National Geographic");
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LimpiarGrupos();
            this.Close();
        }
    }
}
