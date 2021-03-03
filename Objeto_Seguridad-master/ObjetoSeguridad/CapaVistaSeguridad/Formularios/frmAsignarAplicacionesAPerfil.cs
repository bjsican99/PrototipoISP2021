/*
 * Bryan Estuardo Mazariegos Davila
 * 0901-17-1001
 */
using CapaControladorSeguridad;
using CapaVistaSeguridad.Formularios.Mantenimientos;
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

namespace CapaVistaSeguridad.Formularios
{
    public partial class frmAsignarAplicacionesAPerfil : Form
    {
        //instancia la clse controlador
        clsControladorPerfil Controlador = new clsControladorPerfil();
        //instancia a la clase de bitacora
        clsVistaBitacora cn = new clsVistaBitacora();
        public frmAsignarAplicacionesAPerfil()
        {
            InitializeComponent();
            inicio();
        }
        public void inicio()
        {
            txtPerfil.Enabled = false;
            txtAplicacion.Enabled = false;
            btnAplicación.Enabled = false;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSeleccionar.Enabled = false;
            txtAplicacion.Text = "";
            chkIngreso.Checked = false;
            chkModificar.Checked = false;
            chkEliminar.Checked = false;
            chkConsultar.Checked = false;
            chkImprimir.Checked = false;
        }

