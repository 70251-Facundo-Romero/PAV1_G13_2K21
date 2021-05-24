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
    public static class ServicioXHotelBLL
    {
        internal static DataTable ObtenerListadoHoteles()
        {
            return ServicioXHotelDAL.ObtenerListadoHoteles();
        }

        internal static DataTable ObtenerListadoServicios()
        {
            return ServicioXHotelDAL.ObtenerListadoServicios();
        }

        internal static DataTable ObtenerListadoServXHoteles()
        {
            return ServicioXHotelDAL.ObtenerListadoServxHoteles();
        }

        internal static ServXHotel ObtenerServXHotel(int id)
        {
            return ServicioXHotelDAL.ObtenerServXHotel(id);
        }

        internal static bool AgregarServXHotel(ServXHotel s)
        {
            return ServicioXHotelDAL.AgregarServXHotel(s);
        }

        internal static bool ActualizarServXHotel(ServXHotel s)
        {
            return ServicioXHotelDAL.ActualizarServXHotel(s);
        }

        internal static bool BorrarServXHotel(ServXHotel s)
        {
            return ServicioXHotelDAL.BorrarServXHotel(s);
        }

        internal static bool VerificarExisteCombinacion(int idHot, int idServ)
        {
            return ServicioXHotelDAL.VerificarExisteCombinacion(idHot, idServ);
        }

        internal static bool VerificarExisteCombinacion2(int idHot, int idServ, string precio)
        {
            return ServicioXHotelDAL.VerificarExisteCombinacion2(idHot, idServ, precio);
        }
    }
}
