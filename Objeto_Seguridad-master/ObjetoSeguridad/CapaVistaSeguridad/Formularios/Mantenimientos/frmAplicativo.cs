using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CapaModeloSeguridad;
using CapaControladorSeguridad;

namespace CapaVistaSeguridad.Formularios.Mantenimientos
{
    public partial class frmAplicativo : Form
    {
        private clsAplicativo aplicativo; // instanciar la clase aplicativo
        clsValidaciones validaciones = new clsValidaciones();
        private string sNombreAux, sDescAux; // variables para manejar los textbox
        private int iIDAux, iIDModAux; // Variable para manejar el id 

        // metodos para manejear los datos 
        clsControlAplicativo controlAplicativo=new clsControlAplicativo();
        public frmAplicativo()
        {
            InitializeComponent();
            CargarCombobox();
            cargarDatos();
            CargarBusqueda();
            BloquearBotones();

            // tooltips de los atributos 
            ttMensaje.SetToolTip(this.txtDescripcion, "Ingrese la descripción del aplicativo");
            ttMensaje.SetToolTip(this.txtNombre, "Ingrese el nombre del aplicativo");
            ttMensaje.SetToolTip(this.cmbModulo, "Seleccione el módulo que corresponde al aplicativo");
            ttMensaje.SetToolTip(this.btnAyuda, "Accede a una ventana que explica el funcionamiento del formulario");
            ttMensaje.SetToolTip(this.btnGuardar, "Guarda los datos que ingresó");
            ttMensaje.SetToolTip(this.btnModificar, "Guarda los cambios de datos previamente seleccionados que usted modificó");
            ttMensaje.SetToolTip(this.btnRefrescar, "Actualiza las opciones de Datos a Buscar y Muestra todos los datos del Grid");
            ttMensaje.SetToolTip(this.txtCod,
                "Rango de Codigos\n" +
                "Seguridad 1-100\n" +
                "Reporteador 101-200\n" +
                "Consultas inteligentes 201-300\n" +
                "Modulo HRM 301-1300\n" +
                "Modulo FRM 1301-2300\n" +
                "Modulo SCM 2301-3300\n" +
                "Modulo MRP 3301-4300\n" +
                "Moculo CRM 4301-5300\n");
            ttMensaje.SetToolTip(this.lblCodigoAplicacion,
                "Rango de Codigos\n" +
                "Seguridad 1-100\n" +
                "Reporteador 101-200\n" +
                "Consultas inteligentes 201-300\n" +
                "Modulo HRM 301-1300\n" +
                "Modulo FRM 1301-2300\n" +
                "Modulo SCM 2301-3300\n" +
                "Modulo MRP 3301-4300\n" +
                "Moculo CRM 4301-5300\n");
        }

        //busqueda de datos el el combo box
        private void CargarCombobox()
        {
            cmbModulo.DisplayMember = "nombre_modulo";
            cmbModulo.ValueMember = "pk_id_modulo";
            cmbModulo.DataSource = controlAplicativo.funcObtenerCamposCombobox("pk_id_modulo","nombre_modulo","MODULO","estado_modulo");
            cmbModulo.SelectedIndex = -1;
        }

        // cargar la busqueda 
        private void CargarBusqueda()
        {
            cmbBuscar.DisplayMember = "nombre_aplicacion";
            cmbBuscar.ValueMember = "pk_id_aplicacion";
            cmbBuscar.DataSource = controlAplicativo.funcObtenerCamposCombobox("pk_id_aplicacion","nombre_aplicacion","APLICACION","estado_aplicacion");
            cmbBuscar.SelectedIndex = -1;
            cmbBuscar.Refresh();
        }

        // cargar todos los datos a utilzar 
        private void cargarDatos()
        {
            dgvVistaDatos.DataSource = controlAplicativo.funcObtenerTodo();
        }

