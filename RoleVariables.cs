using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokaYokes_app
{
    public class RoleVariables
    {
        //Variables de clase
        public int idRole;
        public string role;
        public bool modLines;
        public bool modTools;
        public bool modToolsLine;
        public bool modDetectors;
        public bool rrMod;
        public bool rrAdd;
        public bool rrDel;

    }

    public static class RoleSession
    {
        public static RoleVariables CurrentRole;

        static RoleSession()
        {
            CurrentRole = new RoleVariables();
        }
    }

}

