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
    public static class InstalacionXHotelBLL
    {
        public static bool SaveInstalacionXHotel(InstalacionXHotel IxH)
        {
            InstalacionXHotelDAL.BeginTransaction();
            try
            {
                return InstalacionXHotelDAL.SaveInstalacionXHotel(IxH);
            }
            catch (Exception)
            {
                InstalacionXHotelDAL.RollbackTransaction();
                throw;
            }
            InstalacionXHotelDAL.CommitTransaction();
            
        }
        public static DataTable cargarGrilla(int Id)
        {
            return InstalacionXHotelDAL.cargarGrilla(Id);
        }

        public static InstalacionXHotel SelectById(int Id)
        {
            return InstalacionXHotelDAL.SelectById(Id);
        }

        public static void EliminarInstalacionXHotel(int Id)
        {
            InstalacionXHotelDAL.EliminarInstalacionXHotel(Id);
        }

        public static bool ModificarInstalacionXHotel(InstalacionXHotel IxH)
        {
            InstalacionXHotelDAL.BeginTransaction();
            try
            {
                return InstalacionXHotelDAL.ModificarInstalacionXHotel(IxH);
            }
            catch (Exception)
            {
                InstalacionXHotelDAL.RollbackTransaction();
                throw;
            }
            InstalacionXHotelDAL.CommitTransaction();
        }

        internal static bool VerificarExisteCombinacion(int IdHot, int IdInst)
        {
            return InstalacionXHotelDAL.VerfificarExixteCombinacion(IdHot, IdInst);
        }
    }
}
