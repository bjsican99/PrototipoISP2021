using CapaControladorSeguridad;
using CapaModeloSeguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaSeguridad.Formularios.Mantenimientos
{
    public partial class frmModificarPermisos : Form
    {
        string aplicacionid;
        clsControlAsignacionDeAplicaciones asignacionDeAplicaciones = new clsControlAsignacionDeAplicaciones();
        clsVariableGlobal glo = new clsVariableGlobal();

        public frmModificarPermisos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cinsertar = "0"; 
            string cmodificar = "0";
            string celiminar = "0";
            string cconsultar = "0";
            string cimprimir = "0";
            if (cb_insertar.Checked == true)
            {
                 cinsertar = "1";
            }
            if (cb_modificar.Checked == true)
            {
                 cmodificar = "1";
            }
            if (cb_eliminar.Checked == true)
            {
                 celiminar = "1";
            }
            if (cb_consultar.Checked == true)
            {
                 cconsultar = "1";
            }
            if (cb_imprimir.Checked == true)
            {
                 cimprimir = "1";
            }
            string usuario = glo.usuariog;
            string valor = glo.aplica;

            OdbcDataReader mostrar = asignacionDeAplicaciones.funcCambio_aplicaciones_activas(usuario,valor,cinsertar, cmodificar,celiminar,cconsultar,cimprimir, aplicacionid);
            try
            {
                MessageBox.Show("Actualizacion con exito");
                this.Close();
        
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }


        public void mostrar_consulta_aplicaciones_activas()
        {
            string usuario = "";
              usuario = glo.usuariog;
            string valor = "";
                valor = glo.aplica;
            Console.WriteLine("lo que recibe es:   "+usuario +"  "+valor);

            OdbcDataReader mostrar = asignacionDeAplicaciones.funcConsulta_aplicaciones_activas(usuario, valor);
            try
            {
                while (mostrar.Read())
                {
                    string idapli = mostrar.GetString(0);
                    string insertar = mostrar.GetString(1);
                    string modificar = mostrar.GetString(2);
                    string eliminar = mostrar.GetString(3);
                    string consultar = mostrar.GetString(4);
                    string imprimir = mostrar.GetString(5);
                    aplicacionid = idapli;

                    if (insertar == "1")
                    {
                        cb_insertar.Checked = true;
                    }
                    if (modificar == "1")
                    {
                        cb_modificar.Checked = true;
                    }
                    if (eliminar == "1")
                    {
                        cb_eliminar.Checked = true;
                    }
                    if (consultar == "1")
                    {
                        cb_consultar.Checked = true;
                    }
                    if (imprimir == "1")
                    {
                        cb_imprimir.Checked = true;
                    }

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmModificarPermisos_Load(object sender, EventArgs e)
        {
            //consulta de permiso
            mostrar_consulta_aplicaciones_activas();
            
        }
    }
}
