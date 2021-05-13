using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.P.A.V.I.Entities
{
    class InstalacionXHuespedes
    {
        public int Id_IXH { get; set; }
        public DateTime FechaAlojamiento { get; set; }
        public int Id_Habitacion { get; set; }
        public int Id_Hotel { get; set; }
        public int Id_Instalacion { get; set; }
        public DateTime FechaUso { get; set; }
        public DateTime HoraUso { get; set; }


    }
}
