using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaSeguridad.Formularios.Mantenimientos
{
    public partial class frmModulo : Form
    {

        string UsuarioAplicacion;
        

        public frmModulo(string usuario)
        {
            InitializeComponent();
            rbtnHabilitado.Checked = true;
            UsuarioAplicacion = usuario;
            navegadorModulo.Usuario = UsuarioAplicacion;
        }

        private void dtl_registro_aplicacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lb_codigo_aplicacion_Click(object sender, EventArgs e)
        {

        }

        private void lb_registros_aplicacion_Click(object sender, EventArgs e)
        {

        }

        

        private void lb_infome_de_aplicacion_Click(object sender, EventArgs e)
        {

        }

        private void lb_nombre_de_aplicacion_Click(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {

            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //List<Control> lista = new List<Control>();
            navegadorModulo.aplicacion = 8;
            navegadorModulo.tbl = "modulo";
            navegadorModulo.campoEstado = "estado_modulo";

            //se agregan los componentes del formulario a la lista tipo control

            foreach (Control C in this.Controls)
            {
                if (C.Tag != null)
                {
                    //  MessageBox.Show(""+C.Name)
                    if (C is TextBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is ComboBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is DateTimePicker)
                    {
                        lista.Add(C);

                    }
                }
                
            }
            navegadorModulo.control = lista;
            navegadorModulo.formulario = this;
            navegadorModulo.DatosActualizar = dtlModulo;
            navegadorModulo.procActualizarData();
            navegadorModulo.procCargar();
            navegadorModulo.ayudaRuta = "AyudasSeguridad/Modulo/ayuda.chm";
            navegadorModulo.ruta = "Ayuda-Modulo.html";
            
        }

        private void rbtnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
        }

        private void rbtnDesabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "0";
        }

        private void txtNombreModulo_TextChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
        }
    }
}