        public void LlenarDgv()
        {
            dgvAppAsignadas.Rows.Clear();
            OdbcDataReader mostrar = Controlador.funcConsulta_ApPerfil(CodPerfil);
            try
            {
                while (mostrar.Read())
                {
                    dgvAppAsignadas.Rows.Add(mostrar.GetString(0), mostrar.GetString(1));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }
        //con estas 5 variables se guardan lo parametros de si esta en 1  o 0 los permisos donde
        //1 es activo y o es desactivado 
        int Permisos1;
        int Permisos2;
        int Permisos3;
        int Permisos4;
        int Permisos5;
        public void checkbox()
        {
            if(chkIngreso.Checked==true)
            {
                Permisos1 = 1;
            }
            else
            {
                Permisos1 = 0;
            }
            if (chkModificar.Checked == true)
            {
                Permisos2 = 1;
            }
            else
            {
                Permisos2= 0;
            }
            if (chkEliminar.Checked == true)
            {
                Permisos3 = 1;
            }
            else
            {
                Permisos3 = 0;
            }
            if (chkConsultar.Checked == true)
            {
                Permisos4 = 1;
            }
            else
            {
                Permisos4 = 0;
            }
            if (chkImprimir.Checked == true)
            {
                Permisos5 = 1;
            }
            else
            {
                Permisos5 = 0;
            }
        }
        //GUadardan los codigos que seran utilizados en el programa
        string CodAplicacion;
        string CodPerfil;
        string CodPermisos;
        private void btnAplicación_Click(object sender, EventArgs e)
        {
            frmAgregarAplicacion agregarAplicacion = new frmAgregarAplicacion();
            if(agregarAplicacion.ShowDialog() == DialogResult.OK)
            {
                CodAplicacion = agregarAplicacion.dgvAplicaciones.Rows[agregarAplicacion.dgvAplicaciones.CurrentRow.Index].Cells[0].Value.ToString();
                txtAplicacion.Text = agregarAplicacion.dgvAplicaciones.Rows[agregarAplicacion.dgvAplicaciones.CurrentRow.Index].Cells[1].Value.ToString();
                cn.insert("Consulta Aplicaciones", 3);
            }
            
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmConsultarPerfil consultarPerfil = new frmConsultarPerfil();
            if (consultarPerfil.ShowDialog() == DialogResult.OK)
            {
                CodPerfil = consultarPerfil.dgvPerfilDisponibles.Rows[consultarPerfil.dgvPerfilDisponibles.CurrentRow.Index].Cells[0].Value.ToString();
                txtPerfil.Text = consultarPerfil.dgvPerfilDisponibles.Rows[consultarPerfil.dgvPerfilDisponibles.CurrentRow.Index].Cells[1].Value.ToString();
                cn.insert("Consulta Perfiles", 3);
                if (txtPerfil.Text != "")
                {
                    LlenarDgv();
                    btnAplicación.Enabled = true;
                    btnSeleccionar.Enabled = true;
                    dgvAppAsignadas.Enabled = true;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSeleccionar.Enabled = false;
            btnPerfil.Enabled = true;
            btnAplicación.Enabled = true;
            dgvAppAsignadas.Enabled = false;
        }
        public bool Validar()
        {
            checkbox();
            if (txtPerfil.Text == "")
            {
                MessageBox.Show("Debe de seleccionar un Perfil");
                return false;
            }
            if (txtAplicacion.Text == "")
            {
                MessageBox.Show("Debe de seleccionar una Áplicació");
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicio();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
            if (dgvAppAsignadas.Rows.Count != 0)
            {
                CodAplicacion= dgvAppAsignadas.Rows[dgvAppAsignadas.CurrentRow.Index].Cells[0].Value.ToString();
                txtAplicacion.Text = dgvAppAsignadas.Rows[dgvAppAsignadas.CurrentRow.Index].Cells[1].Value.ToString();
                OdbcDataReader mostrar = Controlador.funcConsulta_permisos(CodAplicacion, CodPerfil);
                if (mostrar.Read())
                {
                    CodPermisos = mostrar.GetString(0);
                    if (mostrar.GetString(1) == "1")
                    {
                        chkIngreso.Checked = true;
                    }
                    else
                    {
                        chkIngreso.Checked = false;
                    }
                    if (mostrar.GetString(2) == "1")
                    {
                        chkModificar.Checked = true;
                    }
                    else
                    {
                        chkModificar.Checked = false;
                    }
                    if (mostrar.GetString(3) == "1")
                    {
                        chkEliminar.Checked = true;
                    }
                    else
                    {
                        chkEliminar.Checked = false;
                    }
                    if (mostrar.GetString(4) == "1")
                    {
                        chkConsultar.Checked = true;
                    }
                    else
                    {
                        chkConsultar.Checked = false;
                    }
                    if (mostrar.GetString(5) == "1")
                    {
                        chkImprimir.Checked = true;
                    }
                    else
                    {
                        chkImprimir.Checked = false;
                    }
                }
            }else
            {
                MessageBox.Show("Debe Seleccionar una fila");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (Controlador.insertarpermisosPerfil(Permisos1, Permisos2, Permisos3, Permisos4, Permisos5) == null)
                {
                    MessageBox.Show("NO se pudo Guardar los datos Contacte al encargado de sistemas");
                }
                else
                {
                    if (Controlador.funcInsertarApliPerfil(CodAplicacion, CodPerfil) == null)
                    {
                        MessageBox.Show("NO se pudo Guardar los datos Contacte al encargado de sistemas");
                    }
                    else
                    {
                        MessageBox.Show("Datos guardados");
                        cn.insert("Insercion de Aplicacion a perfil", 3);
                        inicio();
                        LlenarDgv();
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnAplicación.Enabled = false;
            if (Validar())
            {
                if (Controlador.funcModificarAppPerfil(Permisos1, Permisos2, Permisos3, Permisos4, Permisos5,CodPermisos) == null)
                {
                    MessageBox.Show("NO se pudo Guardar los datos Contacte al encargado de sistemas");
                }
                else
                {
                    MessageBox.Show("Datos Modificados");
                    cn.insert("Modificación de Aplicacion a perfil", 3);
                    inicio();
                    LlenarDgv();
                }

            }
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnAplicación.Enabled = false;
            if(Validar())
            {
                if (Controlador.funcEliminarrAppPerfil(CodPermisos) == null)
                {
                    MessageBox.Show("NO se pudo eliminar los datos Contacte al encargado de sistemas");
                }
                else
                {
                    MessageBox.Show("Datos Eliminados");
                    cn.insert("Eliminaciones de permisos Aplicacion a perfil", 3);
                    inicio();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasSeguridad/Asignacion_de_Aplicaciones perfil/Ayuda Asignacion de Aplicaciones perfil.chm", "Asignación-de-aplicaciones-perfil.html");
        }
    }
}
