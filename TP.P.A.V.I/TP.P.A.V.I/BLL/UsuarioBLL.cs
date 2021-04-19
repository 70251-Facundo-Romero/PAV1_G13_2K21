using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.P.A.V.I.DAL;

namespace TP.P.A.V.I.BLL
{
    public class UsuarioBLL
    {
        public static bool ValiadarLogin(string NombredeUsuario, string Password)
        {
            return UsuarioDAL.ValiadarLogin(NombredeUsuario, Password);
        }
    }
}
