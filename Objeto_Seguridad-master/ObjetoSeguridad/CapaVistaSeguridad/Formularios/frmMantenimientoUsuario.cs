using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorSeguridad;

namespace CapaVistaSeguridad.Formularios.Mantenimientos
{
    public partial class frmMantenimientoUsuario : Form
    {
        String ap = "aplicacion";

        string UsuarioAplicacion;

        public frmMantenimientoUsuario(string usuario)
        {
            InitializeComponent();
            
            rbtnHabilitado.Checked = true;
            
            UsuarioAplicacion = usuario;
            navegadorMUsuario.Usuario = UsuarioAplicacion;
        }

     

        
        private void dtl_registro_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void navegadorMUsuario_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //List<Control> lista = new List<Control>();
            navegadorMUsuario.aplicacion = 2;
            navegadorMUsuario.tbl = "login";
            navegadorMUsuario.campoEstado = "estado_login";

            //se agregan los componentes del formulario a la lista tipo control

            foreach (Control C in this.Controls)
            {
               
                if (C.Tag != null)
                {
                    if(C.Tag.ToString() == "saltar")
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
                    //  MessageBox.Show(""+C.Name)
                    
                }


            }

            navegadorMUsuario.control = lista;
            navegadorMUsuario.formulario = this;
            navegadorMUsuario.DatosActualizar = dtlRegistroUsuario;
            navegadorMUsuario.procActualizarData();
            navegadorMUsuario.procCargar();
            navegadorMUsuario.ayudaRuta = "AyudasSeguridad/Usuario/ayuda.chm";
            navegadorMUsuario.ruta = "Ayuda-Usuario.html";
            habilitar();

        }

        private void rbtnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
        }

        private void rbtnDesabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "0";
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
            habilitar();
        }

        private void frmMantenimientoUsuario_Load(object sender, EventArgs e)
        {

        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           if(txtPassword.Text != "")
            {
                var key = "b14ca5898a4e4133bbce2ea2315a1916";
                clsEncriptar encriptar = new clsEncriptar();
                string Encriptado = encriptar.funcEncryptString(key, txtPassword.Text);
                txtEncriptado.Text = Encriptado;
            }
            
        }

        private void txtEncriptado_TextChanged_1(object sender, EventArgs e)
        {
            if(txtEncriptado.Text != "")
            {
                var key = "b14ca5898a4e4133bbce2ea2315a1916";
                clsEncriptar encriptar = new clsEncriptar();
                string Desencriptado = encriptar.funcDecryptString(key, txtEncriptado.Text);
                txtPassword.Text = Desencriptado;
            }
            
        }

        public void habilitar()
        {
            if(txtUsuario.Enabled == true)
            {
                txtPassword.Enabled = true;
            }
            else
            {
                txtPassword.Enabled = false;
                txtPassword.Text = "";
            }
        }
    }
}
