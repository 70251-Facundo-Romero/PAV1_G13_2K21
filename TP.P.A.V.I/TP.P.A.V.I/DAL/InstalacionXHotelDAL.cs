using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I.DAL
{
    public class InstalacionXHotelDAL : EntidadDAL
    {
        public static bool SaveInstalacionXHotel(InstalacionXHotel HxH)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                bool resultado = false;
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[InstalacionXHotel]" +
                                            "           ([IdInstalacion]" +
                                            "           ,[IdHotel])" +
                                            "       VALUES" +
                                            "           (@IdInstalacion" +
                                            "           ,@IdHotel)", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@IdHotel", HxH.IdHotel);
                    cmd.Parameters.AddWithValue("@IdInstalacion", HxH.IdInstalacion);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    resultado = true;
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
                return resultado;
            }
        }

        internal static bool VerfificarExixteCombinacion(int idHot, int idInst)
        {

            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * 
                                        FROM InstalacionXHotel 
                                        WHERE IdHotel = @idHot AND IdInstalacion = @idInst", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idHot", idHot);
                    cmd.Parameters.AddWithValue("@idInst", idInst);

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

        public static DataTable cargarGrilla(int Id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"select IxH.IdInstalacionXHotel as Id, I.Nombre as NombreInstalacion, H.Nombre as NombreHotel from InstalacionXHotel IxH
                                                            join Instalaciones I on IxH.IdInstalacion = I.Id
                                                            join Hoteles H on IxH.IdHotel = H.Id
                                                            where H.Id = @Id", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", Id);
                        using (SqlDataAdapter dr = new SqlDataAdapter(cmd))
                        {
                            DataTable tabla = new DataTable();
                            dr.Fill(tabla);
                            return tabla;

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
        }

        public static InstalacionXHotel SelectById(int Id)
        {
            InstalacionXHotel IxH = new InstalacionXHotel();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    //Abrimos la conexion
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(@"select IxH.* from InstalacionXHotel IxH
                                                            where IxH.IdInstalacionXHotel = @Id", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", Id);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                IxH.IdInstalacionXHotel = int.Parse(dr["IdInstalacionXHotel"].ToString());
                                IxH.IdHotel = int.Parse(dr["IdHotel"].ToString());
                                IxH.IdInstalacion = int.Parse(dr["IdInstalacion"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            return IxH;
        }

        public static void EliminarInstalacionXHotel(int Id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[InstalacionXHotel]" +
                        "      WHERE IdInstalacionXHotel = @Id ", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Id", Id);

                    cmd.ExecuteNonQuery();
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

        public static bool ModificarInstalacionXHotel(InstalacionXHotel IxH)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                bool resultado = false;
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE [dbo].[InstalacionXHotel]" +
                        "   SET[IdInstalacion] = @Instalacion" +
                        "      ,[IdHotel] = @Hotel" +
                        " WHERE IdInstalacionXHotel = @InstalacionXHotel ", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@InstalacionXHotel", IxH.IdInstalacionXHotel);
                    cmd.Parameters.AddWithValue("@Hotel", IxH.IdHotel);
                    cmd.Parameters.AddWithValue("@Instalacion", IxH.IdInstalacion);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    resultado = true;
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
                return resultado;
            }
        }
    }
}
