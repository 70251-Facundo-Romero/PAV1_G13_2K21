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
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT AxH.IdAXH, Hu.NroPasaporte as NroPasaporte, P.Nombre as NombrePais, Hot.Nombre as NombreHotel, Hab.Nombre as NombreHabitacion, AxH.FechaAlojamiento, AxH.FechaSalida 
                                        FROM AlojamientoXHotel AxH
                                        JOIN HabitacionXHotel HxH ON AxH.IdHabXHotel = HxH.IdHabitacionXHotel
                                        JOIN Hoteles Hot ON HxH.IdHotel = Hot.Id
                                        JOIN Habitaciones Hab ON HxH.IdHabitacion = Hab.Id
                                        JOIN Huespedes Hu ON AXH.IdHuesped = Hu.Id 
                                        JOIN Paises P ON Hu.Id_Pais = P.Id", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter dr = new SqlDataAdapter(cmd))
                        {
                            DataTable tabla = new DataTable();
                            dr.Fill(tabla);
                            return tabla;

                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
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
                string consulta = "INSERT INTO [dbo].[AlojamientoXHotel]" +
                    "           ([FechaAlojamiento]" +
                    "           ,[IdHuesped]" +
                    "           ,[FechaSalida]" +
                    "           ,[IdHabXHotel])" +
                    "     VALUES" +
                    "           (@fechaAloj" +
                    "           ,@IdHuesped" +
                    "          ,@fechaSalida" +
                    "           ,@IdHabXHot)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaAloj", al.FechaAlojamiento);
                cmd.Parameters.AddWithValue("@IdHabXHot", al.Id_HabXHot);
                cmd.Parameters.AddWithValue("@fechaSalida", al.FechaSalida);
                cmd.Parameters.AddWithValue("@IdHuesped", al.NroPasaporte);
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


        public static bool ValiadarPasaporte(int NroPasaporte)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Huespedes WHERE NroPasaporte = @Pasaporte", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Pasaporte", NroPasaporte);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                resultado = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            return resultado;
        }

        public static int BuscarIdHabitacionXHotel(int IdHab, int IdHot)
        {
            int num = 0;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT IdHabitacionXHotel FROM HabitacionXHotel WHERE IdHotel = @IdHot AND IdHabitacion = @IdHab", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@IdHot", IdHot);
                    cmd.Parameters.AddWithValue("@IdHab", IdHab);

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

        public static int BuscarIdHuesped(int NroPasaporte)
        {
            int num = 0;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT Id FROM Huespedes WHERE NroPasaporte = @Pasaporte", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Pasaporte", NroPasaporte);

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

        public static AlojamientoXHuespedes BuscarAlojamiento(int IdAlojamiento)
        {
            AlojamientoXHuespedes a = new AlojamientoXHuespedes();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT AxH.IdAXH as IdAXH, Hu.NroPasaporte as NroPasaporte, P.Id as NombrePais, Hot.Id as NombreHotel, Hab.Id as NombreHabitacion, AxH.FechaAlojamiento as FechaAlojamiento, AxH.FechaSalida as FechaSalida 
                                        FROM AlojamientoXHotel AxH
                                        JOIN HabitacionXHotel HxH ON AxH.IdHabXHotel = HxH.IdHabitacionXHotel
                                        JOIN Hoteles Hot ON HxH.IdHotel = Hot.Id
                                        JOIN Habitaciones Hab ON HxH.IdHabitacion = Hab.Id
                                        JOIN Huespedes Hu ON AXH.IdHuesped = Hu.Id 
                                        JOIN Paises P ON Hu.Id_Pais = P.Id 
                                        WHERE AXH.IdAXH = @Id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Id", IdAlojamiento);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {

                            a.Id_AXH = int.Parse(dr["IdAXH"].ToString());
                            a.NroPasaporte = int.Parse(dr["NroPasaporte"].ToString());
                            a.Id_Pais = int.Parse(dr["NombrePais"].ToString());
                            a.Id_Hotel = int.Parse(dr["NombreHotel"].ToString());
                            a.Id_Habitacion = int.Parse(dr["NombreHabitacion"].ToString());
                            a.FechaAlojamiento = DateTime.Parse(dr["FechaAlojamiento"].ToString());
                            a.FechaSalida = DateTime.Parse(dr["FechaSalida"].ToString());

                        }
                    }
                }
                catch (Exception ex)
                {

                    throw (ex);
                }
            }
            return a;
        }

       

        public static bool ActualizarAlojamientoXHuespedABD(AlojamientoXHuespedes al)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);



            try
            {
                string consulta = "UPDATE [dbo].[AlojamientoXHotel]" +
                    "   SET[FechaAlojamiento] = @fechaAloj" +
                    "      ,[IdHuesped] = @nroPasaporte" +
                    "      ,[FechaSalida] = @fechaSalida" +
                    "      ,[IdHabXHotel] = @IdHabXHot" +
                    "  WHERE IdAXH = @id ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", al.Id_AXH);
                cmd.Parameters.AddWithValue("@fechaAloj", al.FechaAlojamiento);
                cmd.Parameters.AddWithValue("@IdHabXHot", al.Id_HabXHot);
                cmd.Parameters.AddWithValue("@nroPasaporte", al.NroPasaporte);
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


