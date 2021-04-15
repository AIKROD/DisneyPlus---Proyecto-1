using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyPlus___Proyecto_1.Clases
{
    class Pelicula
    {
        public String nombre { get; set; }
        public int año { get; set; }
        public String categoria { get; set; }

        public Pelicula(String nom, int año, string categoria)
        {
            nombre = nom;
            año = año;
            categoria = categoria;
        }

    }
}
