using CapaControladorSeguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaVistaSeguridad
{
    public class clsVistaBitacora
    {

        clsControladorBitacora conBit = new clsControladorBitacora();

        public void insert(string Accion, int Aplicacion)
        {
            conBit.funcAcciones(Aplicacion, Accion);
        }

        public void user(string usu)
        {
            conBit.funcUsuario(usu);
        }

    }
}
