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
        public int IdInstXHotel { get; set; }
        public int IdAlojamiento { get; set; }
        public DateTime FechaUso { get; set; }
        public int Id_Hotel { get; internal set; }
        public int Id_Habitacion { get; internal set; }
        public int Id_Instalacion { get; internal set; }
        public DateTime FechaAlojamiento { get; internal set; }
    }
}
