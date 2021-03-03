using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloSeguridad
{
    public class clsVariableGlobal
    {
         static string usuarioglobal;
        static string aplica1;

        public string usuariog
        {
            get { return usuarioglobal; }
            set { usuarioglobal = value; }
        }
        public string aplica
        {
            get { return aplica1; }
            set { aplica1 = value; }
        }
    }
}
