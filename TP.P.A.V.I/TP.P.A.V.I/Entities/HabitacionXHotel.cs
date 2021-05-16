using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.P.A.V.I.Entities
{
    public class HabitacionXHotel
    {
        public int Id { get; set; }
        public int hotel { get; set; }
        public int habitacion { get; set; }
        public string Precio { get; set; }
    }
}
