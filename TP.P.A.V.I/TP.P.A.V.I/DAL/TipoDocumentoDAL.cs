using System;
using System.Data;
using System.Data.SqlClient;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I.DAL
{
    public class TipoDocumentoDAL : EntidadDAL
    {
        public static DataTable GetListadoTipoDoc()
        {
            string connection = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection cn = new SqlConnection(connection);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string query = "SELECT * FROM [Tipos_Documentos] ";

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
            catch (Exception ex)
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
    }
}