        // metodo para bloquear los botones cuando sea necesario 
        private void BloquearBotones()
        {
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        // Metodo para retornar todos los datos 
        private clsAplicativo llenarCampos()
        {
            clsAplicativo auxAplicativo = new clsAplicativo();
            auxAplicativo.IIdAplicativo = int.Parse(txtCod.Text);
            auxAplicativo.SNombre = txtNombre.Text;
            auxAplicativo.SDescripcion = txtDescripcion.Text;
            auxAplicativo.IModulo = int.Parse(cmbModulo.SelectedValue.ToString());
            auxAplicativo.IEstado = 1;
            return auxAplicativo;
        }

        // metodo para limpiar todos los atributos del formulario 
        private void LimpiarComponentes()
        {
            txtCod.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cmbModulo.SelectedIndex = -1;
            txtCod.Focus();
        }

        // metodo para retornar datos cuando se realiza una modificación 
        private clsAplicativo ObtenerModificaciones()
        {
            clsAplicativo auxAplicativo = new clsAplicativo();
            auxAplicativo.SNombre = txtNombre.Text;
            auxAplicativo.SDescripcion = txtDescripcion.Text;
            auxAplicativo.IModulo = int.Parse(cmbModulo.SelectedValue.ToString());
            auxAplicativo.IIdAplicativo = iIDAux;
            return auxAplicativo;
        }

        // Metodo para verificar la inserción de los datos 
        private bool guardarDatos()
        {
            bool guardar = true;
            DialogResult r = MessageBox.Show("Datos a Guardar: \nCodigo:" +txtCod.Text+
                                             "\nNombre: "+txtNombre.Text+
                                             "\nDescripcion: "+txtDescripcion.Text,
                                             "Confirmación De Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(r == DialogResult.OK)
            {
                this.aplicativo = llenarCampos();
                try
                {
                    if (ValidarTextbox() == true)
                    {
                        controlAplicativo.funcInsertarAplicativo(this.aplicativo);
                        cargarDatos();
                        MessageBox.Show("Datos Correctamente Guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        guardar = true;
                    }
                    else
                    {
                        guardar = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Guardar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    guardar = false;
                }
            }
            else
            {
                guardar = false;
            }
            
            return guardar;
        }

        // metodo para limpiar los componentes cuando la insercion de los datos fue correcta 
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (funcValidarCodigo() == true)
            {
                if (guardarDatos() == true)
                {
                    LimpiarComponentes();
                }
                else
                {
                    LimpiarComponentes();
                }
            }

            
        }

        // metodo para verificar los datos modificados 
        private bool ModificarDatos()
        {
            this.aplicativo = ObtenerModificaciones();
            try
            {
                if (ValidarTextbox() == true)
                {
                    controlAplicativo.funcModificarAplicativo(this.aplicativo);
                    cargarDatos();
                    MessageBox.Show("Datos Correctamente Modificados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
        }

        // metodo para limpiar todos los atributos cuando ocurre una modificación 
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ModificarDatos() == true)
            {
                LimpiarComponentes();
                BloquearBotones();
            }
            else
            {
                LimpiarComponentes();
                BloquearBotones();
            }
        }

        // metodo para eliminar datos desde el datagridview 
        private void cmsEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dgMensaje = MessageBox.Show("Una vez eliminados estos datos no se podrán recuperar, ¿Desea Continuar?", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dgMensaje == DialogResult.Yes)
                {

                    this.controlAplicativo.funcEliminarAplicativo(iIDAux);
                    cargarDatos();
                    MessageBox.Show("Datos Correctamente Eliminados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else if (dgMensaje == DialogResult.No)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        //calcular la hora y fecha actual 
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        // metodo para validar la salida 
        private void frmAplicativo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje = MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        // boton para visualizar la ayudas al usuario 
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasSeguridad/Aplicativo/Ayuda.chm", "Ayuda-Aplicativo.html");
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.SelectedIndex >= 0)
            {
                int iIDAux = int.Parse(cmbBuscar.SelectedValue.ToString());
                dgvVistaDatos.DataSource = controlAplicativo.funcObtenerDatos(iIDAux);
            }
            else if (cmbBuscar.SelectedIndex < 0)
            {
                cargarDatos();
            }
        }

        // metodo para cargar la busqueda 
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
        }

        //Metodo para visualizar los datos en el datagridview 
        private void dgvVistaDatos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                iIDAux = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["pk_id_aplicacion"].Value.ToString());
                sNombreAux = dgvVistaDatos.Rows[e.RowIndex].Cells["nombre_aplicacion"].Value.ToString();
                sDescAux = dgvVistaDatos.Rows[e.RowIndex].Cells["descripcion_aplicacion"].Value.ToString();
                iIDModAux=int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["fk_id_modulo"].Value.ToString());
                this.cmsEM.Show(this.dgvVistaDatos, e.Location);
                cmsEM.Show(Cursor.Position);
            }
        }

