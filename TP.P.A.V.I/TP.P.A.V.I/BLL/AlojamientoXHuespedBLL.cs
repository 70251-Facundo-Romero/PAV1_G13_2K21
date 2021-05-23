using System;
using System.Data;
using TP.P.A.V.I.DAL;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I.BLL
{
    class AlojamientoXHuespedBLL
    {
        public static bool ValiadarPasaporte(int NroPasaporte)
        {
            return AlojamientoXHuespedDAL.ValiadarPasaporte(NroPasaporte);
        }

        public static int BuscarIdHabitacionXHotel(int IdHab, int IdHot)
        {
            return AlojamientoXHuespedDAL.BuscarIdHabitacionXHotel(IdHab, IdHot);
        }

        public static AlojamientoXHuespedes BuscarAlojamiento(int IdAlojamiento)
        {
            return AlojamientoXHuespedDAL.BuscarAlojamiento(IdAlojamiento);
        }

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

        public static int BuscarIdHuesped(int NroPasaporte)
        {
            return AlojamientoXHuespedDAL.BuscarIdHuesped(NroPasaporte);
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
