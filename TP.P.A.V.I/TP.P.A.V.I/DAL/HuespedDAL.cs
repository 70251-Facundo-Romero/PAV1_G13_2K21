using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I.DAL
{
    public class HuespedDAL: EntidadDAL
    {

        public static DataTable GetListadoHuespedes()
        {
            string connection = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlConnection cn = new SqlConnection(connection);

            SqlCommand cmd = new SqlCommand();

            try
            {

                string query = "SELECT * FROM [Huespedes]";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cn.Open();
                cmd.Connection = cn;

                DataTable table = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);

                return table;
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

        public static bool InsertHuesped(Huesped model)
        {
            bool result = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"insert into [Huespedes] (NroPasaporte, Id_Pais, Apellido, Nombre, NroTarjetaDeCredito, Id_Tarjeta) values (@nroPasaporte, @id_Pais, @apellido, @nombre, @nroTarjeta, @id_tarjeta)", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@nroPasaporte", model.NroPasaporte);
                        cmd.Parameters.AddWithValue("@id_Pais", model.Id_Pais);
                        cmd.Parameters.AddWithValue("@apellido", model.Apellido);
                        cmd.Parameters.AddWithValue("@nombre", model.Nombre);
                        cmd.Parameters.AddWithValue("@nroTarjeta", model.NroTarjetaDeCredito);
                        cmd.Parameters.AddWithValue("@id_tarjeta", model.Id_Tarjeta);
                        cmd.ExecuteNonQuery();
                        result = true;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            return result;
        }

        public static Huesped ObtenerHuespedPorPasaporte(int pasaporte)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            Huesped h = new Huesped();
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(connection);

            try
            {
                string consulta = "SELECT * FROM [Huespedes] WHERE NroPasaporte LIKE @nroPass";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroPass", pasaporte);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    h.NroPasaporte = int.Parse(dr["NroPasaporte"].ToString());
                    h.Id_Pais = int.Parse(dr["Id_Pais"].ToString());
                    h.Apellido = dr["Apellido"].ToString();
                    h.Nombre = dr["Nombre"].ToString();
                    h.NroTarjetaDeCredito = int.Parse(dr["NroTarjetaDeCredito"].ToString());
                    h.Id_Tarjeta = int.Parse(dr["Id_Tarjeta"].ToString());

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

        public static bool ActualizarHuesped(Huesped model)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool result = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(connection);

            try
            {
                string consulta = "UPDATE [Huespedes] SET Id_Pais = @id_Pais, Apellido = @apellido, Nombre = @nombre, NroTarjetaDeCredito = @nroTarjeta, Id_Tarjeta = @id_tarjeta WHERE NroPasaporte LIKE @nroPasaporte";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroPasaporte", model.NroPasaporte);
                cmd.Parameters.AddWithValue("@id_Pais", model.Id_Pais);
                cmd.Parameters.AddWithValue("@apellido", model.Apellido);
                cmd.Parameters.AddWithValue("@nombre", model.Nombre);
                cmd.Parameters.AddWithValue("@nroTarjeta", model.NroTarjetaDeCredito);
                cmd.Parameters.AddWithValue("@id_tarjeta", model.Id_Tarjeta);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return result;
        }

        public static bool BorrarHuesped(Huesped model)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool result = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(connection);

            try
            {
                string consulta = "DELETE FROM [Huespedes] WHERE NroPasaporte LIKE @pasaporte";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pasaporte", model.NroPasaporte);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return result;
        }
    }
}
