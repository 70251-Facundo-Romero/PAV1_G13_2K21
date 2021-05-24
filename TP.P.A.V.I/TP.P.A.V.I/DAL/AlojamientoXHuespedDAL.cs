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
                string consulta = @"SELECT AxH.IdAXH, Hu.NroPasaporte as NroPasaporte, P.Nombre as NombrePais, Hot.Nombre as NombreHotel, Hab.Nombre as NombreHabitacion, AxH.FechaAlojamiento, AxH.FechaSalida 
                                        FROM AlojamientoXHotel AxH
                                        JOIN HabitacionXHotel HxH ON AxH.IdHabXHotel = HxH.IdHabitacionXHotel
                                        JOIN Hoteles Hot ON HxH.IdHotel = Hot.Id
                                        JOIN Habitaciones Hab ON HxH.IdHabitacion = Hab.Id
                                        JOIN Huespedes Hu ON AXH.IdHuesped = Hu.Id
                                        JOIN Paises P ON Hu.Id_Pais = P.Id";
                
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

        public static bool AgregarAlojamientoXHuespedABD(AlojamientoXHuespedes al)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"INSERT INTO [dbo].[AlojamientoXHotel]
           (FechaAlojamiento
           ,IdHuesped
           ,FechaSalida
           ,IdHabXHotel)
     VALUES
           (@fechaAloj
           ,@idHuesped
           ,@fechaSalida
           ,@IdHxH)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaAloj", al.FechaAlojamiento);
                cmd.Parameters.AddWithValue("@idHxH", al.IdHabXHotel);
                cmd.Parameters.AddWithValue("@idHuesped", al.IdHuesped);
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

        public static AlojamientoXHuespedes ObtenerAlojamientoPorHuesped(int id)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            AlojamientoXHuespedes al = new AlojamientoXHuespedes();
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"SELECT AxH.*, Hu.NroPasaporte as NroPasaporte, P.Id as Id_Pais, Hot.Id as Id_Hotel, Hab.Id as Id_Habitacion 
                                        FROM AlojamientoXHotel AxH
                                        JOIN HabitacionXHotel HxH ON AxH.IdHabXHotel = HxH.IdHabitacionXHotel
                                        JOIN Hoteles Hot ON HxH.IdHotel = Hot.Id
                                        JOIN Habitaciones Hab ON HxH.IdHabitacion = Hab.Id
                                        JOIN Huespedes Hu ON AXH.IdHuesped = Hu.Id
                                        JOIN Paises P ON Hu.Id_Pais = P.Id
                                        WHERE IdAXH = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    al.Id_AXH = int.Parse(dr["IdAXH"].ToString());
                    al.FechaAlojamiento = DateTime.Parse(dr["FechaAlojamiento"].ToString());
                    al.Id_Habitacion = int.Parse(dr["Id_Habitacion"].ToString());
                    al.IdHabXHotel = int.Parse(dr["IdHabXHotel"].ToString());
                    al.IdHuesped = int.Parse(dr["IdHuesped"].ToString());
                    al.Id_Hotel = int.Parse(dr["Id_Hotel"].ToString());
                    al.NroPasaporte =int.Parse( dr["NroPasaporte"].ToString());
                    al.Id_Pais = int.Parse(dr["Id_Pais"].ToString());
                    al.FechaSalida = DateTime.Parse(dr["FechaSalida"].ToString());
                    
                }
            }
            catch (Exception ex)
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
                string consulta = @"UPDATE[dbo].[AlojamientoXHotel]
   SET FechaAlojamiento = @fechaAloj
      ,IdHuesped = @idHuesped
      ,FechaSalida = @fechaSalida
      ,IdHabXHotel = @idHabxHot
  WHERE IdAXH = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idHuesped", al.IdHuesped);
                cmd.Parameters.AddWithValue("@idHabXHot", al.IdHabXHotel);
                cmd.Parameters.AddWithValue("@id", al.Id_AXH);
                cmd.Parameters.AddWithValue("@fechaSalida", al.FechaSalida);
                cmd.Parameters.AddWithValue("@fechaAloj", al.FechaAlojamiento);
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

        public static bool ExistePasaporte(int pasaporte)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM Huespedes WHERE NroPasaporte = @pasaporte ", con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@pasaporte", pasaporte);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            resultado = true;

                        }
                    }
                }
                catch (Exception ex)
                {

                    throw (ex);
                }
            }
            return resultado;
        }

        public static bool ExisteHabXHotel(int idHot, int idHab)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM HabitacionXHotel WHERE IdHotel = @idHot AND IdHabitacion = @idHab ", con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idHot", idHot);
                    cmd.Parameters.AddWithValue("@idHab", idHab);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            resultado = true;

                        }
                    }
                }
                catch (Exception ex)
                {

                    throw (ex);
                }
            }
            return resultado;
        }

        public static int TraerHabXHotel(int idHot, int idHab)
        {
            int num = 0;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT IdHabitacionXHotel FROM HabitacionXHotel WHERE IdHotel = @idHot AND IdHabitacion = @idHab ", con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idHot", idHot);
                    cmd.Parameters.AddWithValue("@idHab", idHab);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            num = int.Parse(dr["IdHabitacionXHotel"].ToString());

                        }
                    }
                }
                catch (Exception ex)
                {

                    throw (ex);
                }
            }
            return num;
        }

        public static int TraerPasaporte(int pasaporte)
        {
            int num = 0;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT Id FROM Huespedes WHERE NroPasaporte = @pasaporte ", con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@pasaporte", pasaporte);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            num = int.Parse(dr["Id"].ToString());

                        }
                    }
                }
                catch (Exception ex)
                {

                    throw (ex);
                }
            }
            return num;
        }

        public static bool BorrarAlojamientoXHuespedABD(AlojamientoXHuespedes al)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "DELETE FROM AlojamientoXHotel WHERE IdAXH LIKE @Id_AXH";

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
    

