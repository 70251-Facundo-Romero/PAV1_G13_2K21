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
    public class ServicioXHotelDAL : EntidadDAL
    {
        internal static DataTable ObtenerListadoHoteles()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"SELECT * FROM Hoteles";

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

        internal static bool BorrarServXHotel(ServXHotel s)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"DELETE FROM ServiciosXHoteles WHERE Id = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", s.IdServXHot);
                cmd.Parameters.AddWithValue("@idHotel", s.Id_Hotel);
                cmd.Parameters.AddWithValue("@idServicio", s.Id_Servicio);
                cmd.Parameters.AddWithValue("@precio", s.PrecioServicio);
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

        internal static bool VerificarExisteCombinacion2(int idHot, int idServ, string precio)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * 
                                        FROM ServiciosXHoteles
                                        WHERE Id_Hotel = @idHot AND Id_Servicio = @idServ AND PrecioServicio = @precio", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idHot", idHot);
                    cmd.Parameters.AddWithValue("@idServ", idServ);
                    cmd.Parameters.AddWithValue("@precio", precio);

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

                    throw;
                }
            }
            return resultado;
        }

        internal static bool VerificarExisteCombinacion(int idHot, int idServ)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * 
                                        FROM ServiciosXHoteles
                                        WHERE Id_Hotel = @idHot AND Id_Servicio = @idServ", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idHot", idHot);
                    cmd.Parameters.AddWithValue("@idServ", idServ);

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

                    throw;
                }
            }
            return resultado;
        }

        internal static bool ActualizarServXHotel(ServXHotel s)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"UPDATE ServiciosXHoteles 
                            SET PrecioServicio = @precio, Id_Hotel = @idHotel, Id_Servicio = @idServicio 
                            WHERE Id LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", s.IdServXHot);
                cmd.Parameters.AddWithValue("@idHotel", s.Id_Hotel);
                cmd.Parameters.AddWithValue("@idServicio", s.Id_Servicio);
                cmd.Parameters.AddWithValue("@precio", s.PrecioServicio);
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

        internal static bool AgregarServXHotel(ServXHotel s)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "INSERT INTO ServiciosXHoteles (Id_Hotel, Id_Servicio, PrecioServicio) VALUES (@IdHot, @IdServ, @Precio)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdHot", s.Id_Hotel);
                cmd.Parameters.AddWithValue("@IdServ", s.Id_Servicio);
                cmd.Parameters.AddWithValue("@Precio", s.PrecioServicio);
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

        internal static ServXHotel ObtenerServXHotel(int id)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            ServXHotel s = new ServXHotel();
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "SELECT * FROM ServiciosXHoteles WHERE Id LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    s.IdServXHot = int.Parse(dr["Id"].ToString());
                    s.Id_Hotel = int.Parse(dr["Id_Hotel"].ToString());
                    s.Id_Servicio = int.Parse(dr["Id_Servicio"].ToString());
                    s.PrecioServicio = dr["PrecioServicio"].ToString();
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

            return s;
        }

        internal static DataTable ObtenerListadoServxHoteles()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"SELECT SxH.*, H.Nombre as NombreHotel, S.Nombre as NombreServicio
                            FROM ServiciosXHoteles SxH
                            JOIN Hoteles H ON SxH.Id_Hotel = H.Id
                            JOIN Servicios S ON SxH.Id_Servicio = S.Id";

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

        internal static DataTable ObtenerListadoServicios()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"SELECT * FROM Servicios";

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
