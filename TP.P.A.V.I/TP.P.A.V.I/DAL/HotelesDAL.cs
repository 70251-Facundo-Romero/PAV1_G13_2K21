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
    class HotelesDAL : EntidadDAL
    {

        public static DataTable ObtenerListadoHoteles()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }


        }

        public static bool AgregarHotelABD(Hotel h)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "INSERT INTO Hoteles (Nombre, Calle, NumeroCalle, Id_Barrio) VALUES (@nombre, @calle,@numCalle,@idBarrio)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", h.NombreHotel);
                cmd.Parameters.AddWithValue("@calle", h.CalleHotel);
                cmd.Parameters.AddWithValue("@numCalle", h.NumeroCalle);
                cmd.Parameters.AddWithValue("@idBarrio", h.IdBarrio);
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

        public static Hotel ObtenerHotel(int id)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            Hotel h = new Hotel();
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "SELECT * FROM Hoteles WHERE Id LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    h.IdHotel = int.Parse(dr["Id"].ToString());
                    h.NombreHotel = dr["Nombre"].ToString();
                    h.CalleHotel = dr["Calle"].ToString();
                    h.NumeroCalle = dr["NumeroCalle"].ToString();
                    h.IdBarrio = int.Parse(dr["Id_Barrio"].ToString());
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

            return h;
        }

        public static bool ActualizarHotelABD(Hotel h)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "UPDATE Hoteles SET Nombre = @nombre, Calle = @calle, NumeroCalle=@numCalle,Id_Barrio=@idBarrio WHERE Id LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", h.IdHotel);
                cmd.Parameters.AddWithValue("@nombre", h.NombreHotel);
                cmd.Parameters.AddWithValue("@numCalle", h.NumeroCalle);
                cmd.Parameters.AddWithValue("@calle", h.CalleHotel);
                cmd.Parameters.AddWithValue("@idBarrio", h.IdBarrio);
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

        public static bool BorrarHotelABD(Hotel h)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "DELETE FROM Hoteles WHERE Id LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", h.IdHotel);
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
        public static DataTable ObtenerListadoBarrios()
        {
            
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Barrios";
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
