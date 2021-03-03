using CapaControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Mantenimientos
{
    public partial class frmMantenimientoLinea : Form
    {
        string UsuarioAplicacion;
        clsValidaciones validaciones = new clsValidaciones();
        public frmMantenimientoLinea(string usuario)
        {
            InitializeComponent();
            rbtnHabilitado.Checked = true;
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //llenado de  parametros para la aplicacion 
            navegador1.aplicacion = 301;
            navegador1.tbl = "lineas";
            navegador1.campoEstado = "estatus_linea";

            //se agregan los componentes del formulario a la lista tipo control
            foreach (Control C in this.Controls)
            {
                if (C.Tag != null)
                {
                    if (C.Tag.ToString() == "saltar")
                    {

                    }
                    else
                    {
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
            }

            navegador1.control = lista;
            navegador1.formulario = this;
            navegador1.DatosActualizar = dgvLinea;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "HTML/Ayudas.chm";
            navegador1.ruta = "Ayuda_Mantenimiento_Centros.html";
            rbtnHabilitado.Checked = true;
            rbtnDeshabilidado.Checked = false;
        }

        private void rbtnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstatusLinea.Text = "1";
        }

        private void rbtnDeshabilidado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstatusLinea.Text = "0";
        }

        private void txtNombreLinea_TextChanged(object sender, EventArgs e)
        {
            txtEstatusLinea.Text = "1";
        }

        private void txtNombreLinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.CamposNumerosYLetras(e);
        }
    }
}
