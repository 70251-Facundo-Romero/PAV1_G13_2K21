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
    class BarrioBLL
    {
        public static DataTable ObtenerListadoBarrios()
        {
            return BarrioDAL.ObtenerListadoBarrios();
        }

        public static Barrio ObtenerBarrio(int id)
        {
            return BarrioDAL.ObtenerBarrio(id);
        }
        
        public static bool AgregarBarrioABD(Barrio b)
        {
            return BarrioDAL.AgregarBarrioABD(b);
        }

        public static bool ActualizarBarrioABD(Barrio b)
        {
            return BarrioDAL.ActualizarBarrioABD(b);
        }

        public static bool BorrarBarrioABD(Barrio b)
        {
            BarrioDAL.BeginTransaction();
            try
            {
                return BarrioDAL.BorrarBarrioABD(b);
            }
            catch (Exception)
            {
                BarrioDAL.RollbackTransaction();
                throw;
            }
            BarrioDAL.CommitTransaction();
        }

        internal static DataTable ObtenerBarriosXCiudades()
        {
            try
            {
                BarrioDAL.ObtenerBarriosXCiudades();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
