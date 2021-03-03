using CapaModeloSeguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorSeguridad
{

    public class clsObtenerPermisos
    {
        clsPermisos permisos = new clsPermisos();
        public string funcPermisosPorAplicacion(string strAplicacion, string strUsuario)
        {
            return permisos.funcPermisosPorAplicacion(strAplicacion, strUsuario);
        }

        public string funcPermisosPorPerfil(string strAplicacion, string strUsuario)
        {
            return permisos.funcPermisosPorPerfil(strAplicacion, strUsuario);
        }

        public int funcAccesoAplicacionPerfil(string strIdAplicacion, string strUsuario)
        {
            return permisos.funcAccesoAplicacionPerfil(strIdAplicacion, strUsuario);
        }

        public int funcAccesoAplicacion(string strIdAplicacion, string strUsuario)
        {
            return permisos.funcAccesoAplicacion(strIdAplicacion, strUsuario);
        }
    }
}