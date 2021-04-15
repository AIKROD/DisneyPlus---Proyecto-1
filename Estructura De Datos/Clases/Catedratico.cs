using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Datos.Clases
{
    class Catedratico
    {
        public String CodigoCatedratico { get; set;}
        public String Nombre { get; set; }
        public String Curso { get; set; }

        public Catedratico(String codigoCatedratico, String nombre, String curso)
        {
            CodigoCatedratico = codigoCatedratico;
            Nombre = nombre;
            Curso = curso;
        }
    }
}
