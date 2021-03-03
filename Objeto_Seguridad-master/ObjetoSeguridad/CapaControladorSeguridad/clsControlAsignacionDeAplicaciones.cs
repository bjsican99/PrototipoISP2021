using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloSeguridad;

namespace CapaControladorSeguridad
{
    public class clsControlAsignacionDeAplicaciones
    {
        clsAsignacionDeAplicaciones asignacionDeAplicaciones = new clsAsignacionDeAplicaciones();


        public string funcNombreUsuario(string UserName)
        {
            return asignacionDeAplicaciones.funcObtenerNombreUsuario(UserName);
        }

        //Obtener los datos de la tabla perfil
        public OdbcDataReader funcConsulta_perfiles()
        {
            return asignacionDeAplicaciones.funcConsultaperfil();
        }
        //Obtener los datos de la tabla aplicacion.
        public OdbcDataReader funcConsulta_aplicaciones()
        {
            return asignacionDeAplicaciones.funcConsultaaplicacion();
        }
        public OdbcDataReader funcConsulta_perfiles_asignados(string UserName)
        {
            return asignacionDeAplicaciones.funcConsultaperfilasignado(UserName);
        }
        //Obtener los datos de la tabla aplicacion.
        public OdbcDataReader funcConsulta_aplicaciones_asignadas(string UserName)
        {
            return asignacionDeAplicaciones.funcConsultaaplicacionasignada(UserName);
        }
        public OdbcDataReader funcConsulta_adb(string UserName, string Aplicacion)
        {
            return asignacionDeAplicaciones.funcConsultadb(UserName, Aplicacion);
        }
        public OdbcDataReader funcConsulta_adbper(string UserName, string Aplicacion)
        {
            return asignacionDeAplicaciones.funcConsultadbper(UserName, Aplicacion);
        }
        public OdbcDataReader funcEliminar_adb(string UserName, string Aplicacion)
        {
            return asignacionDeAplicaciones.funcEliminaradb(UserName, Aplicacion);
        }
        public OdbcDataReader funcEliminar_adbper(string UserName, string Aplicacion)
        {
            return asignacionDeAplicaciones.funcEliminardbper(UserName, Aplicacion);
        }
        public OdbcDataReader funcConsultapermiso()
        {
            return asignacionDeAplicaciones.funcConsultapermisos();
        }
        public OdbcDataReader funcConsulta_aplicaciones_activas(string UserName, string Aplicacion)
        {
            return asignacionDeAplicaciones.consulta_aplicaciones_activas(UserName, Aplicacion);
        }
        public OdbcDataReader funcCambio_aplicaciones_activas(string UserName, string Aplicacion, string insertar, string modificar, string eliminar, string consultar, string imprimir, string apliid)
        {
            return asignacionDeAplicaciones.funcActualizacion_aplicaciones_activas(UserName, Aplicacion, insertar, modificar,eliminar,consultar,imprimir, apliid);
        }
    }
}
