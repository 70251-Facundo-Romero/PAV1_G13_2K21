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
    class CiudadBLL
    {
        public static DataTable ObtenerListadoCiudades()
        {
            return CiudadDAL.ObtenerListadoCiudades();
        }

        public static bool AgregarCiudadABD(Ciudad c)
        {
            return CiudadDAL.AgregarCiudadABD(c);
        }

        public static Ciudad ObtenerCiudad(int id)
        {
            return CiudadDAL.ObtenerCiudad(id);
        }

        public static bool ActualizarCiudadABD(Ciudad c)
        {
            return CiudadDAL.ActualizarCiudadABD(c);
        }

        public static bool BorrarCiudadABD(Ciudad c)
        {
            return CiudadDAL.BorrarCiudadABD(c);
        }
    }
}
