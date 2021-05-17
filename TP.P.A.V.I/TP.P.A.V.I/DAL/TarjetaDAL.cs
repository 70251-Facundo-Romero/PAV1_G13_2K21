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


    public class TarjetaDAL : EntidadDAL
    {
        public static bool AgregarTarjeta(string NombreTarjeta)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Tarjetas (Nombre) VALUES(@NombreTarjeta)", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@NombreTarjeta", NombreTarjeta);
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





        public static bool ActualizarGrillaTarjeta(DataGridView grilla)
        {
            bool resultado = false;

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


        public static (int, string) ObtenerTarjeta(int Id)
        {

            int newId = 0;
            string newNombre = "";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Tarjetas WHERE Id_Tarjeta like @id", con))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", Id);
                        cmd.CommandType = CommandType.Text;

                        SqlDataReader dr = cmd.ExecuteReader();

                        if(dr != null && dr.Read())
                        {
                            newId = int.Parse(dr["Id_Tarjeta"].ToString());
                            newNombre = dr["Nombre"].ToString();
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

                return (newId, newNombre);
            }
        }


        public static bool ModificarTarjeta(string NombreTarjeta, int id)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"UPDATE Tarjetas SET Nombre = @NombreTarjeta WHERE Id_Tarjeta like @id", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@NombreTarjeta", NombreTarjeta);
                        cmd.Parameters.AddWithValue("@id", id);
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

        public static bool EliminarTarjeta(string NombreTarjeta, int id)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"DELETE Tarjetas WHERE Id_Tarjeta like @id", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        
                        cmd.Parameters.AddWithValue("@id", id);
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
