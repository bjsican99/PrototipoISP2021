using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloSeguridad;

namespace CapaControladorSeguridad
{
    public class clsControladorBitacora
    {

        clsModeloBitacora b = new clsModeloBitacora();

        public void funcUsuario(string usu) //obtiene el usuario
        {
            b.getUsuario(usu);
        }

        public void funcAcciones(int aplicacion, String accion) //obtiene los valores necesarios para registrar movimientos
        {
            b.nombreAplicacion = aplicacion;
            b.accion = accion;

            b.funcInsertar(accion, aplicacion);
        }

    }
}
