using CapaControladorSeguridad;
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
    public partial class frmMantenimientoPerfil : Form
    {
        clsControladorPerfil Controlador = new clsControladorPerfil();
        clsVistaBitacora cn = new clsVistaBitacora();
        string UsuarioAplicacion;
        public frmMantenimientoPerfil(string usuario)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            inicio();
        }

        public void inicio()
        {
            txtEstado.Text = "1";
            rbtnHabilitado.Checked = true;
            rbtnDesabilitado.Checked = false;
        }
        public bool Validar()
        {
            if (txtCodPerfil.Text== "")
            {
                MessageBox.Show("Debe de llenar el campo Nombre Perfil");
                return false;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe de llenar el campo Descripción");
                return false;
            }
            return true;
        }

        private void frmMantenimientoPerfil_Load(object sender, EventArgs e)
        {
            inicio();
        }

        private void Navegador_Load(object sender, EventArgs e)
        {
           // ValorRadioboton();
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //List<Control> lista = new List<Control>();
            navegador1.aplicacion = 4;
            navegador1.tbl = "perfil";
            navegador1.campoEstado = "estado_perfil";

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

            navegador1.control = lista;
            navegador1.formulario = this;
            navegador1.DatosActualizar = dgvperfil;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudasSeguridad/Mantenimiento_Perfil/Mantenimiento_Perfil.chm";
            navegador1.ruta = "Mantenimiento-Perfil.html";

        }

        private void rbtnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
        }

        private void rbtnDesabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "0";
        }

        private void txtNombrePerfil_TextChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
        }
    }
}
