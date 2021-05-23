using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.P.A.V.I.DAL
{
    class InstalacionesDAL: EntidadDAL
    {
        public static bool ValidarInstalaciones(string Instalacion, string Descripcion)
        {
            bool rta = false;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Instalaciones WHERE Nombre = @Nombre AND Descripcion = @Descripcion", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Nombre", Instalacion);
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
        public static bool InsertarInstalaciones(string Instalacion, string Descripcion)
        {
            bool rta = false;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Instalaciones (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Nombre", Instalacion);
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
        public static bool DeleteInstalaciones(string Instalacion)
        {
            bool rta = false;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"DELETE FROM Instalaciones WHERE Nombre = @Nombre", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Nombre", Instalacion);

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
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Instalaciones", con))
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
        public static Dictionary<string, string> ObtenerInstalaciones(string ID)
        {
            Dictionary<string, string> rta = new Dictionary<string, string>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Instalaciones WHERE Id = @ID", con))
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
        public static bool ActualizarInstalaciones(string Instalacion, string descripcion, string id)
        {
            bool rta = false;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"UPDATE Instalaciones SET  Nombre = @nombre , Descripcion = @desc  WHERE Id like @id ;", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Nombre", Instalacion);
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
