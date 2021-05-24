using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I.DAL
{


    public class TarjetaDAL : EntidadDAL
    {
        public static bool AgregarTarjeta(string NombreTarjeta, string Descripcion)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Tarjetas (Nombre, Descripcion) VALUES(@NombreTarjeta, @Desc)", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@NombreTarjeta", NombreTarjeta);
                        cmd.Parameters.AddWithValue("@Desc", Descripcion);
                        cmd.ExecuteNonQuery();
                        resultado = true;

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

        internal static bool ModificarTarjeta(Tarjeta t)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"UPDATE Tarjetas 
                            SET Nombre = @nom, Descripcion = @desc 
                            WHERE Id_tarjeta LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", t.Id_Tarjeta);
                cmd.Parameters.AddWithValue("@nom", t.Nombre);
                cmd.Parameters.AddWithValue("@desc", t.Descripcion);
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

        internal static bool BorrarTarjeta(Tarjeta t)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"DELETE FROM Tarjetas WHERE Id_Tarjeta = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", t.Id_Tarjeta);
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

        internal static Tarjeta ObtenerTarjeta(int id)
        {
            Tarjeta t = new Tarjeta();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Tarjetas WHERe Id_Tarjeta = @Id", con))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Id", id);

                        cmd.CommandType = CommandType.Text;

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr != null && dr.Read())
                        {
                            t.Id_Tarjeta = int.Parse(dr["Id_Tarjeta"].ToString());
                            t.Nombre = dr["Nombre"].ToString();
                            t.Descripcion = dr["Descripcion"].ToString();
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
                return t;
            }
        }

        public static DataTable ActualizarGrillaTarjeta()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Tarjetas", con))
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandType = CommandType.Text;

                        DataTable tabla = new DataTable();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);

                        return tabla;
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

    }
    
}
