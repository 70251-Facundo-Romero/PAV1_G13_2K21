using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.P.A.V.I.DAL;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I.BLL
{ //pasa mano
    class PuestoDeTrabajoBLL
    {
        public static DataTable ObtenerEstadisticaPdt()
        {
            return PuestoDeTrabajoDAL.ObtenerEstadisticasPdt();
        }

        public static DataTable ObtenerListadoPdt()
        {
            return PuestoDeTrabajoDAL.ObtenerListaPdT();
        }
        public static DataTable ObtenerListaPuesto()
        {
            try
            {
                return PuestoDeTrabajoDAL.ObtenerListaPdT();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static bool AgregarPuestoABD(PuestoTrabajo pdt)
        {
            try
            {
                return PuestoDeTrabajoDAL.AgregarPuestoABD(pdt);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static PuestoTrabajo ObtenerPuesto(int id)
        {
            try
            {
                return PuestoDeTrabajoDAL.ObtenerPuesto(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool ActualizarPuestoABD(PuestoTrabajo pdt)
        {
            try
            {
                return PuestoDeTrabajoDAL.ActualizarPuestoABD(pdt);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool EliminarPuestoABD(PuestoTrabajo pdt)
        {
            PuestoDeTrabajoDAL.BeginTransaction();
            try
            {
                return PuestoDeTrabajoDAL.EliminarPuestoABD(pdt);
            }
            catch (Exception)
            {
                PuestoDeTrabajoDAL.RollbackTransaction();
                throw;
            }
            PuestoDeTrabajoDAL.CommitTransaction();
        }
    }
}
