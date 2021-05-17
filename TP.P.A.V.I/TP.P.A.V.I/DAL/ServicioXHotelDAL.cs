using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP.P.A.V.I.DAL
{
    public class ServicioXHotelDAL : EntidadDAL
    {
        public static bool ActualizarGrillaSerXHot(DataGridView grilla)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM ServiciosXHoteles", con))
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandType = CommandType.Text;

                        DataTable tabla = new DataTable();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);

                        grilla.DataSource = tabla;


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


        public static bool AgregarServicioXHotel(int Id_Hotel, int Id_Servicio, string Precio)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO ServiciosXHoteles (Id_Hotel, Id_Servicio, PrecioServicio) VALUES(@idHotel, @idServicio, @precio)", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@idHotel", Id_Hotel);
                        cmd.Parameters.AddWithValue("@idServicio", Id_Servicio);
                        cmd.Parameters.AddWithValue("@precio", Precio);
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

        public static void CargarCombosServicios(ComboBox cmbser)

        {


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Servicios", con))
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandType = CommandType.Text;

                        DataTable tabla = new DataTable();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);

                        cmbser.DataSource = tabla;
                        cmbser.DisplayMember = "Nombre";
                        cmbser.ValueMember = "Id";

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

        public static void CargarCombosHotel(ComboBox cmbhot)

        {


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Hoteles", con))
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandType = CommandType.Text;

                        DataTable tabla = new DataTable();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);

                        cmbhot.DataSource = tabla;
                        cmbhot.DisplayMember = "Nombre";
                        cmbhot.ValueMember = "Id";

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

        public static (int, int, string) ObtenerSerxHot((int, int) t1)
        {

            int idSer = 0;
            int idHot = 0;
            string precio = "";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM ServiciosXHoteles WHERE Id_Hotel like @idHot AND Id_Servicio like @idSer", con))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@idSer", t1.Item1);
                        cmd.Parameters.AddWithValue("@idHot", t1.Item2);
                        cmd.CommandType = CommandType.Text;

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr != null && dr.Read())
                        {
                            idSer = int.Parse(dr["Id_Servicio"].ToString());
                            idHot = int.Parse(dr["Id_Hotel"].ToString());
                            precio = dr["PrecioServicio"].ToString();


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

                return (idSer, idHot, precio);
            }
        }

        public static bool ModificarServicioXHotel(int Id_Hotel, int Id_Servicio, string Precio)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"UPDATE ServiciosXHoteles SET Id_Hotel = @idHotel, Id_Servicio = @idServicio, PrecioServicio = @precio WHERE Id_Hotel like @idHotel AND Id_Servicio like @idServicio", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@idHotel", Id_Hotel);
                        cmd.Parameters.AddWithValue("@idServicio", Id_Servicio);
                        cmd.Parameters.AddWithValue("@precio", Precio);
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

        public static bool EliminarServicioXHotel(int Id_Hotel, int Id_Servicio, string Precio)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"DELETE ServiciosXHoteles WHERE Id_Hotel like @idHotel AND Id_Servicio like @idServicio", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@idHotel", Id_Hotel);
                        cmd.Parameters.AddWithValue("@idServicio", Id_Servicio);
                       
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
    }
}
