using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyPlus___Proyecto_1.Clases
{
    public class Pelicula
    {
        public String nombre { get; set; }
        public int año { get; set; }
        public String categoria { get; set; }

        public Pelicula(String nom, int anio, string cate)
        {
            nombre = nom;
            año = anio;
            categoria = cate;
        }

    }
}
