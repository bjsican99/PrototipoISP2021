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
    public partial class frmAgregarAplicacion : Form
    {
        clsControladorPerfil Controlador = new clsControladorPerfil();
        public frmAgregarAplicacion()
        {
            InitializeComponent();
            LlenarDgv();
        }
        DataTable Dt = new DataTable();
        public void LlenarDgv()
        {
            dgvAplicaciones.Rows.Clear();
            Dt.Columns.Add("Codigo", typeof(string));
            Dt.Columns.Add("Nombre_Aplicación", typeof(string));
            Dt.Columns.Add("Descripcion", typeof(string));
            OdbcDataReader mostrar = Controlador.funcConsulta("aplicacion","estado_aplicacion");
            try
            {
                while (mostrar.Read())
                {
                    //dgvAplicaciones.Rows.Add(mostrar.GetString(0), mostrar.GetString(2), mostrar.GetString(3);
                    DataRow row;
                    row = Dt.NewRow();
                    row["Codigo"] = mostrar.GetString(0);
                    row["Nombre_Aplicación"] = mostrar.GetString(2);
                    row["Descripcion"] = mostrar.GetString(3);
                    Dt.Rows.Add(row);
                }
                dgvAplicaciones.DataSource = Dt;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvAplicaciones.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar la Aplicación deseada");
               // return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == " ")
            {
                dgvAplicaciones.Rows.Clear();
                dgvAplicaciones.DataSource = Dt;
                return;
            }

            Dt.DefaultView.RowFilter = $"Codigo LIKE '{txtCodigo.Text}%'";
        }

        private void txtAplicacion_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == " ")
            {
                dgvAplicaciones.Rows.Clear();
                dgvAplicaciones.DataSource = Dt;
                return;
            }

            Dt.DefaultView.RowFilter = $"Nombre_Aplicación LIKE '{txtAplicacion.Text}%'";
        }
    }
}
