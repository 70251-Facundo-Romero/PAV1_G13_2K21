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
    class InstalacionXHuespedBLL
    {
        public static bool AgregarInstalacionXHuesped(InstalacionXHuespedes ih)
        {
            try
            {
                return InstalacionXHuespedDAL.AgregarInstalacionXHuesped(ih);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static bool ActualizarInstalacionXHuesped(InstalacionXHuespedes ih)
        {
            try
            {
                return InstalacionXHuespedDAL.ActualizarInstalacionXHuesped(ih);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static bool BorrarInstalacionXHuesped(InstalacionXHuespedes ih)
        {
            try
            {
                return InstalacionXHuespedDAL.BorrarInstalacionXHuesped(ih);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static DataTable ObtenerListadoInstalacionXHuesped()
        {
            try
            {
                return InstalacionXHuespedDAL.ObtenerListadoInstalacionXHuesped();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static InstalacionXHuespedes ObtenerInstalacionXHuesped(int id)
        {
            try
            {
                return InstalacionXHuespedDAL.ObtenerInstalacionXHuesped(id);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static DataTable ObtenerListadoHoteles()
        {
            try
            {
                return InstalacionXHuespedDAL.ObtenerListadoHoteles();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static DataTable ObtenerListadoHabitaciones()
        {
            try
            {
                return InstalacionXHuespedDAL.ObtenerListadoHabitaciones();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static DataTable ObtenerListadoInstalaciones()
        {
            try
            {
                return InstalacionXHuespedDAL.ObtenerListadoInstalaciones();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
