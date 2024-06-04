using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokaYokes_app
{
    // CLASE PARA ALMACENAR LAS VARIABLES GENERALES DEL PROGRAMA
    // Vigilar si es necesario quitar static 
    public class UserVariables
    {
        //Variables de clase
        public string user;
        public string password;
        public string realPasswor;
        public string username;
        public string userRol;

    }

    public static class UserSession
    {
        public static UserVariables CurrentUser;
    }

}
