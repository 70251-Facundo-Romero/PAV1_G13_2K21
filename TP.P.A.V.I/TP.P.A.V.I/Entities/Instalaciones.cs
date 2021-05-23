using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.P.A.V.I.Entities
{
    class Instalaciones
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Instalaciones(string Nombre, string Descripcion)
        {
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;

        }
        public Instalaciones()
        {

        }
        public bool CamposNOclear()
        {
            bool rta = true;
            if (this.Nombre.Equals(""))
            {
                rta = false;
            }
            return rta;
        }
    }
}
