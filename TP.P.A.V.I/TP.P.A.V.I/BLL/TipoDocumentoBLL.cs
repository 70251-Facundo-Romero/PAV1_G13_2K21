using System;
using System.Data;
using TP.P.A.V.I.DAL;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I.BLL
{
    public class TipoDocumentoBLL
    {
        public static DataTable GetListadoTipoDoc()
        {
            try
            {
                return TipoDocumentoDAL.GetListadoTipoDoc();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertTipoDoc(TipoDocumento model)
        {
            try
            {
                return TipoDocumentoDAL.InsertTipoDoc(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static TipoDocumento GetById(int id)
        {
            try
            {
                return TipoDocumentoDAL.ObtenerTipoPorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool ActualizarTipo(TipoDocumento model)
        {
            try
            {
                return TipoDocumentoDAL.ActualizarTipo(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool BorrarTipoDoc(TipoDocumento model)
        {
            try
            {
                return TipoDocumentoDAL.BorrarTipoDoc(model);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
