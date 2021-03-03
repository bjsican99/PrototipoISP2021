/*
 * Bryan Estuardo Mazariegos Davila
 * 0901-17-1001
 */
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModeloSeguridad
{
    public class clsModeloPerfil
    {
        clsConexion cn = new clsConexion();
        OdbcCommand Comm;
        //funcion para insertar
        public int funcLogin(string strUsuario, string strContrasena)
        {
            try
            {
                string strUsuarioDB = "";
                string strContrasenaDB = "";
               Comm = new OdbcCommand("SELECT usuario_login, contraseña_login FROM login WHERE usuario_login ='" + strUsuario + "' AND contraseña_login ='" + strContrasena + "' AND estado_login = 1 ;", cn.conexion());
                OdbcDataReader reader = Comm.ExecuteReader();
                reader.Read();
                strUsuarioDB = reader.GetString(0);
                strContrasenaDB = reader.GetString(1);
                reader.Close();
                if (String.IsNullOrEmpty(strUsuarioDB) || String.IsNullOrEmpty(strContrasenaDB))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("CapaModelo Error al consular usuario:  "+ ex);
                return 0;
            }
        }
        //funcion para obtener nuevos codigos
        public string funcObtenerNuevocodigo(string Tabla, string Campo)
        {
            String CampoResultante = "";
            try
            {
                string Consulta = "SELECT MAX(" + Campo + "+1) FROM " + Tabla + ";";
                OdbcCommand command = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                CampoResultante = reader.GetValue(0).ToString();
                reader.Close();
                if (String.IsNullOrEmpty(CampoResultante))
                    CampoResultante = "1";
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo " + Error);
            }
            return CampoResultante;
        }
        //funcion para insertar en la BD
        public OdbcDataReader funcInsertar(String Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader mostrar = Comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine("Ocurrio un error al registrar modelo"+err);
                return null;
            }
        }
        //funcion para la modificacion en la DB
        public OdbcDataReader funcModificar(string Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader mostrar = Comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo-modificar ", Error);
                return null;
            }
        }
        //funcion para realizar consultas al a DB
        public OdbcDataReader funcConsulta(string Consulta)
        {
            try
            {
                
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader reader = Comm.ExecuteReader();
                return reader;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo " + Error);
                return null;
            }

        }
    }
}
