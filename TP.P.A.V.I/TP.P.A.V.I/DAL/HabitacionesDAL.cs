using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.P.A.V.I.DAL
{
    class HabitacionesDAL : EntidadDAL
    {
        public static bool ValidarHabitaciones(string Habitacion, string Descripcion)
        {
            bool rta = false;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Habitaciones WHERE Nombre = @Nombre AND Descripcion = @Descripcion", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Nombre", Habitacion);
                        cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                rta = true;
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

            return rta;
        }
        public static bool InsertarHabitaciones(string Habitacion, string Descripcion)
        {
            bool rta = false;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Habitaciones (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Nombre", Habitacion);
                        cmd.Parameters.AddWithValue("@Descripcion", Descripcion);

                        cmd.ExecuteNonQuery();
                        rta = true;
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
                return rta;
            }
        }
        public static bool DeleteHabitaciones(string Habitacion)
        {
            bool rta = false;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"DELETE FROM Habitaciones WHERE Nombre = @Nombre", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Nombre", Habitacion);

                        cmd.ExecuteNonQuery();
                        rta = true;
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
                return rta;
            }
        }
        public static DataTable cargarGrilla()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Habitaciones", con))
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
        public static Dictionary<string, string> ObtenerHabitaciones(string ID)
        {
            Dictionary<string, string> rta = new Dictionary<string, string>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Habitaciones WHERE Id = @ID", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@ID", ID);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null && dr.Read())
                            {
                                rta["Id"] = dr["id"].ToString();
                                rta["Nombre"] = dr["Nombre"].ToString();
                                rta["Descripcion"] = dr["Descripcion"].ToString();
                                return rta;
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
                return rta;
            }


        }
        public static bool ActualizarHabitaciones(string Habitacion, string descripcion,string id)
        {
            bool rta = false;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"UPDATE Habitaciones SET  Nombre = @nombre , Descripcion = @desc  WHERE Id like @id ;", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Nombre", Habitacion);
                        cmd.Parameters.AddWithValue("@desc", descripcion);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                        rta = true;
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
                return rta;
            }
        }
    }
}
