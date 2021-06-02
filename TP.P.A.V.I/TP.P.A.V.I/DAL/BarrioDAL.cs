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
    class BarrioDAL : EntidadDAL
    {
        public static DataTable ObtenerListadoBarrios()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"SELECT B.Id, B.Nombre, B.Descripcion, C.Nombre as NombreCiudad FROM Barrios B
                                JOIN Ciudades C ON B.IdCiudad = C.Id";

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

        public static Barrio ObtenerBarrio(int id)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            Barrio b = new Barrio();
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "SELECT * FROM Barrios WHERE Id LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    b.IdBarrio = int.Parse(dr["Id"].ToString());
                    b.NombreBarrio = dr["Nombre"].ToString();
                    b.DescBarrio = dr["Descripcion"].ToString();
                    b.IdCiudadBarrio = int.Parse(dr["IdCiudad"].ToString());
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

            return b;
        }

        public static bool AgregarBarrioABD(Barrio b)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "INSERT INTO Barrios (Nombre, Descripcion, IdCiudad) VALUES (@nombre, @desc, @idCiudad)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", b.NombreBarrio);
                cmd.Parameters.AddWithValue("@desc", b.DescBarrio);
                cmd.Parameters.AddWithValue("@idCiudad", b.IdCiudadBarrio);
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

        public static bool ActualizarBarrioABD(Barrio b)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "UPDATE Barrios SET Nombre = @nombre, Descripcion = @desc, IdCiudad = @idCiudad WHERE Id LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", b.IdBarrio);
                cmd.Parameters.AddWithValue("@nombre", b.NombreBarrio);
                cmd.Parameters.AddWithValue("@desc", b.DescBarrio);
                cmd.Parameters.AddWithValue("@idCiudad", b.IdCiudadBarrio);
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
        public static bool BorrarBarrioABD(Barrio b)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "DELETE FROM Barrios WHERE Id LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", b.IdBarrio);
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
    }
}
