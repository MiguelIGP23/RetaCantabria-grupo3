using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class Session
    {
        public static string? Token { get; private set; }
        public static EnumRoles? Rol { get; private set; }

        public static bool IsLogged => !string.IsNullOrWhiteSpace(Token);

        // Para login
        public static void Set(string token, string rol)
        {
            Token = token;
            Rol = rol;
        }

        // Para logout
        public static void Logout()
        {
            Token = null;
            Rol = null;
        }
    }
}
