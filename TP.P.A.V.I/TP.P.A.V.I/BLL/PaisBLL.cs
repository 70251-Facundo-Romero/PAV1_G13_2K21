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
    class PaisBLL
    {
        public static DataTable ObtenerEstadisticaPais()
        {
            return PaisDAL.ObtenerEstadisticasPais();
        }

        public static DataTable ObtenerListadoPaises()
        {
            return PaisDAL.ObtenerListadoPaises();
        }
       
        public static DataTable ObtenerHuespedesxPais()
        {
            return PaisDAL.ObtenerHuespedesxPais();
        }

        public static bool AgregarPaisABD(Pais p)
        {
            return PaisDAL.AgregarPaisABD(p);
        }

        public static Pais ObtenerPais(int id)
        {
            return PaisDAL.ObtenerPais(id);
        }

        public static bool ActualizarPaisABD(Pais p)
        {
            return PaisDAL.ActualizarPaisABD(p);
        }

        public static bool BorrarPaisABD(Pais p)
        {
            PaisDAL.BeginTransaction();
            try
            {
                return PaisDAL.BorrarPaisABD(p);
            }
            catch (Exception)
            {
                PaisDAL.RollbackTransaction();
                throw;
            }
            PaisDAL.CommitTransaction();
        }
    }
}
