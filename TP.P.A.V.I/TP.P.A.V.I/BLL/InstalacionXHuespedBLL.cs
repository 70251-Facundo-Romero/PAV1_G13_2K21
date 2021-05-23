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

        public static int BuscarIdHabitacionXHotel(int IdHab, int IdHot)
        {
            return InstalacionXHuespedDAL.BuscarIdHabitacionXHotel(IdHab, IdHot);
        }

        public static bool ValiadarHabitacionXHotel(int IdHabXHot)
        {
            return InstalacionXHuespedDAL.ValiadarHabitacionXHotel(IdHabXHot);
        }

        public static int BuscarAlojamiento(int IdHabXHot, DateTime fecha)
        {
            return InstalacionXHuespedDAL.BuscarAlojamiento(IdHabXHot, fecha);
        }

            public static bool ValiadarFecha(DateTime fecha)
        {
            return InstalacionXHuespedDAL.ValiadarFecha(fecha);
        }

        public static bool ValiadarAlojamiento(int Id, DateTime fecha)
        {
            return InstalacionXHuespedDAL.ValiadarAlojamiento(Id, fecha);
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


        public static int BuscarIdInstalacionXHotel(int IdIns, int IdHot)
        {
            return InstalacionXHuespedDAL.BuscarIdInstalacionXHotel(IdIns, IdHot);
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
