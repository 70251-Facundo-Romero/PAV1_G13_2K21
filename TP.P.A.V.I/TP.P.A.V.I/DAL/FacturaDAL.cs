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
    public class FacturaDAL : EntidadDAL
    {
        public static Factura ObtenerFactura(string pasaporte)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            Factura f = new Factura();
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(connection);

            try
            {
                string consulta = @"select H.Nombre as Huesped, H.Apellido,AXH.FechaAlojamiento, Hot.Nombre as Hotel , P.Nombre as Pais, Hot.Id as HotelId, AXH.IdAXH AS IdAloj, H.Id AS IdHuesped from Huespedes H
                        join AlojamientoXHotel AXH on AXH.IdHuesped = H.Id
                        join HabitacionXHotel HXH on AXH.IdHabXHotel = HXH.IdHabitacionXHotel
                        join Hoteles Hot on HXH.IdHotel = Hot.Id
                        join Barrios B on B.Id = Hot.Id_Barrio
                        join Ciudades C on B.IdCiudad = C.Id
                        join Paises P on P.Id = C.Id_pais
                        where H.NroPasaporte = @nroPass";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroPass", pasaporte);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    f.nombreHuesped = dr["Huesped"].ToString();
                    f.apellidoHuesped = dr["Apellido"].ToString();
                    f.FechaAloj = DateTime.Parse(dr["FechaAlojamiento"].ToString());
                    f.NomHotel = dr["Hotel"].ToString();
                    f.NomPais = dr["Pais"].ToString();
                    f.IdHotel = int.Parse(dr["HotelId"].ToString());
                    f.IdHuesped = int.Parse(dr["IdHuesped"].ToString());
                    f.IdAloj = int.Parse(dr["IdAloj"].ToString());
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

            return f;
        }

        public static int MaxNum()
        {
            string connection = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            int num = 0;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(connection);

            try
            {
                string consulta = @"SELECT MAX(NroFactura) AS Num FROM Facturacion";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["Num"] != DBNull.Value)
                    {
                        num = int.Parse(dr["Num"].ToString());

                    }
                }
            }
            catch (Exception EX)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return num +1;
        }

        public static List<Factura> ObenerDetalles(DateTime fechaAloj, string pasaporte, int idHot)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            List<Factura> lista = new List<Factura>();
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = @"select HXH.Precio, H.Nombre, datediff(day,AXH.FechaAlojamiento,AXH.FechaSalida) as CantDias, (datediff(day,AXH.FechaAlojamiento,AXH.FechaSalida) * HXH.Precio) as Total from Habitaciones H
                        join HabitacionXHotel HXH on HXH.IdHabitacion = H.Id
                        join AlojamientoXHotel AXH on AXH.IdHabXHotel = HXH.IdHabitacionXHotel
                        join Huespedes Hu on HU.Id = AXH.IdHuesped
                        where AXH.FechaAlojamiento = @parametro and Hu.NroPasaporte = @parametro2 and HXH.IdHotel = @parametro3";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@parametro", fechaAloj);
                cmd.Parameters.AddWithValue("@parametro2", pasaporte);
                cmd.Parameters.AddWithValue("@parametro3", idHot);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Factura f = new Factura();
                        f.nombreHabitacion = dr["Nombre"].ToString();
                        f.CantDias = int.Parse(dr["CantDias"].ToString());
                        f.PrecioHab = dr["Precio"].ToString();
                        f.PrecioTotal = dr["Total"].ToString();
                        lista.Add(f);
                    }
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
            return lista;
        }


        public static bool AgregarFactura(Factura f, List<Factura> dt)
        {
            BeginTransaction();
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool resultado = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "INSERT INTO Facturacion (FechaFactura, IdHuesped) OUTPUT INSERTED.NroFactura VALUES (@fecha, @id)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha", f.FechaFactura);
                cmd.Parameters.AddWithValue("@id", f.IdHuesped);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                
                int idConseguido = (int)Convert.ToInt64(cmd.ExecuteScalar());

                SqlCommand cmd2 = new SqlCommand();

                foreach (Factura item in dt)
                {
                    string consulta2 = @"INSERT INTO [dbo].[Detalles_Facturas]
                                   ([NroFactura]
                                   ,[CantidadDias]
                                   ,[Precio]
                                   ,[IdAlojamiento])
                             VALUES
                                   (@nroF
                                   ,@cantD
                                   ,@precio
                                   ,@idAloj)";

                    cmd2.Parameters.Clear();
                    cmd2.Parameters.AddWithValue("@nroF", idConseguido);
                    cmd2.Parameters.AddWithValue("@cantD", item.CantDias);
                    cmd2.Parameters.AddWithValue("@precio", item.PrecioHab);
                    cmd2.Parameters.AddWithValue("@idAloj", f.IdAloj);

                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = consulta2;

                    cmd2.Connection = cn;
                    cmd2.ExecuteNonQuery();
                }

                resultado = true;
                CommitTransaction();
            }
            catch (Exception ex)
            {
                RollbackTransaction();
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
