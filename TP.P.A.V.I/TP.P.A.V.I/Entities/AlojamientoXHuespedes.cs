using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.P.A.V.I.Entities
{
    class AlojamientoXHuespedes
    {
        public int Id_AXH {get; set;}
        public DateTime FechaAlojamiento { get; set; }
        public int IdHabXHotel { get; set; }

        public int IdHuesped { get; set; }
        public int Id_Hotel { get; set; }
        public int Id_Habitacion { get; set; }
        public int Id_Pais { get; set; }
        public int NroPasaporte { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}
