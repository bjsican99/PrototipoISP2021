using CapaControlador;
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

namespace CapaVista.Procesos
{
    public partial class frmExistencia : Form
    {
        clsControlarodMantenimientos controlador = new clsControlarodMantenimientos();
        clsValidaciones validaciones = new clsValidaciones();
        public frmExistencia()
        {
            InitializeComponent();
            txtSaldo.Enabled = false;
        }

        private void cmbCodBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodBodega.SelectedIndex != -1)
            {
                txtCodBodega.Text = cmbCodBodega.SelectedValue.ToString();
            }
        }

        //llenar los combobox y llevarlos a cbxCodLinea
        public void CargarBodegaCombo()
        {
            cmbCodBodega.ValueMember = "codigo_bodega";
            cmbCodBodega.DisplayMember = "nombre_bodega";
            cmbCodBodega.DataSource = controlador.funcObtenerCamposCombobox("codigo_bodega", "nombre_bodega", "bodegas", "estatus_bodega");
            cmbCodBodega.SelectedIndex = -1;
        }
        //obtener los datos de marca y llevarlos al cobxCodMarca
        public void CargarProductoCombo()
        {
            cmbCodProducto.ValueMember = "codigo_producto";
            cmbCodProducto.DisplayMember = "nombre_producto";
            cmbCodProducto.DataSource = controlador.funcObtenerCamposCombobox("codigo_producto", "nombre_producto", "productos", "estatus_producto");
            cmbCodProducto.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCodProducto_TextChanged(object sender, EventArgs e)
        {           
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.Camposdecimales(e);
        }

        private void cmbCodProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodProducto.SelectedIndex != -1)
            {
                txtCodProducto.Text = cmbCodProducto.SelectedValue.ToString();
            }

        }
        //consulta de saldo
        public void consulta()
        {
            OdbcDataReader reader = controlador.funcionConsultar(txtCodBodega.Text, txtCodProducto.Text);
            while (reader.Read())
            {
                txtSaldo.Text = reader[0].ToString();
            }
        }
    }
}
