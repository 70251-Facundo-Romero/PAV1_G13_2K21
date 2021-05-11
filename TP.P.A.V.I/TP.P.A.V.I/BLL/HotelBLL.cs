using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.P.A.V.I.DAL;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I.BLL
{
    class HotelBLL
    {
        public static DataTable ObtenerListadoHoteles()
        {
            try
            {
                return HotelesDAL.ObtenerListadoHoteles();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static bool AgregarHotelABD(Hotel h)
        {
            try
            {
                return HotelesDAL.AgregarHotelABD(h);
            }
            catch (Exception ex)
            {
                throw;
             
            }
        }

        public static Hotel ObtenerHotel(int id)
        {
            try
            {
                return HotelesDAL.ObtenerHotel(id);
            }
            catch (Exception)
            {
                throw;
               
            }
        }

        public static bool ActualizarHotelABD(Hotel h)
        {
            try
            {
                return HotelesDAL.ActualizarHotelABD(h);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool BorrarHotelABD(Hotel h)
        {
            try
            {
                return HotelesDAL.BorrarHotelABD(h);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable ObtenerListadoBarrios()
        {
            return HotelesDAL.ObtenerListadoBarrios();
        }

    }
    
}