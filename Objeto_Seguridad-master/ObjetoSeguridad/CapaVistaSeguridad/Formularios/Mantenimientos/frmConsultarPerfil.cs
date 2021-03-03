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
    public partial class frmConsultarPerfil : Form
    {
        clsControladorPerfil Controlador = new clsControladorPerfil();
        public frmConsultarPerfil()
        {
            InitializeComponent();
            LlenarDgv();
        }
        DataTable Dt = new DataTable();
        public void LlenarDgv()
        {
            dgvPerfilDisponibles.Rows.Clear();
            Dt.Columns.Add("Codigo", typeof(string));
            Dt.Columns.Add("Nombre_Perfil", typeof(string));
            Dt.Columns.Add("Descripcion", typeof(string));
            OdbcDataReader mostrar = Controlador.funcConsulta("perfil","estado_perfil");
            try
            {
                while (mostrar.Read())
                {
                    DataRow row;
                    row = Dt.NewRow();
                    row["Codigo"] = mostrar.GetString(0);
                    row["Nombre_Perfil"] = mostrar.GetString(1);
                    row["Descripcion"] = mostrar.GetString(2);
                    Dt.Rows.Add(row);
                }
                dgvPerfilDisponibles.DataSource = Dt;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPerfilDisponibles.Rows.Count == 0)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == " ")
            {
                dgvPerfilDisponibles.Rows.Clear();
                dgvPerfilDisponibles.DataSource = Dt;
                return;
            }

            Dt.DefaultView.RowFilter = $"Codigo LIKE '{txtCodigo.Text}%'";
        }

        private void txtPerfil_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == " ")
            {
                dgvPerfilDisponibles.Rows.Clear();
                dgvPerfilDisponibles.DataSource = Dt;
                return;
            }

            Dt.DefaultView.RowFilter = $"Nombre_Perfil LIKE '{txtPerfil.Text}%'";
        }
    }
}
