using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloSeguridad;

namespace CapaControladorSeguridad
{
    public class clsControlCodAplicacion
    {

        clsCodAplicacion codAplicacion = new clsCodAplicacion();
        //dar un id
        public string funcObtenerCodigoAplicacion(string modulo)
        {         
            return codAplicacion.funcObtenerCodigo(modulo);
        }
        //Verificar si existe el id
        public int funcExisteCodigo(string Codigo)
        {
            return codAplicacion.funComprobarCodigo(Codigo);
        }
    }
}
