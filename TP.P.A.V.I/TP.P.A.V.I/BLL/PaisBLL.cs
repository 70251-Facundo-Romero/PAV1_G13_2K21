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
            return PaisDAL.ObtenerListadoPaises();
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
            return PaisDAL.BorrarPaisABD(p);
        }
    }
}
