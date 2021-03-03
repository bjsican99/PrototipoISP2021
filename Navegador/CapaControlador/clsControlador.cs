using CapaModeloNavegador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorNavegador
{
    public class clsControlador
    {
        clsSentencias sn = new clsSentencias();

        public int funcCodigoMax(string tabla, string campo)
        {
            int codigo = sn.procInsertar(tabla, campo);

            return codigo;
        }

        public void procDatosInsertar(string tabla, List<string> lista,int aplicacion)
        {
            sn.procInsertarDatos(tabla, lista,aplicacion);
        }
        public void procDatosModificar(string tabla, List<string> campos, List<string> datos, int aplicacion)
        {
            sn.procModificar(tabla, campos, datos,aplicacion);
        }

        public DataTable funcEnviar(string tabla,string estado)
        {
            try
            {
                OdbcDataAdapter dt = sn.funcObtener(tabla,estado);
                DataTable table = new DataTable();
                dt.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Puede que los parametros seas erroneos, verifique los parametro enviados" + ex);
                return null;
            }

        }

       // --------------------------------------------------------------------------
        public bool funcEliminar(string tabla, string campo, string idTabla, string id,int aplicacion)
        {
        
            if (sn.procEliminar(tabla, campo, idTabla, id, aplicacion))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /////////////////////////
        public string funcVerficarTabla(string tabla)
        {
            string Mensaje = sn.procTablas(tabla);
            return Mensaje;
        }

        public List<string> funcVerficarCampo(string tabla)
        {
            List<string> Campos = sn.procCampos(tabla);
            return Campos;
        }
    }
}
