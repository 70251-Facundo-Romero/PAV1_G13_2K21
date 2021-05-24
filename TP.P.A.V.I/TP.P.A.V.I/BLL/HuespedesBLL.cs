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
    class HuespedesBLL
    {
        public static DataTable ObtenerListadoHuespedes()
        {
            try
            {
                return HuespedesDAL.ObtenerListadoHuespedes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool VerificarExistenciaPasaportePais(int idPais, int pasaporte)
        {
            return HuespedesDAL.VerificarExistenciaPasaportePais(idPais, pasaporte);
        }

        public static Huesped ObtenerHuesped(int id)
        {
            return HuespedesDAL.ObtenerHuesped(id);
        }

        public static void AgregarHuesped(Huesped h)
        {
            try
            {
                HuespedesDAL.AgregarHuesped(h);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
