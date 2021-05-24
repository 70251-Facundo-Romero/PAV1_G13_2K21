using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.P.A.V.I.DAL;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I.BLL
{
    public static class  HabitacionXHotelBLL
    {
        public static DataTable cargarGrilla(int id)
        {
            return HabitacionXHotelDAL.cargarGrilla(id);
        }

        public static HabitacionXHotel SelectById(int Id)
        {
            return HabitacionXHotelDAL.SelectById(Id);
        }
        public static bool SaveHabitacionXHotel(HabitacionXHotel HxH)
        {
            return HabitacionXHotelDAL.SaveHabitacionXHotel(HxH);
        }
        public static void EliminarHabitacionXHotel(int Id)
        {
            HabitacionXHotelDAL.EliminarHabitacionXHotel(Id);
        }

        public static bool ModificarHabitacionXHotel(HabitacionXHotel HxH)
        {
            return HabitacionXHotelDAL.ModificarHabitacionXHotel(HxH);
        }

        internal static bool VerificarExisteCombinacion(int IdHot, int IdHab)
        {
            return HabitacionXHotelDAL.VerificarExisteCombinacion(IdHot, IdHab);
        }

        internal static bool VerificarExisteCombinacion2(int IdHot, int IdHab, string precio)
        {
            return HabitacionXHotelDAL.VerificarExisteCombinacion2(IdHot, IdHab, precio);
        }
    }
}
