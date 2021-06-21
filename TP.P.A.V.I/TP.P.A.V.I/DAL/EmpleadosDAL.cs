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
    class EmpleadosDAL
    {

        public static DataTable ObtenerListadoEmpleados()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"SELECT E.Id, E.NumeroDocumento, T.NombreTipoDocumento, E.Apellido, E.Nombre, E.FechaIngreso, H.Nombre as NombreHotel, P.Nombre as NombrePuesto
                            FROM Empleados E
                            JOIN Tipos_Documentos T ON E.TipoDocumento = T.Id_TipoDocumento
                            JOIN Hoteles H ON E.Id_Hotel = H.Id
                            JOIN Puestos_Trabajo P ON E.Id_Puesto = P.Id";

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

        public static bool AgregarEmpleadoABD(Empleado em)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "INSERT INTO Empleados(TipoDocumento,  NumeroDocumento, Apellido,Nombre,FechaIngreso,Id_Hotel,Id_Puesto) VALUES (@tipoDoc, @numDoc,@apellido,@nombre,@fechaIngreso,@idHotel,@idPuesto)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDoc", em.TipoDocumento);
                cmd.Parameters.AddWithValue("@numDoc", em.NumeroDocumento);
                cmd.Parameters.AddWithValue("@apellido", em.ApellidoEmpleado);
                cmd.Parameters.AddWithValue("@nombre", em.NombreEmpleado);
                cmd.Parameters.AddWithValue("@fechaIngreso", em.FechaIngreso);
                cmd.Parameters.AddWithValue("@idHotel", em.IdHotel);
                cmd.Parameters.AddWithValue("idPuesto", em.IdPuesto);
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

        public static Empleado ObtenerEmpleado(int id)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            Empleado em = new Empleado();
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "SELECT * FROM Empleados WHERE Id LIKE @numDoc";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numDoc", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    em.TipoDocumento = int.Parse(dr["TipoDocumento"].ToString());
                    em.NumeroDocumento = dr["NumeroDocumento"].ToString();
                    em.ApellidoEmpleado = dr["Apellido"].ToString();
                    em.NombreEmpleado = dr["Nombre"].ToString();
                    em.FechaIngreso = DateTime.Parse(dr["FechaIngreso"].ToString());
                    em.IdHotel = int.Parse(dr["Id_Hotel"].ToString());
                    em.IdPuesto = int.Parse(dr["Id_Puesto"].ToString());
                    em.Id = int.Parse(dr["Id"].ToString());
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

            return em;
        }

        public static bool ActualizarEmpleadoABD(Empleado em)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "UPDATE Empleados SET TipoDocumento = @tipoDoc, NumeroDocumento = @numDoc,  Apellido=@apellido,Nombre=@nombre,FechaIngreso=@fechaIn,Id_Hotel=@idHotel,Id_Puesto=@idPuesto WHERE  Id = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDoc", em.TipoDocumento);
                cmd.Parameters.AddWithValue("@numDoc", em.NumeroDocumento);
                cmd.Parameters.AddWithValue("@apellido", em.ApellidoEmpleado);
                cmd.Parameters.AddWithValue("@nombre", em.NombreEmpleado);
                cmd.Parameters.AddWithValue("@fechaIn", em.FechaIngreso);
                cmd.Parameters.AddWithValue("@idHotel", em.IdHotel);
                cmd.Parameters.AddWithValue("@idPuesto", em.IdPuesto);
                cmd.Parameters.AddWithValue("@id", em.Id);
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

        public static bool BorrarEmpleadoABD(Empleado em)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "DELETE FROM Empleados WHERE Id LIKE @numDoc";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numDoc", em.Id);
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
        public static DataTable ObtenerListadoPuestos()
        {

            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Puestos_Trabajo";
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
        public static DataTable ObtenerListadoTipoDocumentos()
        {

            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Tipos_Documentos";
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
        public static DataTable ObtenerEmpleadosXHotel()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"SELECT h.Nombre, COUNT(e.id) AS 'CantidadEmpleados' FROM Hoteles h
                        JOIN Empleados e ON h.Id = e.Id_Hotel
                        GROUP BY h.Nombre";

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
    }
}

