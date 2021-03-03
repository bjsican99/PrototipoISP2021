using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloSeguridad
{
    public class clsModeloBitacora
    {

        clsConexion cn = new clsConexion();
        String query;
        clsVariableUsuario vu = new clsVariableUsuario();

        public int UserSystem; //variable para mantener guardado el usuario 
        public int nombreAplicacion;
        public String accion;
        private string ip = "";

        //static int user = int.Parse(UserSystem);

        static DateTime now = DateTime.Now; //fecha actual y hora
        static string fecha = now.ToString("dd-MM-yyyy");


        public void funcInsertar(string acc, int app) // funcion para insertar en base de datos los movimientos
        {
            try
            {
                string strHostName = string.Empty;
                // Getting Ip address of local machine…
                // First get the host name of local machine.
                strHostName = Dns.GetHostName();
                // Then using host name, get the IP address list..
                IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);
                for (int i = 0; i < hostIPs.Length; i++)
                {
                    ip = hostIPs[i].ToString();
                }
                //label2.Text = "Nombre de la computadora: " + strHostName;

                UserSystem = vu.VariableUsu;

                string fecha = now.ToString("dd/MM/yyyy HH:mm:ss");

                query = "insert into bitacora(fk_idusuario_bitacora, fk_idaplicacion_bitacora, fechahora_bitacora, direccionhost_bitacora, nombrehost_bitacora, accion_bitacora) " +
                    "values( " + UserSystem + ", " + app + ", '" + fecha + "', '" + ip + "', '" + strHostName + "', '" + acc + "' )";
                OdbcCommand comando = new OdbcCommand(query, cn.conexion());
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en insertar ModeloBitacora  " + e);
            }

        }

        public void getUsuario(string usua)
        {
            try
            {
                int u = 0;

                OdbcCommand Query = new OdbcCommand("SELECT pk_id_login FROM login WHERE usuario_login = '" + usua + "';", cn.conexion());
                //Query.Parameters.AddWithValue("@usuario_login", usua);
                OdbcDataReader registro = Query.ExecuteReader();

                if (registro.Read())
                {
                    UserSystem = int.Parse(registro["pk_id_login"].ToString());
                    vu.VariableUsu = UserSystem;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error en getUsuario MOdeloBitacora  " + e);

            }

        }
    }
}