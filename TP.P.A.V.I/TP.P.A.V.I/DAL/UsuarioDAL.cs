using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.P.A.V.I.DAL
{
    public class UsuarioDAL : EntidadDAL
    {
        public static bool ValiadarLogin(string NombredeUsuario, string Password)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM usuario WHERE Nombre = @NombreUsuario and Password = @Password", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@NombreUsuario", NombredeUsuario);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                resultado = true;
                            }
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
            }
            return resultado;
        }
    }
}
