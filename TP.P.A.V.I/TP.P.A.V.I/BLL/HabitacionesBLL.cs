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
            HabitacionesDAL.BeginTransaction();
            try
            {
                return HabitacionesDAL.DeleteHabitaciones(habitaciones.Nombre);
            }
            catch (Exception)
            {
                HabitacionesDAL.RollbackTransaction();
                return false;
            }
            HabitacionesDAL.CommitTransaction();
        }

        public static System.Data.DataTable CargarGrilla()
        {
            return HabitacionesDAL.cargarGrilla();
        }
        public static Habitaciones Obtenerhabitaciones(string ID)
        {
            Dictionary<string, string> dic = HabitacionesDAL.ObtenerHabitaciones(ID);

            Habitaciones hab = new Habitaciones();
            hab.id = dic["Id"];
            hab.Nombre = dic["Nombre"];
            hab.Descripcion = dic["Descripcion"];

            return hab;
        }
        public static bool ActualizarHabitaciones(Habitaciones habitaciones)
        {
            return HabitacionesDAL.ActualizarHabitaciones(habitaciones.Nombre, habitaciones.Descripcion, habitaciones.id);
        }


    }
}
