using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyPlus___Proyecto_1.Clases
{
    public class Perfiles
    {
      
        public String usuario { get; set; }
        public String nombre { get; set; }

        public Perfiles(String usu, String nom)
        {
            usuario = usu;
            nombre = nom;
        }
        
    }
}
