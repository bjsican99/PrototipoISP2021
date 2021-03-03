using CapaModeloSeguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModeloSeguridad
{
    public class clsAplicacion
    {
        
        clsConexion cn = new clsConexion();
        //Funcion para insertar------------ 
        public void funcInsertarAplicacion(string codigo, String nombre, String informe)
        {

            try
            {
                int codigo1 = int.Parse(codigo);

                //cadena a insertar
                string cadena1 = "SELECT  pk_id_aplicacion FROM aplicacion WHERE pk_id_aplicacion = " + codigo1 + "  ;";

                OdbcDataAdapter cadena2 = new OdbcDataAdapter(cadena1, cn.conexion());
                string cadena = "INSERT INTO aplicacion (pk_id_aplicacion, nombre_aplicacion, informe_aplicacion) VALUES('" + codigo + "','" + nombre + "','" + informe + "');";

                OdbcDataAdapter cad = cadena2;
                DataTable dt = new DataTable();
                cad.Fill(dt);
                // string cadena3 = "3";
                //if (cadena1 == codigo)
                //if (cadena1.Equals(codigo))
                foreach (DataRow row in dt.Rows)
                {

                    int id = int.Parse(row["pk_id_aplicacion"].ToString());
                    if (id == codigo1)
                    {
                        MessageBox.Show("codigo existente");
                    } /*else
                {
                        OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                        consulta.ExecuteNonQuery();
                        MessageBox.Show("se inserto correctamente");
                        insert();
                }*/

                }
                    OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("se inserto correctamente");
            }
            catch (Exception e) {
                //FileSystemEventHandler.Remove(e.Message);
            }
            /* if (cadena2==codigo)

             {


                 MessageBox.Show("codigo existente");


         }
         else
         {
             OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
             consulta.ExecuteNonQuery();
             MessageBox.Show("se inserto correctamente");
         }*/







            // OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            //consulta.ExecuteNonQuery();

        }

        public void funcInsertarUsuario(String usuario, String contraseña, String nombreempleado, String estado)
        {


            //cadena a insertar

            string cadena = "INSERT INTO LOGIN (usuario_login, contraseña_login, nombreCompleto_login, estado_login) VALUES('" + usuario + "','" + contraseña + "','" + nombreempleado + "','" + estado + "'); ";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }


        public OdbcDataAdapter funcBuscar(string id)
        {
            int id1 = int.Parse(id);

            string cadena1 = "SELECT * FROM aplicacion WHERE pk_id_aplicacion = " + id1 + "  ;";
            OdbcDataAdapter cadena2 = new OdbcDataAdapter(cadena1, cn.conexion());
            return cadena2;
        }

        public OdbcDataAdapter funcBuscarUsuario(string id)
        {
            int id1 = int.Parse(id);

            string cadena1 = "SELECT * FROM login WHERE pk_id_login = " + id1 + "  ;";
            OdbcDataAdapter cadena2 = new OdbcDataAdapter(cadena1, cn.conexion());
            return cadena2;
        }

        public void funcOdbcDataAdapter(string nombre, string informe)
        {
            throw new NotImplementedException();
        }

        public void funcOdbcDataAdapterUsuario(String usuario, String contraseña, String nombreempleado, String estadoo)
        {
            throw new NotImplementedException();
        }


        public void funcModificarAplicacion(string id, String nombre, String informe)
        {

            int id1 = int.Parse(id);
            //cadena modificar
            string cadena = "UPDATE aplicacion SET nombre_aplicacion = '" + nombre + "', informe_aplicacion = '" + informe + "' WHERE pk_id_aplicacion = " + id1 + "  ;";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
            //consulta.ExecuteNonQuery();

        }

        public void funcModificarUsuario(string id, String usuario, String contraseña, String nombreempleado, String estado)
        {

            int id1 = int.Parse(id);
            //cadena modificar
            string cadena = "UPDATE login SET usuario_login = '" + usuario + "', contraseña_login = '" + contraseña + "',  nombreCompleto_login = '" + nombreempleado + "', estado_login = '" + estado + "' WHERE pk_id_login = " + id1 + "  ;";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
            //consulta.ExecuteNonQuery();

        }

        public void funcEliminarAplicacion(string id)
        {
            int id1 = int.Parse(id);

            string cadena1 = "DELETE  FROM aplicacion WHERE pk_id_aplicacion = " + id1 + "  ;";
            OdbcCommand consulta = new OdbcCommand(cadena1, cn.conexion());
            consulta.ExecuteNonQuery();

            //return consulta;
            //OdbcDataAdapter cadena2 = new OdbcDataAdapter(cadena1, cn.conexion());
            //return cadena2;
        }

        public void funcEliminarUsuario(string id)
        {
            int id1 = int.Parse(id);

            string cadena1 = "DELETE  FROM login WHERE pk_id_login = " + id1 + "  ;";
            OdbcCommand consulta = new OdbcCommand(cadena1, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        // public void seleccionar(string seleccionar) { 
        //string cadena = cb

        //funcion obtener el codigo maximo de aplicacion
        
    }
       
}
    
