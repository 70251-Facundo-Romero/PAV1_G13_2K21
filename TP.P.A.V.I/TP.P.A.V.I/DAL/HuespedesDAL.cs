using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.P.A.V.I.DAL
{
    class HuespedesDAL : EntidadDAL
    {
        public static DataTable ObtenerListadoHuespedes()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"SELECT H.Id, H.Nombre as NombreHuesped, H.Apellido as ApellidoHuesped, P.Nombre as NombrePais, H.NroPasaporte, T.Nombre as NombreTarjeta, H.NroTarjetaDeCredito as NroTarjeta
                            FROM Huespedes H
                            JOIN Paises P ON H.Id_Pais = P.Id
                            JOIN Tarjetas T ON H.Id_Tarjeta = T.Id_Tarjeta";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
