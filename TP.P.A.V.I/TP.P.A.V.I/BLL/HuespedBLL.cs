using System;
using System.Data;
using TP.P.A.V.I.DAL;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I.BLL
{
    public class HuespedBLL
    {
        public static DataTable GetListadoHuespedes()
        {
            try
            {
                return HuespedDAL.GetListadoHuespedes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertHuesped(Huesped model)
        {
            try
            {
                return HuespedDAL.InsertHuesped(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Huesped GetByPasaport(int id)
        {
            try
            {
                return HuespedDAL.ObtenerHuespedPorPasaporte(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool ActualizarHuesped(Huesped model)
        {
            try
            {
                return HuespedDAL.ActualizarHuesped(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteHuesped(Huesped model)
        {
            HuespedDAL.BeginTransaction();
            try
            {
                return HuespedDAL.BorrarHuesped(model);
            }
            catch (Exception)
            {
                HuespedDAL.RollbackTransaction();
                throw;
            }
            HuespedDAL.CommitTransaction();
        }
    }
}