        // valida el ingreso de datos permitiendo solo ingresar  letras 
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsLetter(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }
        }


        // valida el ingreso de datos permitiendo solo ingresar  letras 
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsLetterOrDigit(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }
        }

        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        //metodo para validar los atributos que estan vacios 
        private bool ValidarTextbox()
        {

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese Nombre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtNombre.Focus();
                return false;
            }
            else if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese Descripción", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtNombre.Focus();
                return false;
            }
            else if (!Regex.Match(txtNombre.Text, @"^[A-Za-z]+([\ A-Za-z]+)*$").Success)
            {
                MessageBox.Show("Datos del campo nombre invalido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtNombre.Focus();
                return false;
            }
            if (txtNombre.Text == "" && txtDescripcion.Text == "")
            {
                MessageBox.Show("Llene los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarComponentes();
                return false;
            }
            return true;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        // Metodo que permite modificar 
        private void cmsModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            txtNombre.Text = sNombreAux;
            txtDescripcion.Text = sDescAux;
        }

        public void procExisteCodigo()
        {
            clsControlCodAplicacion aplicacion = new clsControlCodAplicacion();
            int Aux = aplicacion.funcExisteCodigo(txtCod.Text);
            
        }

        private void gbxIngresoDatos_Enter(object sender, EventArgs e)
        {

        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.CampoNumerico(e);
        }

        public bool funcValidarCodigo()
        {
            
            clsControlCodAplicacion aplicacion = new clsControlCodAplicacion();
            bool Validado = false;
            string codigo;
            if (String.IsNullOrEmpty(txtCod.Text))
            {
                MessageBox.Show("Codigo Vacio\nIngrese Un Codigo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int Codigo = Convert.ToInt32(txtCod.Text);
                string modulo = cmbModulo.SelectedValue.ToString();
                int Aux = aplicacion.funcExisteCodigo(txtCod.Text);

                Console.WriteLine(Codigo);
                Console.WriteLine(modulo);
                if ((Codigo <= 100) && (Codigo >= 1))//Seguridad
                {
                    Console.WriteLine("SEGURIDAD");
                    if (modulo.Equals("1"))
                    {
                        Console.WriteLine("PERTENECE SEGURIDAD");
                        if(Aux == 1)//Existe
                        {
                            MessageBox.Show("Codigo Ya Existe\nVerifique El Codigo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "1";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = false;
                        }
                        else
                        {
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "1";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = true;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("El Modulo No Pertenece Al Rango De Codigos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validado = false;
                    }

                }
                else if ((Codigo <= 200) && (Codigo >= 101))//reporteador
                {
                    Console.WriteLine("REPORTEADOR");
                    if (modulo.Equals("2"))
                    {
                        Console.WriteLine(" PERTENECE REPORTEADOR");
                        if (Aux == 1)//Existe
                        {
                            MessageBox.Show("Codigo Ya Existe\nVerifique El Codigo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "101";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = false;
                        }
                        else
                        {
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "101";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Modulo No Pertenece Al Rango De Codigos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validado = false;
                    }
                }
                else if ((Codigo <= 300) && (Codigo >= 201))//consultas inteligentes
                {
                    Console.WriteLine("CONSULTAS");
                    if (modulo.Equals("3"))
                    {
                        if (Aux == 1)//Existe
                        {
                            MessageBox.Show("Codigo Ya Existe\nVerifique El Codigo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "201";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = false;
                        }
                        else
                        {
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "201";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Modulo No Pertenece Al Rango De Codigos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validado = false;
                    }
                }
                else if ((Codigo <= 1300) && (Codigo >= 301))//HRM
                {
                    Console.WriteLine("HRM");
                    if (modulo.Equals("4"))
                    {
                        if (Aux == 1)//Existe
                        {
                            MessageBox.Show("Codigo Ya Existe\nVerifique El Codigo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "301";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = false;
                        }
                        else
                        {
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "301";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Modulo No Pertenece Al Rango De Codigos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validado = false;
                    }
                }
                else if ((Codigo <= 2300) && (Codigo >= 1301))//FRM
                {
                    Console.WriteLine("FRM");
                    if (modulo.Equals("5"))
                    {
                        if (Aux == 1)//Existe
                        {
                            MessageBox.Show("Codigo Ya Existe\nVerifique El Codigo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "1301";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = false;
                        }
                        else
                        {
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "1301";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Modulo No Pertenece Al Rango De Codigos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validado = false;
                    }
                }
                else if ((Codigo <= 3300) && (Codigo >= 2301))//SCM
                {
                    Console.WriteLine("SCM");
                    if (modulo.Equals("6"))
                    {
                        if (Aux == 1)//Existe
                        {
                            MessageBox.Show("Codigo Ya Existe\nVerifique El Codigo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "2301";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = false;
                        }
                        else
                        {
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "2301";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Modulo No Pertenece Al Rango De Codigos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        codigo = funcObtenerId(modulo);
                        Validado = false;
                    }
                }
                else if ((Codigo <= 4300) && (Codigo >= 3301))//MRP
                {
                    Console.WriteLine("MRP");
                    if (modulo.Equals("7"))
                    {
                        if (Aux == 1)//Existe
                        {
                            MessageBox.Show("Codigo Ya Existe\nVerifique El Codigo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "3301";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = false;
                        }
                        else
                        {
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "3301";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Modulo No Pertenece Al Rango De Codigos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validado = false;
                    }
                }
                else if ((Codigo <= 5300) && (Codigo >= 4301))//CRM
                {
                    Console.WriteLine("CRM");
                    if (modulo.Equals("8"))
                    {
                        if (Aux == 1)//Existe
                        {
                            MessageBox.Show("Codigo Ya Existe\nVerifique El Codigo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "4301";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = false;
                        }
                        else
                        {
                            codigo = funcObtenerId(modulo);
                            if (codigo.Equals("Vacio"))
                            {
                                txtCod.Text = "4301";
                            }
                            else
                            {
                                txtCod.Text = codigo;
                            }
                            Validado = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Modulo No Pertenece Al Rango De Codigos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                        Validado = false;
                    }
                }
                else
                {
                    Console.WriteLine("NO PERTENECE A NINGUNO");
                    Validado = false;
                }
            }
            return Validado;
        }

        //metodo para Obtener el codigo de las aplicacion
        public string funcObtenerId(string modulo)
        {
            
            clsControlCodAplicacion aplicacion = new clsControlCodAplicacion();
            string codigo = "";
            Console.WriteLine("El modulo a obtener el max id es:"+modulo);
            codigo = aplicacion.funcObtenerCodigoAplicacion(modulo);
            return codigo;
            //txtCod.Text = codigo;
        }
    }
}
