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
    class EmpleadosBLL
    {
        public static DataTable ObtenerListadoEmpleados()
        {
            try
            {
                return EmpleadosDAL.ObtenerListadoEmpleados();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static bool AgregarEmpleadoABD(Empleado em)
        {
            try
            {
                return EmpleadosDAL.AgregarEmpleadoABD(em);
            }
            catch (Exception ex)
            {
                throw;

            }
        }

        public static Empleado ObtenerEmpleado(string id)
        {
            try
            {
                return EmpleadosDAL.ObtenerEmpleado(id);
            }
            catch (Exception)
            {
                throw;

            }
        }

        public static bool ActualizarEmpleadoABD(Empleado em)
        {
            try
            {
                return EmpleadosDAL.ActualizarEmpleadoABD(em);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool BorrarEmpleadoABD(Empleado em)
        {
            try
            {
                return EmpleadosDAL.BorrarEmpleadoABD(em);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable ObtenerListadoPuestos()

        {
            try
            {
                return EmpleadosDAL.ObtenerListadoPuestos();
            }
            catch (Exception)
            {

                throw;
            }




        }

        public static DataTable ObtenerListadoTipoDocumentos()
        {
            try
            {
                return EmpleadosDAL.ObtenerListadoTipoDocumentos();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static DataTable ObtenerListadoHoteles()
        {
            try
            {
                return EmpleadosDAL.ObtenerListadoHoteles();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }


}

