using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.P.A.V.I.DAL;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I.BLL
{
    public class HabitacionesBLL
    {
       public static bool Validar_Habitacion(string habitacion, string descripcion)
        {
            return HabitacionesDAL.ValidarHabitaciones(habitacion, descripcion);
        }
        public static bool InsertHabitaciones(Habitaciones habitaciones)
        {
            try
            {
                return HabitacionesDAL.InsertarHabitaciones(habitaciones.Nombre, habitaciones.Descripcion);
            }
            catch (Exception ex)
            {
                return false
                ;
            }
        }
        public static bool Delete_Habitacion(Habitaciones habitaciones)
        {
            try
            {
                return HabitacionesDAL.DeleteHabitaciones(habitaciones.id);
            }
            catch (Exception)
            {

                return false;
            }

        }
        public static System.Data.DataTable CargarGrilla()
        {
            return HabitacionesDAL.cargarGrilla();
        }
        public static Habitaciones Obtenerhabitaciones(string ID)
        {
            return HabitacionesDAL.ObtenerHabitaciones(ID);
        }
        public static bool ActualizarHabitaciones(Habitaciones habitaciones)
        {
            return HabitacionesDAL.ActualizarHabitaciones(habitaciones.Nombre, habitaciones.Descripcion, habitaciones.id);
        }


    }
}
