using CapaControladorSeguridad;
using CapaModeloSeguridad;
using CapaVistaSeguridad.Formularios.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaSeguridad.Formularios
{
    public partial class frmAsignacionDeAplicaciones : Form
    {
       public string valor, valor1, modificar_aplicacion, modificar_perfil, ultimo;
        clsControlAsignacionDeAplicaciones asignacionDeAplicaciones = new clsControlAsignacionDeAplicaciones();
        clsVariableGlobal glo = new clsVariableGlobal();
        frmModificarPermisos modipermisos = new frmModificarPermisos();
        public frmAsignacionDeAplicaciones()
        {
            InitializeComponent();
            inicio();
        }
        public void inicio()
        {
            txtUsuario.Text = "";
            txtNombreUsuario.Text = "";
            gbxUsuarioSelect.Enabled = true;
            gbxPerfilesyAplicaciones.Enabled = false;
            rbtnPerfiles.Checked = true;
            rbtnAplicaciones.Checked = false;
            dgvAplicacionesDisponibles.Enabled = true;
            dgvPerfilesDisponibles.Enabled = false;
            dgvAplicacionesAsignadas.Rows.Clear();
            dgvPerfilesAsignados.Rows.Clear();
            //funcion de llenado de lsvPerfilesDisponibles.Items perfiles pendiente
            //funcion de llenado de  lsvAplicacionesDisponibles.Items  aplicaciones pendiete
            // lsvAplicacionesasignadas.Items.Clear();
        }

        public void ControlRadioBoton()
        {
            if (rbtnPerfiles.Checked == true)
            {
                dgvAplicacionesDisponibles.Enabled = false;
                dgvPerfilesDisponibles.Enabled = true;
            }
            else
            {
                dgvPerfilesDisponibles.Enabled = false;
                dgvAplicacionesDisponibles.Enabled = true;
            }
        }
        public void mostrar_consulta_perfil()
        {
            OdbcDataReader mostrar = asignacionDeAplicaciones.funcConsulta_perfiles();
            try
            {
                while (mostrar.Read())
                {
                    dgvPerfilesDisponibles.Rows.Add(mostrar.GetString(0));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public void mostrar_consulta_perfil_asignado()
        {
            OdbcDataReader mostrar = asignacionDeAplicaciones.funcConsulta_perfiles_asignados(txtUsuario.Text);
            try
            {
                while (mostrar.Read())
                {
                    dgvPerfilesAsignados.Rows.Add(mostrar.GetString(0));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public void mostrar_consulta_aplicacion()
        {
            OdbcDataReader mostrar = asignacionDeAplicaciones.funcConsulta_aplicaciones();
            try
            {
                while (mostrar.Read())
                {
                    dgvAplicacionesDisponibles.Rows.Add(mostrar.GetString(0));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public void mostrar_consulta_aplicacion_asignada()
        {
            OdbcDataReader mostrar = asignacionDeAplicaciones.funcConsulta_aplicaciones_asignadas(txtUsuario.Text);
            try
            {
                while (mostrar.Read())
                {
                    dgvAplicacionesAsignadas.Rows.Add(mostrar.GetString(0));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public void insertar_adb()
        {
            OdbcDataReader mostrar = asignacionDeAplicaciones.funcConsulta_adb(txtUsuario.Text, valor);
            try
            {
    
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public void enviar_datos()
        {
            string apli1;
            if (dgvAplicacionesAsignadas.Rows.Count > 0)
            {
                apli1 = (dgvAplicacionesAsignadas.Rows[dgvAplicacionesAsignadas.CurrentRow.Index].Cells[0].Value.ToString());
                glo.aplica = apli1;
                glo.usuariog = txtUsuario.Text;
                frmModificarPermisos modPer = new frmModificarPermisos();
                modPer.Show();
            }
        }
        public void insertar_apermisos()
        {
            OdbcDataReader mostrar = asignacionDeAplicaciones.funcConsultapermiso();
            try
            {

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public void insertar_adbper()
        {
            OdbcDataReader mostrar = asignacionDeAplicaciones.funcConsulta_adbper(txtUsuario.Text, valor1);
            try
            {
            
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public void eliminar_adb()
        {
            OdbcDataReader mostrar = asignacionDeAplicaciones.funcEliminar_adb(txtUsuario.Text, modificar_aplicacion);
            try
            {

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public void eliminar_adbper()
        {
            OdbcDataReader mostrar = asignacionDeAplicaciones.funcEliminar_adbper(txtUsuario.Text, modificar_perfil);
            try
            {

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            inicio();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String NombreUsuario = asignacionDeAplicaciones.funcNombreUsuario(txtUsuario.Text);
            if (String.IsNullOrEmpty(NombreUsuario))
            {
                MessageBox.Show("Usuario " + txtUsuario.Text + " Invalido");
                txtUsuario.Text = "";
               
            }
            else
            {
                gbxUsuarioSelect.Enabled = false;
                gbxPerfilesyAplicaciones.Enabled = true;
                txtNombreUsuario.Text = NombreUsuario;
            }

            mostrar_consulta_aplicacion_asignada();
            mostrar_consulta_perfil_asignado();
        }

        private void rbtnPerfiles_CheckedChanged(object sender, EventArgs e)
        {
            ControlRadioBoton();
        }

        private void rbtnAplicaciones_CheckedChanged(object sender, EventArgs e)
        {
            ControlRadioBoton();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasSeguridad/Asignacion_de_Aplicaciones/Ayuda_Asignacion_de_Aplicaciones.chm", "Asignación-de-Aplicaciones.html");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            enviar_datos();

        }

        private void frmAsignacionDeAplicaciones_Load(object sender, EventArgs e)
        {
            mostrar_consulta_perfil();
            mostrar_consulta_aplicacion();
        }

        private void btnAgregarTodo_Click(object sender, EventArgs e)
        {
            string ApliAsig, PerfiAsig;
            int a, b;
            bool x = false;
            a = 0;
            b = 0;

            ApliAsig = (dgvAplicacionesDisponibles.Rows[dgvAplicacionesDisponibles.CurrentRow.Index].Cells[0].Value.ToString());
            PerfiAsig = (dgvPerfilesDisponibles.Rows[dgvPerfilesDisponibles.CurrentRow.Index].Cells[0].Value.ToString());
            //lsvAplicacionesasignadas.Items.Add (dgvAplicacionesDisponibles.Rows[dgvAplicacionesDisponibles.CurrentRow.Index].Cells[0].Value.ToString()); 
            if (rbtnAplicaciones.Checked)
            {
                for (a = 0; a < dgvAplicacionesAsignadas.Rows.Count; a++)
                   
                {
                  
                    if (ApliAsig == dgvAplicacionesAsignadas.Rows[a].Cells[0].Value.ToString())
                    {
                        x = true;
                        a = dgvPerfilesAsignados.Rows.Count + 10;
                    }
                }
                if (x == false)
                {
                    dgvAplicacionesAsignadas.Rows.Add(ApliAsig);
                    //aca jala para db
                    valor = ApliAsig;
                    insertar_apermisos();
                    insertar_adb();
                }
            }
          

            if (rbtnPerfiles.Checked)
            {
                for ( b = 0; b < dgvPerfilesAsignados.Rows.Count ; b++)
                     
                {
                    if (PerfiAsig == dgvPerfilesAsignados.Rows[b].Cells[0].Value.ToString())
                        {
                        x = true;
                        b = dgvPerfilesAsignados.Rows.Count + 10; 
                    }
                }
                if (x == false)
                {
                    dgvPerfilesAsignados.Rows.Add(PerfiAsig);
                    //aca jala db
                    valor1 = PerfiAsig;
                    insertar_adbper();
                }
            }
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string PerfiAsig1 = "";
            string ApliAsig1 = "";

            if (rbtnPerfiles.Checked)
            {
                if (dgvPerfilesAsignados.Rows.Count > 0)
                {
                    int rowIndexMain = dgvPerfilesAsignados.CurrentCell.RowIndex;
                    if (rowIndexMain >= 0)
                    {
                        PerfiAsig1 = (dgvPerfilesAsignados.Rows[dgvPerfilesAsignados.CurrentRow.Index].Cells[0].Value.ToString());
                    }
                    int rowIndex = dgvPerfilesAsignados.CurrentCell.RowIndex;
                    if (rowIndex >= 0)
                    {
                        modificar_perfil = PerfiAsig1;
                        dgvPerfilesAsignados.Rows.RemoveAt(rowIndex);
                        eliminar_adbper();
                    }
                }
            }
                
            if (rbtnAplicaciones.Checked)
                {
                if (dgvAplicacionesAsignadas.Rows.Count > 0)
                {
                   int rowIndexMaina = dgvAplicacionesAsignadas.CurrentCell.RowIndex;

                    if (rowIndexMaina >= 0)
                    {
                        ApliAsig1 = (dgvAplicacionesAsignadas.Rows[dgvAplicacionesAsignadas.CurrentRow.Index].Cells[0].Value.ToString());
                    }
                }
                if (dgvAplicacionesAsignadas.Rows.Count > 0)
                {
                   int  rowIndex1 = dgvAplicacionesAsignadas.CurrentCell.RowIndex;

                    if (rowIndex1 >= 0)
                    {
                        modificar_aplicacion = ApliAsig1;
                        dgvAplicacionesAsignadas.Rows.RemoveAt(rowIndex1);
                        eliminar_adb();
                    }
                }
                }
         
       
            } 
        }
    }


