using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.P.A.V.I.DAL;

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
    }
}
