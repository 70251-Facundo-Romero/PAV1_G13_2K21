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
    public class FacturaBLL
    {
        public static Factura ObtenerFactura(string pasaporte)
        {
            try
            {
                return FacturaDAL.ObtenerFactura(pasaporte);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Factura> ObenerDetalles(DateTime fechaAloj, string pasaporte, int idHot)
        {
            try
            {
                return FacturaDAL.ObenerDetalles(fechaAloj, pasaporte, idHot);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int MaxNum()
        {
            try
            {
                return FacturaDAL.MaxNum();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool AgregarFactura(Factura f, List<Factura> dt)
        {
            try
            {
                return FacturaDAL.AgregarFactura(f, dt);
            }
            catch (Exception EX)
            {

                throw;
            }
        }
    }
}
