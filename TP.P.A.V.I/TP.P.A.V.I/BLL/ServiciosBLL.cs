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
    class ServiciosBLL
    {
        public static DataTable ObtenerListaServicios()
        {
            try
            {
                return ServiciosDAL.ObtenerListaServ();
            }
            catch (Exception)
            {

                throw;
            }
        }
     

        public static Servicio ObtenerServicio(int id)
        {
            try
            {
                return ServiciosDAL.ObtenerServicio(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool AgregarServicioABD(Servicio ser)
        {
            try
            {
                return ServiciosDAL.AgregarServicioABD(ser);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static bool ActualizarServicioABD(Servicio ser)
        {
            try
            {
                return ServiciosDAL.ActualizarServicioABD(ser);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static bool EliminarServicioABD(Servicio ser)
        {
            try
            {
                return ServiciosDAL.EliminarServicioABD(ser);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
