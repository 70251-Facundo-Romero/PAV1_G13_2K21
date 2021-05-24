using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.P.A.V.I.Entities
{
    class Empleado
    {

        public int Id { get; set; }
        public int TipoDocumento { get; set; }
        public string NombreEmpleado { get; set; }

        public string NumeroDocumento { get; set; }

        public string ApellidoEmpleado { get; set; }
        public int IdHotel { get; set; }
        public int IdPuesto { get; set; }

        public DateTime FechaIngreso { get; set; }

    }
 
}
