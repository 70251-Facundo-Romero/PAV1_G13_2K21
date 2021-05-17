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
    class InstalacionXHuespedDAL : EntidadDAL
    {
        public static bool AgregarInstalacionXHuesped(InstalacionXHuespedes ih)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "INSERT INTO InstalacionXHuesped(FechaAlojamiento,Id_Habitacion,Id_Hotel,Id_Instalacion,FechaUso) VALUES (@fechaAloj,@idHab,@idHotel,@idInst,@fechaUso)";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaAloj", ih.FechaAlojamiento);
                cmd.Parameters.AddWithValue("@idHab", ih.Id_Habitacion);
                cmd.Parameters.AddWithValue("@idHotel", ih.Id_Hotel);
                cmd.Parameters.AddWithValue("@idInst", ih.Id_Instalacion);
                cmd.Parameters.AddWithValue("@fechaUso", ih.FechaUso);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static bool ActualizarInstalacionXHuesped(InstalacionXHuespedes ih)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);



            try
            {
                string consulta = "UPDATE InstalacionXHuesped SET FechaAlojamiento = @fechaAloj,Id_Habitacion = @idHab,Id_Hotel = @idHotel,Id_Instalacion = @idInst,FechaUso = @fechaUso WHERE Id_IXH LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", ih.Id_IXH);
                cmd.Parameters.AddWithValue("@fechaAloj",ih.FechaAlojamiento );
                cmd.Parameters.AddWithValue("@idHab", ih.Id_Habitacion);
                cmd.Parameters.AddWithValue("@idHotel", ih.Id_Hotel);
                cmd.Parameters.AddWithValue("@idInst", ih.Id_Instalacion );
                cmd.Parameters.AddWithValue("@fechaUso", ih.FechaUso);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static bool BorrarInstalacionXHuesped(InstalacionXHuespedes ih)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "DELETE FROM InstalacionXHuesped WHERE Id_IXH LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",ih.Id_IXH );
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }
        public static DataTable ObtenerListadoInstalacionXHuesped()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "SELECT * FROM InstalacionXHuesped";

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
        public static InstalacionXHuespedes ObtenerInstalacionXHuesped(int id)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            InstalacionXHuespedes ih = new InstalacionXHuespedes();
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "SELECT * FROM InstalacionXHuesped WHERE Id_IXH LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    ih.Id_IXH = int.Parse(dr["Id_IXH"].ToString());
                    ih.FechaAlojamiento = DateTime.Parse(dr["FechaAlojamiento"].ToString());
                    ih.Id_Habitacion = int.Parse(dr["Id_Habitacion"].ToString());
                    ih.Id_Hotel = int.Parse(dr["Id_Hotel"].ToString());
                    ih.Id_Instalacion = int.Parse(dr["Id_Instalacion"].ToString());
                    ih.FechaUso = DateTime.Parse(dr["FechaUso"].ToString());
                    //ih.HoraUso = DateTime.Parse(dr["HoraUso"].ToString());

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return ih;
        }
        public static DataTable ObtenerListadoHoteles()
        {

            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Hoteles";
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
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static DataTable ObtenerListadoHabitaciones()
        {

            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Habitaciones";
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
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static DataTable ObtenerListadoInstalaciones()
        {

            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Instalaciones";
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
            catch (Exception ex)
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
