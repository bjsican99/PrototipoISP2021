using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloSeguridad
{
    public class clsCodAplicacion
    {
        clsConexion cn = new clsConexion();
        //obtener el codigo de aplicaciones
        public string funcObtenerCodigo(string modulo)
        {
            string Maximo = "";
            try
            {
                OdbcCommand command = new OdbcCommand("Select max(pk_id_aplicacion+1) from aplicacion where fk_id_modulo = "+modulo+";", cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                Maximo = reader.GetString(0);
                reader.Close();
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("CapaModelo Error al consular funcObtenerCodigo:  " + ex);
                Maximo = "Vacio";
            }
            return Maximo;
        }

        public int funComprobarCodigo(string Codigo)
        {
            try
            {
                OdbcCommand command = new OdbcCommand("Select pk_id_aplicacion from aplicacion " +
                                                      "where pk_id_aplicacion = "+Codigo+";", cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("CapaModelo Error al consular funComprobarCodigo:  " + ex);
                return 0;
            }
        }
    }
}
