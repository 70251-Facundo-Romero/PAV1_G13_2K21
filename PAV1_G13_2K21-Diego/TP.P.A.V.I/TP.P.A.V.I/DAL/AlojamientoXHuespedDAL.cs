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
    class AlojamientoXHuespedDAL : EntidadDAL
    {

        public static DataTable ObtenerListadoAlojamientoXHuesped()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "SELECT * FROM AlojamientoXHuespedes";
                
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

        public static bool AgregarAlojamientoXHuespedABD(AlojamientoXHuespedes al)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "INSERT INTO AlojamientoXHuespedes(FechaAlojamiento,  Id_Habitacion, Id_Hotel,NroPasaporte,Id_Pais,FechaSalida) VALUES (@fechaAloj, @idHab,@idHotel,@nroPasaporte,@idPais,@fechaSalida)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaAloj", al.FechaAlojamiento);
                cmd.Parameters.AddWithValue("@idHab", al.Id_Habitacion);
                cmd.Parameters.AddWithValue("@idHotel", al.Id_Hotel);
                cmd.Parameters.AddWithValue("@idPais", al.Id_Pais);
                cmd.Parameters.AddWithValue("@fechaSalida", al.FechaSalida);
                cmd.Parameters.AddWithValue("@nroPasaporte", al.NroPasaporte);
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

        public static AlojamientoXHuespedes ObtenerAlojamientoPorHuesped(int id)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            AlojamientoXHuespedes al = new AlojamientoXHuespedes();
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "SELECT * FROM AlojamientoXHuespedes WHERE Id_AXH LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    al.Id_AXH = int.Parse(dr["Id_AXH"].ToString());
                    al.FechaAlojamiento = DateTime.Parse(dr["FechaAlojamiento"].ToString());
                    al.Id_Habitacion = int.Parse(dr["Id_Habitacion"].ToString());
                    al.Id_Hotel = int.Parse(dr["Id_Hotel"].ToString());
                    al.NroPasaporte =int.Parse( dr["NroPasaporte"].ToString());
                    al.Id_Pais = int.Parse(dr["Id_Pais"].ToString());
                    al.FechaSalida = DateTime.Parse(dr["FechaSalida"].ToString());
                    
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

            return al;
        }

        public static bool ActualizarAlojamientoXHuespedABD(AlojamientoXHuespedes al)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);



            try
            {
                string consulta = "UPDATE AlojamientoXHuespedes SET FechaAlojamiento = @fechaAloj,Id_Habitacion = @idHab,Id_Hotel = @idHotel,NroPasaporte = @nroPasaporte,Id_Pais = @idPais,FechaSalida = @fechaSalida WHERE Id_AXH LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", al.Id_AXH);
                cmd.Parameters.AddWithValue("@fechaAloj", al.FechaAlojamiento);
                cmd.Parameters.AddWithValue("@idHab", al.Id_Habitacion);
                cmd.Parameters.AddWithValue("@idHotel", al.Id_Hotel);
                cmd.Parameters.AddWithValue("@nroPasaporte", al.NroPasaporte);
                cmd.Parameters.AddWithValue("@idPais", al.Id_Pais);
                cmd.Parameters.AddWithValue("@fechaSalida", al.FechaSalida);
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

        public static bool BorrarAlojamientoXHuespedABD(AlojamientoXHuespedes al)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "DELETE FROM AlojamientoXHuespedes WHERE Id_AXH LIKE @Id_AXH";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_AXH", al.Id_AXH);
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
        public static DataTable ObtenerListadoPaises()
        {

            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Paises";
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
    }
}
    

