﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.P.A.V.I.DAL;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I.BLL
{
    class InstalacionesBLL
    {
        public static bool Validar_Instalacion(string habitacion, string descripcion)
        {
            return InstalacionesDAL.ValidarInstalaciones(habitacion, descripcion);
        }
        public static bool InsertInstalaciones(Instalaciones instalaciones)
        {
            try
            {
                return InstalacionesDAL.InsertarInstalaciones(instalaciones.Nombre, instalaciones.Descripcion);
            }
            catch (Exception ex)
            {
                return false
                ;
            }
        }
        public static bool Delete_Instalacion(Instalaciones instalaciones)
        {
            try
            {
                return InstalacionesDAL.DeleteInstalaciones(instalaciones.id);
            }
            catch (Exception)
            {

                return false;
            }

        }
        public static System.Data.DataTable CargarGrilla()
        {
            return InstalacionesDAL.cargarGrilla();

        }
        public static Instalaciones Obtenerinstalaciones(string ID)
        {
            return InstalacionesDAL.ObtenerInstalaciones(ID);

        }
        public static bool ActualizarInstalaciones(Instalaciones instalaciones)
        {
            return InstalacionesDAL.ActualizarInstalaciones(instalaciones.Nombre, instalaciones.Descripcion, instalaciones.id);
        }
    }
}
