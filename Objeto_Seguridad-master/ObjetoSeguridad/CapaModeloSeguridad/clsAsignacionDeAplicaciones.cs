using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModeloSeguridad
{
    public class clsAsignacionDeAplicaciones
    {
        clsConexion cn = new clsConexion();

        //funcion para obtener el nombre de usuario
        public string funcObtenerNombreUsuario(string UserName)
        {
            string NombreUsuario = "";
            try
            {
                OdbcCommand command = new OdbcCommand("select LO.nombreCompleto_login from LOGIN LO where LO.usuario_login ='" + UserName + "';", cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                NombreUsuario = reader.GetString(0);
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("CapaModelo Error al consular ObtenerNombreUsuario:  " + ex);
            }
            return NombreUsuario;
        }

        //Llenar las listas de permisos y aplicaciones
        public OdbcDataReader funcConsultaperfil()
        {
            try
            {
                string strConsulta = "SELECT nombre_perfil FROM perfil where estado_perfil = 1;";
                OdbcCommand command = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la vista de contenido.");
                Console.WriteLine("CapaModelo Error al consular 'consultaPerfil':  " + ex);
                return null;
            }
        }
   
        public OdbcDataReader funcConsultaaplicacion()
        {
            try
            {
                string strConsulta = "SELECT nombre_aplicacion FROM aplicacion where estado_aplicacion = 1;";
                OdbcCommand command = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la vista de contenido.");
                Console.WriteLine("CapaModelo Error al consular 'consultaAplicacion':  " + ex);
                return null;
            }
        }
        public OdbcDataReader funcConsultaperfilasignado(string txtUsuario)
        {
            try
            {
                string strConsulta = "select P.nombre_perfil FROM PERFIL P INNER JOIN PERFIL_USUARIO PU on P.pk_id_perfil = PU.fk_idperfil_perfil_usuario INNER JOIN LOGIN LO on PU.fk_idusuario_perfil_usuario = LO.pk_id_login where LO.usuario_login = '" + txtUsuario + "';";

                OdbcCommand command = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la vista de contenido.");
                Console.WriteLine("CapaModelo Error al consular 'consultaPerfil':  " + ex);
                return null;
            }
        }
        public OdbcDataReader funcConsultaaplicacionasignada(string txtUsuario)
        {
            try
            {
                string strConsulta = "select AP.nombre_aplicacion FROM APLICACION AP INNER JOIN APLICACION_USUARIO APU on AP.pk_id_aplicacion = APU.fk_idaplicacion_aplicacion_usuario INNER JOIN LOGIN LO on APU.fk_idlogin_aplicacion_usuario = LO.pk_id_login where LO.usuario_login = '" + txtUsuario + "';";
                OdbcCommand command = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la vista de contenido.");
                Console.WriteLine("CapaModelo Error al consular 'consultaAplicacion':  " + ex);
                return null;
            }
        }
        public OdbcDataReader funcConsultadbper(string txtUsuario, string txtAplicacion)
        {
            try
            {
                //Console.WriteLine(txtUsuario + " " + txtAplicacion);
                string strConsulta = "insert into perfil_usuario (fk_idusuario_perfil_usuario, fk_idperfil_perfil_usuario) values ((select pk_id_login from login where (usuario_login='" + txtUsuario + "')),(select pk_id_perfil from perfil where (nombre_perfil='" + txtAplicacion + "'))); ";
                OdbcCommand command = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la vista de contenido.");
                Console.WriteLine("CapaModelo Error al consular 'consultaAplicacion':  " + ex);
                return null;
            }

        }
        public OdbcDataReader funcConsultadb(string txtUsuario, string txtAplicacion)
        {
            try
            {
                string strConsulta = "insert into aplicacion_usuario (fk_idlogin_aplicacion_usuario, fk_idaplicacion_aplicacion_usuario, fk_idpermiso_aplicacion_usuario)  values((select pk_id_login from login where (usuario_login = '" + txtUsuario + "')), (select pk_id_aplicacion from aplicacion where(nombre_aplicacion= '" + txtAplicacion + "')), (SELECT MAX(pk_id_permiso) FROM permiso)); ";
                OdbcCommand command = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en insertar adb.");
                Console.WriteLine("CapaModelo Error al consular 'consultaAplicacion':  " + ex);
                return null;
            }

        }
        public OdbcDataReader consulta_aplicaciones_activas(string txtUsuario, string txtAplicacion)
        {
            try
            {
                string strConsulta = "select * from permiso where ((pk_id_permiso = (select pk_id_permiso from permiso p inner join aplicacion_usuario apu on p.pk_id_permiso = apu.fk_idpermiso_aplicacion_usuario inner join aplicacion ap on ap.pk_id_aplicacion = apu.fk_idaplicacion_aplicacion_usuario inner join login lo on lo.pk_id_login = apu.fk_idlogin_aplicacion_usuario  where lo.usuario_login = '"+txtUsuario+"' and ap.nombre_aplicacion= '"+txtAplicacion+"'))); ";
                OdbcCommand command = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio en consulta de activas.");
                Console.WriteLine("CapaModelo Error al consular 'consultaAplicacion':  " + ex);
                return null;
            }

        }
        public OdbcDataReader funcConsultapermisos()
        {
            try
            {
                string strConsulta = "INSERT INTO permiso (insertar_permiso, modificar_permiso, eliminar_permiso, consultar_permiso, imprimir_permiso) VALUES ('0', '0', '0', '0', '0'); ";
                OdbcCommand command = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la vista de contenido.");
                Console.WriteLine("CapaModelo Error al consular 'consultaAplicacion':  " + ex);
                return null;
            }

        }
        public OdbcDataReader funcEliminaradb(string txtUsuario, string txtAplicacion)
        {
            try
            {
                string strConsulta = "delete from aplicacion_usuario where (fk_idlogin_aplicacion_usuario = (select pk_id_login from login where (usuario_login = '" + txtUsuario + "')) and  fk_idaplicacion_aplicacion_usuario = (select pk_id_aplicacion from aplicacion where(nombre_aplicacion= '" + txtAplicacion + "')));";
                OdbcCommand command = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un eliminar.");
                Console.WriteLine("CapaModelo Error al eliminar 'eliminaradb':  " + ex);
                return null;
            }
        }
        public OdbcDataReader funcEliminardbper(string txtUsuario, string txtAplicacion)
        {
            try
            {
               
                string strConsulta = "delete from perfil_usuario where ((fk_idusuario_perfil_usuario = (select pk_id_login from login where (usuario_login='" + txtUsuario + "'))) and (fk_idperfil_perfil_usuario = (select pk_id_perfil from perfil where (nombre_perfil='" + txtAplicacion + "'))));";
                OdbcCommand command = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al eliminar.");
                Console.WriteLine("CapaModelo Error al eliminar 'eliminardbper':  " + ex);
                return null;
            }

        }
        public OdbcDataReader funcActualizacion_aplicaciones_activas(string txtUsuario, string txtAplicacion, string insertar, string modificar, string eliminar, string consultar, string imprimir, string txtAplicacionid)
        {
            try
            {
                //Console.WriteLine(txtUsuario + " " + txtAplicacion + " " +insertar + " " +modificar + " " +eliminar + " " +consultar + " " +imprimir);
                string strConsulta = "UPDATE permiso SET insertar_permiso = '" + insertar + "', modificar_permiso = '" + modificar + "', eliminar_permiso = '" + eliminar + "', consultar_permiso = '" + consultar + "', imprimir_permiso = '" + imprimir + "' WHERE (pk_id_permiso = '"+txtAplicacionid+"');";
                OdbcCommand command = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio en actualizacion.");
                Console.WriteLine("CapaModelo Error al actualizar 'actualizacion_aplicaciones_activas':  " + ex);
                return null;
            }

        }
    }
}

