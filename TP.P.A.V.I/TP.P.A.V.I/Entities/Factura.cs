using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.P.A.V.I.Entities
{
    public class Factura
    {
        public int NroFactura { get; set; }
        public int IdAloj { get; set; }
        public int IdHuesped { get; set; }
        public int CantDias { get; set; }
        public string PrecioHab { get; set; }
        public string PrecioTotal { get; set; }
        public DateTime FechaFactura { get; set; }
        public DateTime FechaAloj { get; set; }
        public string pasaporte { get; set; }
        public int IdPais { get; set; }
        public int IdHotel { get; set; }
        public string nombreHuesped{ get; set; }
        public string nombreHabitacion{ get; set; }
        public string apellidoHuesped{ get; set; }
        public string NomHotel{ get; set; }
        public string NomPais{ get; set; }

    }
}
