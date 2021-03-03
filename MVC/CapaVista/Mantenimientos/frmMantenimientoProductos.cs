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
    
    public partial class frmMantenimientoProductos : Form
    {
        string UsuarioAplicacion;
        clsControlarodMantenimientos controlador = new clsControlarodMantenimientos();
        clsValidaciones validaciones = new clsValidaciones();
        public frmMantenimientoProductos(string usuario)
        {
            InitializeComponent();
            rbtnHabilitado.Checked = true;
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            CargarLineaCombo();
            CargarMarcaCombo();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //llenado de  parametros para la aplicacion 
            navegador1.aplicacion = 303;
            navegador1.tbl = "productos";
            navegador1.campoEstado = "estatus_producto";

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
            navegador1.DatosActualizar = dgvProducto;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "HTML/Ayudas.chm";
            navegador1.ruta = "Ayuda_Mantenimiento_Centros.html";
            rbtnHabilitado.Checked = true;
            rbtnDeshabilidado.Checked = false;
        }

        private void cbxCodLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCodLinea.SelectedIndex != -1)
            {
                txtCodLinea.Text = cbxCodLinea.SelectedValue.ToString();
            }
        }

        //llenar los combobox y llevarlos a cbxCodLinea
        public void CargarLineaCombo()
        {
            cbxCodLinea.ValueMember = "codigo_linea";
            cbxCodLinea.DisplayMember = "nombre_linea";
            cbxCodLinea.DataSource = controlador.funcObtenerCamposCombobox("codigo_linea", "nombre_linea", "lineas", "estatus_linea");
            cbxCodLinea.SelectedIndex = -1;
        }
        //obtener los datos de marca y llevarlos al cobxCodMarca
        public void CargarMarcaCombo()
        {
            cbxCodMarca.ValueMember = "codigo_marca";
            cbxCodMarca.DisplayMember = "nombre_marca";
            cbxCodMarca.DataSource = controlador.funcObtenerCamposCombobox("codigo_marca", "nombre_marca", "marcas", "estatus_marca");
            cbxCodMarca.SelectedIndex = -1;
        }

        private void cbxCodMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCodMarca.SelectedIndex != -1)
            {
                txtCodMarca.Text = cbxCodMarca.SelectedValue.ToString();
            }
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            txtestatus.Text = "1";
        }

        private void rbtnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtestatus.Text = "1";
        }

        private void rbtnDeshabilidado_CheckedChanged(object sender, EventArgs e)
        {
            txtestatus.Text = "0";
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.CamposNumerosYLetras(e);
        }

        private void txtExistenciaProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.Camposdecimales(e);
        }
    }
}
