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
    class AlojamientoXHuespedBLL
    {
        public static DataTable ObtenerListadoAlojamientoXHuesped()
        {
            try
            {
                return AlojamientoXHuespedDAL.ObtenerListadoAlojamientoXHuesped();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static bool AgregarAlojamientoXHuespedABD(AlojamientoXHuespedes al)
        {
            try
            {
                return AlojamientoXHuespedDAL.AgregarAlojamientoXHuespedABD(al);
            }
            catch (Exception ex)
            {
                throw;

            }
        }

        public static AlojamientoXHuespedes ObtenerAlojamientoXHuesped(int id)
        {
            try
            {
                return AlojamientoXHuespedDAL.ObtenerAlojamientoPorHuesped(id);
            }
            catch (Exception)
            {
                throw;

            }
        }

        public static bool ExisteHabXHotel(int idHot, int idHab)
        {
            return AlojamientoXHuespedDAL.ExisteHabXHotel(idHot, idHab);
        }

        public static int TraerHabXHotel(int idHot, int idHab)
        {
            return AlojamientoXHuespedDAL.TraerHabXHotel(idHot, idHab);
        }

        public static int TraerPasaporte(int pasaporte)
        {
            return AlojamientoXHuespedDAL.TraerPasaporte(pasaporte);
        }

        public static bool ExistePasaporte(int pasaporte)
        {
            return AlojamientoXHuespedDAL.ExistePasaporte(pasaporte);
        }

        public static bool ActualizarAlojamientoXHuespedABD(AlojamientoXHuespedes al)
        {
            try
            {
                return AlojamientoXHuespedDAL.ActualizarAlojamientoXHuespedABD(al);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool BorrarAlojamientoXHuespedABD(AlojamientoXHuespedes al)
        {
            try
            {
                return AlojamientoXHuespedDAL.BorrarAlojamientoXHuespedABD(al);
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
                return AlojamientoXHuespedDAL.ObtenerListadoHoteles();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static DataTable ObtenerListadoPaises()
        {
            try
            {
                return AlojamientoXHuespedDAL.ObtenerListadoPaises();
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
                return AlojamientoXHuespedDAL.ObtenerListadoHabitaciones();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
