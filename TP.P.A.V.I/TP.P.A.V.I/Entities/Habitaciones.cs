using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP.P.A.V.I.Entities
{
    public class Habitaciones
    {
        public string id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Habitaciones(string Nombre, string Descripcion)
        {
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;

        }
        public Habitaciones()
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
