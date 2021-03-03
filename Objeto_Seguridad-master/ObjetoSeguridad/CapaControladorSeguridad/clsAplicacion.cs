using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloSeguridad;

namespace CapaControladorSeguridad
{
    public class clsAplicacion
    {
        public void funcInsertar(string codigo, String nombre, String informe)
        {
            CapaModeloSeguridad.clsAplicacion app = new CapaModeloSeguridad.clsAplicacion();

            app.funcInsertarAplicacion(codigo, nombre, informe);

        }

        public void funcInsertarLogin(String usuario, String contraseña, String nombreempleado, String estado)
        {
            CapaModeloSeguridad.clsAplicacion app = new CapaModeloSeguridad.clsAplicacion();

            app.funcInsertarUsuario(usuario, contraseña, nombreempleado, estado);

        }

        public DataTable funcBuscar(string tabla)
        {
            CapaModeloSeguridad.clsAplicacion app = new CapaModeloSeguridad.clsAplicacion();


            OdbcDataAdapter dt = app.funcBuscar(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable funcBuscarLogin(string tabla)
        {
            CapaModeloSeguridad.clsAplicacion app = new CapaModeloSeguridad.clsAplicacion();

            OdbcDataAdapter dt = app.funcBuscarUsuario(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void funcModificar(string id, String nombre, String informe)
        {
            CapaModeloSeguridad.clsAplicacion app = new CapaModeloSeguridad.clsAplicacion();

            app.funcModificarAplicacion(id, nombre, informe);
            //public DataTable eliminar (string tabla)
 }

        public void funcModificarLogin(string id, String usuario, String contraseña, String nombreempleado,  String estado)
        {
            CapaModeloSeguridad.clsAplicacion app = new CapaModeloSeguridad.clsAplicacion();

            app.funcModificarUsuario(id, usuario, contraseña,nombreempleado, estado);
        }

        public void eliminar(string id) {

            CapaModeloSeguridad.clsAplicacion app = new CapaModeloSeguridad.clsAplicacion();
            app.funcEliminarAplicacion(id);
        }

        public void funcEliminarLogin(string id)
        {

            CapaModeloSeguridad.clsAplicacion app = new CapaModeloSeguridad.clsAplicacion();
            app.funcEliminarUsuario(id);
        }
        public static void funcSoloNumeros (KeyPressEventArgs S){
            //String Seleccion;
            //Aplicacion app = new Aplicacion();
            if (char.IsDigit(S.KeyChar))
            {
                S.Handled = false;
            }
            else if (char.IsSeparator(S.KeyChar))
            {
                S.Handled = false;
            }
            else if (char.IsControl(S.KeyChar))
            {
                S.Handled = false;
            }
         //   else if () { 
            
            
            //}
            else {
                S.Handled = true;
                MessageBox.Show("solo numeros");
            }
            
        }
    }
}
