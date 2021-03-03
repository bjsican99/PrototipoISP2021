using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Clase para ejecutar el query de las consultas 
namespace CapaModeloSeguridad
{
    public class clsSentencia
    {
        clsConexion cn = new clsConexion();

        public static OdbcCommand funcObtenerComando(string sComando, OdbcConnection conexion, bool bEsSP = false)
        {
            dynamic cmd = new OdbcCommand(sComando, conexion);
            if (bEsSP)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            return cmd;
        }
        public bool funcEjecutarQuery(string sConsulta, bool bEsSP = false)
        {
            bool bRespuesta = false;

            if (sConsulta.Trim().Length == 0)
            {
                return false;
            }

            OdbcConnection con = cn.conexion();

            using (OdbcCommand cmd = funcObtenerComando(sConsulta, con, bEsSP))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    bRespuesta = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    bRespuesta = false;
                }
                finally
                {
                     cn.desconexion(con);
                }
            }
            return bRespuesta;
        }
    }
}
