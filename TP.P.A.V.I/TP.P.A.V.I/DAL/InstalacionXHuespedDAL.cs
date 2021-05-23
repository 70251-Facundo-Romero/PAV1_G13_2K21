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
                string consulta = "INSERT INTO [dbo].[InstalacionXHuesped]" +
                    "           ([FechaUso]" +
                    "           ,[IdAlojamiento]" +
                    "           ,[IdInstXHotel])" +
                    "     VALUES" +
                    "           (@fechaUso" +
                    "           ,@idAloj" +
                    "           ,@IdInXHot)";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdInXHot", ih.IdInstXHotel);
                cmd.Parameters.AddWithValue("@idAloj", ih.IdAlojamiento);
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
                cmd.Parameters.AddWithValue("@id", ih.Id_IXH);
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
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT IxH.Id_IXH as Id_IXH, Hot.Nombre as NombreHotel, Hab.Nombre as NombreHabitacion, I.Nombre as NombreInstalacion, A.FechaAlojamiento as FechaAlojamiento, IxH.FechaUso as FechaUso
                                    FROM InstalacionXHuesped IxH 
                                    JOIN AlojamientoXHotel A ON IxH.IdAlojamiento = A.IdAXH
                                    JOIN HabitacionXHotel HxH  ON A.IdHabXHotel = HxH.IdHabitacionXHotel
                                    JOIN Hoteles Hot ON HxH.IdHotel = Hot.Id
                                    JOIN Habitaciones Hab ON HxH.IdHabitacion = Hab.Id
                                    JOIN InstalacionXHotel InxH ON IxH.IdInstXHotel = InxH.IdInstalacionXHotel
                                    JOIN Instalaciones I ON InxH.IdInstalacion = I.Id", con))
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

        public static int BuscarIdInstalacionXHotel(int IdIns, int IdHot)
        {
            int num = 0;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT IdInstalacionXHotel FROM InstalacionXHotel WHERE IdHotel = @IdHot AND IdInstalacion = @IdIns", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@IdHot", IdHot);
                    cmd.Parameters.AddWithValue("@IdIns", IdIns);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {

                            num = int.Parse(dr["IdInstalacionXHotel"].ToString());

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

        public static bool ValiadarFecha(DateTime fecha)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM AlojamientoXHotel WHERE FechaAlojamiento = @Fecha", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Fecha", fecha);
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

        public static bool ValiadarAlojamiento(int Id, DateTime fecha)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM AlojamientoXHotel WHERE IdHabXHotel = @Id AND FechaAlojamiento = @Fecha", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Fecha", fecha);
                        cmd.Parameters.AddWithValue("@Id", Id);
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

        public static bool ValiadarHabitacionXHotel(int IdHabXHot)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM HabitacionXHotel WHERE IdHabitacionXHotel = @IdHabXHot", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@IdHabXHot", IdHabXHot);
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

        public static int BuscarAlojamiento(int IdHabXHot, DateTime fecha)
        {
            int num = 0;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT IdAXH FROM AlojamientoXHotel WHERE IdHabXHotel = @IdHabXHot AND FechaAlojamiento = @fecha", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@IdHabXHot", IdHabXHot);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {

                            num = int.Parse(dr["IdAXH"].ToString());

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

        public static InstalacionXHuespedes ObtenerInstalacionXHuesped(int id)
        {
            InstalacionXHuespedes a = new InstalacionXHuespedes();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT IxH.Id_IXH as Id_IXH, Hot.Id as Id_Hotel, Hab.Id as Id_Habitacion, I.Id as Id_Instalacion, A.FechaAlojamiento as FechaAlojamiento, IxH.FechaUso as FechaUso
                                    FROM InstalacionXHuesped IxH 
                                    JOIN AlojamientoXHotel A ON IxH.IdAlojamiento = A.IdAXH
                                    JOIN HabitacionXHotel HxH  ON A.IdHabXHotel = HxH.IdHabitacionXHotel
                                    JOIN Hoteles Hot ON HxH.IdHotel = Hot.Id
                                    JOIN Habitaciones Hab ON HxH.IdHabitacion = Hab.Id
                                    JOIN InstalacionXHotel InxH ON IxH.IdInstXHotel = InxH.IdInstalacionXHotel
                                    JOIN Instalaciones I ON InxH.IdInstalacion = I.Id 
                                    WHERE IxH.Id_IXH = @Id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null && dr.Read())
                        {
                            a.Id_IXH = int.Parse(dr["Id_IXH"].ToString());
                            a.FechaAlojamiento = DateTime.Parse(dr["FechaAlojamiento"].ToString());
                            a.Id_Habitacion = int.Parse(dr["Id_Habitacion"].ToString());
                            a.Id_Hotel = int.Parse(dr["Id_Hotel"].ToString());
                            a.Id_Instalacion = int.Parse(dr["Id_Instalacion"].ToString());
                            a.FechaUso = DateTime.Parse(dr["FechaUso"].ToString());
                            //ih.HoraUso = DateTime.Parse(dr["HoraUso"].ToString());

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
