using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I.DAL
{
    public class TipoDocumentoDAL : EntidadDAL
    {
        public static DataTable GetListadoTipoDoc()
        {
            string connection = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            SqlConnection cn = new SqlConnection(connection);

            SqlCommand cmd = new SqlCommand();
            
            try
            {

                string query = "SELECT * FROM [Tipos_Documentos]";

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

        public static bool InsertTipoDoc(TipoDocumento model)
        {
            bool result = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"insert into [Tipos_Documentos] (NombreTipoDocumento) values (@NombreTipoDoc)", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@NombreTipoDoc", model.NombreTipoDocumento);
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

        public static TipoDocumento ObtenerTipoPorId(int id)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            TipoDocumento td = new TipoDocumento();
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(connection);

            try
            {
                string consulta = "SELECT * FROM [Tipos_Documentos] WHERE Id_TipoDocumento LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                   td.Id = int.Parse(dr["Id_TipoDocumento"].ToString());
                   td.NombreTipoDocumento = dr["NombreTipoDocumento"].ToString();
                    
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

            return td;
        }

        public static bool ActualizarTipo(TipoDocumento model)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool result = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(connection);

            try
            {
                string consulta = "UPDATE [Tipos_Documentos] SET NombreTipoDocumento = @nombre WHERE Id_TipoDocumento LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", model.Id);
                cmd.Parameters.AddWithValue("@nombre", model.NombreTipoDocumento);
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

        public static bool BorrarTipoDoc(TipoDocumento model)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            bool result = false;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(connection);

            try
            {
                string consulta = "DELETE FROM [Tipos_Documentos] WHERE Id_TipoDocumento LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", model.Id);
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
