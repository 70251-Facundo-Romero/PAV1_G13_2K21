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
    public class TarjetaBLL
    {
        public static DataTable ActualizarGrillaTarjeta()
        {
            try
            {
                return TarjetaDAL.ActualizarGrillaTarjeta();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool AgregarTarjeta(string NombreTarjeta, string Descripcion)
        {
            try
            {
                return TarjetaDAL.AgregarTarjeta(NombreTarjeta, Descripcion);
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal static Tarjeta ObtenerTarjeta(int id)
        {
            try
            {
                return TarjetaDAL.ObtenerTarjeta(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal static bool BorrarTarjeta(Tarjeta t)
        {
            try
            {
                return TarjetaDAL.BorrarTarjeta(t);
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal static bool ModificarTarjeta(Tarjeta t)
        {
            try
            {
                return TarjetaDAL.ModificarTarjeta(t);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
