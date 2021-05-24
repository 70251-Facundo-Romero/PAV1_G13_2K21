using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.P.A.V.I.Entities;

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

        public static void AgregarHuesped(Huesped h)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"INSERT INTO [dbo].[Huespedes]
                    ([NroPasaporte]
                    ,[Id_Pais]
                    ,[Apellido]
                    ,[Nombre]
                    ,[NroTarjetaDeCredito]
                    ,[Id_Tarjeta])
            VALUES
                    (@pasaporte
                    ,@idPais
                    ,@ape
                    ,@nom
                    ,@nroTarjeta
                    ,@idTarjeta";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPais", h.IdPaisHuesped);
                cmd.Parameters.AddWithValue("@pasaporte", h.NroPasaporteHuesped);
                cmd.Parameters.AddWithValue("@ape", h.ApellidoHuesped);
                cmd.Parameters.AddWithValue("@nom", h.NombreHuesped);
                cmd.Parameters.AddWithValue("@nroTarjeta", h.NroTarjetaHuesped);
                cmd.Parameters.AddWithValue("@idTarjeta", h.IdTarjetaHuesped);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                con.Open();
                cmd.Connection = con;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public static bool VerificarExistenciaPasaportePais(int idPais, int pasaporte)
        {
            bool resultado = false;
            
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"SELECT * FROM Huespedes WHERE Id_Pais = @idPais AND NroPasaporte = @pasaporte";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPais", idPais);
                cmd.Parameters.AddWithValue("@pasaporte", pasaporte);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                con.Open();
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    resultado = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return resultado;
        }

        public static Huesped ObtenerHuesped(int id)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            Huesped h = new Huesped();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"SELECT * FROM Huespedes WHERE Id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                con.Open();
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    h.IdHuesped = int.Parse(dr["Id"].ToString());
                    h.NombreHuesped = dr["Nombre"].ToString();
                    h.ApellidoHuesped = dr["Apellido"].ToString();
                    h.IdPaisHuesped = int.Parse(dr["Id_Pais"].ToString());
                    h.NroPasaporteHuesped = int.Parse(dr["NroPasaporte"].ToString());
                    h.IdTarjetaHuesped = int.Parse(dr["Id_Tarjeta"].ToString());
                    h.NroTarjetaHuesped = int.Parse(dr["NroTarjetaDeCredito"].ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return h;
        }
    }
}
