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
    public class HabitacionXHotelDAL : EntidadDAL
    {
        public static void EliminarHabitacionXHotel(int Id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[HabitacionXHotel]" +
                                                    " WHERE IdHabitacionXHotel = @Id ", con);
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

        internal static bool VerificarExisteCombinacion(int idHot, int idHab)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * 
                                        FROM HabitacionXHotel 
                                        WHERE IdHotel = @idHot AND IdHabitacion = @idHab", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idHot", idHot);
                    cmd.Parameters.AddWithValue("@idHab", idHab);

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

        internal static bool VerificarExisteCombinacion2(int idHot, int idHab, string precio)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * 
                                        FROM HabitacionXHotel 
                                        WHERE IdHotel = @idHot AND IdHabitacion = @idHab AND Precio = @precio", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idHot", idHot);
                    cmd.Parameters.AddWithValue("@idHab", idHab);
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

        public static DataTable cargarGrilla(int Id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"select HxH.IdHabitacionXHotel as Id, H.Nombre as NombreHot, Hab.Nombre as NombreHab, HxH.Precio as Precio from HabitacionXHotel HxH
                                                            join Hoteles H on H.Id = HxH.IdHotel
                                                            join Habitaciones Hab on Hab.Id = HxH.IdHabitacion 
                                                            where HxH.IdHotel = @Id", con))
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

        public static HabitacionXHotel SelectById(int Id)
        {
            HabitacionXHotel HxH = new HabitacionXHotel();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    //Abrimos la conexion
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(@"select HxH.* from HabitacionXHotel HxH
                                                            where HxH.IdHabitacionXHotel = @Id", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", Id);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                HxH.Id = int.Parse(dr["IdHabitacionXHotel"].ToString());
                                HxH.hotel = int.Parse(dr["IdHotel"].ToString());
                                HxH.habitacion = int.Parse(dr["IdHabitacion"].ToString());
                                HxH.Precio = dr["Precio"].ToString();
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
            return HxH;
        }

        public static bool SaveHabitacionXHotel(HabitacionXHotel HxH)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                bool resultado = false;
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[HabitacionXHotel]" +
                        "           ([IdHotel]" +
                        "           ,[IdHabitacion]" +
                        "           ,[Precio])" +
                        "     VALUES" +
                        "           (@Hotel" +
                        "           ,@Habitacion" +
                        "           ,@Precio)", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Hotel", HxH.hotel);
                    cmd.Parameters.AddWithValue("@Habitacion", HxH.habitacion);
                    cmd.Parameters.AddWithValue("@Precio", HxH.Precio);
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

        public static bool ModificarHabitacionXHotel(HabitacionXHotel HxH)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                bool resultado = false;
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE [dbo].[HabitacionXHotel]" +
                        "   SET[IdHotel] = @Hotel" +
                        "      ,[IdHabitacion] = @Habitacion" +
                        "      ,[Precio] = @Precio" +
                        " WHERE IdHabitacionXHotel = @IdHxH", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Hotel", HxH.hotel);
                    cmd.Parameters.AddWithValue("@Habitacion", HxH.habitacion);
                    cmd.Parameters.AddWithValue("@Precio", HxH.Precio);
                    cmd.Parameters.AddWithValue("@IdHxH", HxH.Id);
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
