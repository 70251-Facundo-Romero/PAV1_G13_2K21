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
        public static DataTable ObtenerListadoPaises()
        {
            try
            {
                return PaisDAL.ObtenerListadoPaises();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public static bool AgregarPaisABD(Pais p)
        {
            try
            {
                return PaisDAL.AgregarPaisABD(p);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Pais ObtenerPais(int id)
        {
            try
            {
                return PaisDAL.ObtenerPais(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool ActualizarPaisABD(Pais p)
        {
            try
            {
                return PaisDAL.ActualizarPaisABD(p);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool BorrarPaisABD(Pais p)
        {
            try
            {
                return PaisDAL.BorrarPaisABD(p);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
