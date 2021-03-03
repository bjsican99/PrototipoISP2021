/*Version 27/10/2020*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorNavegador;
using CapaVistaSeguridad;


namespace CapaVistaNavegador
{
    public partial class Navegador : UserControl
    {
        clsVistaBitacora Bitacora = new clsVistaBitacora();
        //codigo de guardar
        public List<Control> control = null;
        public int OpGuardar;
        public int aplicacion;
        //codigo de guardar
        //codigo de actualizar
        public DataGridView DatosActualizar = null;
        //codigo de actualizar
        public string campoEstado;
        public string tbl;
        public string cmp;
        public TextBox txt;
        public string ruta = "";
        public string ayudaRuta = "";
        public string Usuario;
        string[] word;
        bool Señal2 = false;
        public Form formulario = null;
        public Form MDIformulario;
        //private frmReporteadorNavegador reporte;
       // private frmUsuarioNormal UsuarioNormal;
       // private frmUsuarioAvanzado UsuarioAvanzado;
        int numeroCampos;
        //Para Permisos
        public Navegador()
        {
            InitializeComponent();
            if (control != null)
            {
                control.Reverse();
            }
            this.ttAyuda.SetToolTip(this.btnInsertar, "Presione para generar un nuevo codigo y activar los campos");
            this.ttAyuda.SetToolTip(this.btnModificar, "Presione para activar los campos a modificar");
            this.ttAyuda.SetToolTip(this.btnGuardar, "Presione para Guardar los cambios hechos despues de presionar el boton de insertar o modificar");
            this.ttAyuda.SetToolTip(this.btnEliminar, "Presione para eliminar el dato que esta proyectado en los campos");
            this.ttAyuda.SetToolTip(this.btnRefrescar, "Presione para refrescar el formulario");
            this.ttAyuda.SetToolTip(this.btnCancelar, "Presione para cancelar la operacion que esta realizando actualmente");
            this.ttAyuda.SetToolTip(this.btnConsultar, "Presione para abrir la ventana de consultas, cualquier error comunicarse con el area de consultas ");
            this.ttAyuda.SetToolTip(this.btnImprimir, "Recuerde que debe tener un reporte asignado a la aplicacion y tener instalado los software de reportes, cualquier error comunicarse con el area de reporteador");
            this.ttAyuda.SetToolTip(this.btnInicio, "Presione para regresar al primer dato de la tabla");
            this.ttAyuda.SetToolTip(this.btnAtras, "Presione para regresar una posicion en la tabla");
            this.ttAyuda.SetToolTip(this.btnAdelante, "Presione para moverse una posicion hacia adelante en la tabla de datos");
            this.ttAyuda.SetToolTip(this.btnFinal, "Presione para moverse al ultimo dato de la tabla");
            this.ttAyuda.SetToolTip(this.btnAyuda, "Presione para abrir la ayuda del formulario");
            this.ttAyuda.SetToolTip(this.btnSalir, "Presione para cerrar el formulario");
        }
        clsControlador cn = new clsControlador();
       
        public void procCargar()
        {
           
            if (control !=null && DatosActualizar != null)
            {
                string Mensaje = cn.funcVerficarTabla(tbl);

                if (!Mensaje.Equals("bien"))
                {
                    MessageBox.Show(Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnInicio.Enabled = false;
                    btnInsertar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnRefrescar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnAtras.Enabled = false;
                    btnFinal.Enabled = false;
                    btnAdelante.Enabled = false;
                    btnAyuda.Enabled = false;
                    btnSalir.Enabled = false;
                    btnGuardar.Enabled = false;
                    DatosActualizar.Enabled = false;
                    procBloquear();
                }
                else
                {
                    btnInicio.Enabled = true;
                    btnInsertar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnRefrescar.Enabled = true;
                    btnConsultar.Enabled = true;
                    btnImprimir.Enabled = true;
                    btnAtras.Enabled = true;
                    btnFinal.Enabled = true;
                    btnAdelante.Enabled = true;
                    btnAyuda.Enabled = true;
                    btnSalir.Enabled = true;
                    procObtenerPermisos();
                    procPermisosBotones();
                    procVerificarCampos();
                    if (Señal2)
                    {
                        procContarCampos();
                        //  MessageBox.Show("" + control.Count + "" + numeroCampos);
                        if (control.Count != 0 && control.Count == numeroCampos)
                        {

                            DatosActualizar.CurrentCell = DatosActualizar.Rows[0].Cells[0];

                            int i = -1;
                            control.Reverse();
                            TextBox text = (TextBox)control.First();
                            text.Enabled = false;
                            foreach (var item in control)
                            {
                                i++;
                                item.Enabled = false;
                                // MessageBox.Show("Item: " + item.Name);
                                string datico = DatosActualizar.Rows[0].Cells[i].Value.ToString();

                                if (item is DateTimePicker)
                                {
                                    DateTimePicker ll = (DateTimePicker)item;
                                    ll.Value = Convert.ToDateTime(datico);

                                }
                                else
                                {
                                    item.Text = datico;

                                }
                                //MessageBox.Show("data: " + datico);
                            }

                        }
                        else
                        {
                            btnInicio.Enabled = false;
                            btnInsertar.Enabled = false;
                            btnModificar.Enabled = false;
                            btnEliminar.Enabled = false;
                            btnRefrescar.Enabled = false;
                            btnCancelar.Enabled = false;
                            btnConsultar.Enabled = false;
                            btnImprimir.Enabled = false;
                            btnAtras.Enabled = false;
                            btnFinal.Enabled = false;
                            btnAdelante.Enabled = false;
                            btnAyuda.Enabled = false;
                            btnSalir.Enabled = false;
                            btnGuardar.Enabled = false;
                            DatosActualizar.Enabled = false;
                        }
                    }

                }
            }else
            {
                btnInicio.Enabled = false;
                btnInsertar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnRefrescar.Enabled = false;
                btnCancelar.Enabled = false;
                btnConsultar.Enabled = false;
                btnImprimir.Enabled = false;
                btnAtras.Enabled = false;
                btnFinal.Enabled = false;
                btnAdelante.Enabled = false;
                btnAyuda.Enabled = false;
                btnSalir.Enabled = false;
                btnGuardar.Enabled = false;
            }


        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //genera un nuevo codigo en el primer textbox que se agrege a la lista
            OpGuardar = 1;
            procDesbloquear();
            TextBox text = (TextBox)control.First();
            procInsertar(tbl, text.Tag.ToString(), text);
            btnModificar.Enabled = false;
            btnInsertar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        public void procInsertar(string tabla, string campo, TextBox txt)
        {
            //se recibe el codigo por medio de la consulta realizada en la clase de sentencias
            procDesbloquear();
            string tbl = tabla;
            string cmp1 = campo;
            TextBox txt1 = txt;
            int codigo = cn.funcCodigoMax(tbl, cmp1);
            txt1.Text = codigo.ToString();
            txt1.Enabled = false;
        }
        private void procDesbloquear()
        {
            //desbloquea los campos
            TextBox text = (TextBox)control.First();
            foreach (var item in control)
            {
                if (OpGuardar==1)
                {
                    item.Text = "";
                }
                item.Enabled = true;
            }
           
            text.Enabled = false;
        }

        private void procBloquear()
        {
            //bloquea los campos 
            foreach (var item in control)
            {
                item.Enabled = false;
            }
        }
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            //abre el formulario de ayuda que se le asigna en el navegador
            if(!ayudaRuta.Equals("")  && !ruta.Equals(""))
            {
                Bitacora.insert("Formulario de ayuda", aplicacion);
                Help.ShowHelp(this, ayudaRuta, ruta);
            }
            else
            {
                MessageBox.Show("Debe ingresar las rutas necesarias para abrir los archivos de ayuda", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //verifica si se presiona el boton de insertar o modificar y llama a la funcion respectiva
            bool Verificador = false;
            if (OpGuardar == 1)
            {
                //verifica si los campos estan vacios
                foreach (var items in control)
                {
                    if (items.Text.Equals(""))
                    {
                        Verificador = true;
                    }
                }
                
                if (!Verificador)
                {

                    procInsertarDatos();
                    procActualizarData();
                    MessageBox.Show("El Dato se Guardo Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Algunos campos siguen vacios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (OpGuardar == 0)
            {

                foreach (var items in control)
                {
                    if (items.Text.Equals(""))
                    {
                        Verificador = true;
                    }
                }
                if (!Verificador)
                {
                    procModificarDatos();
                    procActualizarData();
                    MessageBox.Show("El Dato se Modifico Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Algunos campos siguen vacios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            TextBox text = (TextBox)control.First();
            text.Enabled = false;
            procPermisosBotones();
            procBloquear();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            /////////////////// se copian los datos de la tablahacia los campos
            DatosActualizar.CurrentCell = DatosActualizar.Rows[0].Cells[0];

            int i = -1;
            foreach (var item in control)
            {
                i++;
                // MessageBox.Show("Item: " + item.Name);
                string datico = DatosActualizar.Rows[0].Cells[i].Value.ToString();

                if (item is DateTimePicker)
                {
                    DateTimePicker ll = (DateTimePicker)item;
                    ll.Value = Convert.ToDateTime(datico);
                }
                else
                {
                    item.Text = datico;
                }
                //MessageBox.Show("data: " + datico);
            }
        }
        private void procContarCampos()
        {
            //se cuenta la cantidad de campos que tiene el formulario y se compara con la tabla que se llama
            List<string> campos = cn.funcVerficarCampo(tbl);
            numeroCampos = campos.Count;

        }

        private void procInsertarDatos()
        {
            //procedimiento que envia los datos a la consulta de insercion en la clase de sentencias
            List<string> lista = new List<string>();
            //  control.Reverse();
            foreach (var items in control)
            {
                if (items is TextBox)
                {
                    lista.Add(items.Text);
                }
                else if (items is ComboBox)
                {
                    lista.Add(items.Text);
                }
                else if (items is DateTimePicker)
                {
                    DateTimePicker fecha = (DateTimePicker)items;
                    lista.Add(fecha.Value.ToString("yyyy-MM-dd hh:mm:ss"));
                }
            }
            cn.procDatosInsertar(tbl, lista, aplicacion);
        }

        private void procModificarDatos()
        {
            //procedimiento que envia los datos a la consulta de modificar en la clase de sentencias
            List<string> campos = new List<string>();
            List<string> Datos = new List<string>();
            //   control.Reverse();
            /*  foreach (var items in Modificar)
           {
               campos.Add(items);
           }*/
            foreach (var items in control)
            {
                campos.Add(items.Tag.ToString());
                if (items is TextBox)
                {
                    Datos.Add(items.Text);
                }
                else if (items is ComboBox)
                {
                    Datos.Add(items.Text);
                }
                else if (items is DateTimePicker)
                {
                    DateTimePicker fecha = (DateTimePicker)items;
                    Datos.Add(fecha.Value.ToString("yyyy-MM-dd hh:mm:ss"));
                }
            }
            cn.procDatosModificar(tbl, campos, Datos, aplicacion);
        }

        public void procActualizarData()
        {
           if(DatosActualizar != null)
            {
                //se guardar los datos de una tabla consultada en la tabla que se envia en el navegador
                DataTable dt = cn.funcEnviar(tbl, campoEstado);
                DatosActualizar.DataSource = dt;
            }else
            {
                btnInicio.Enabled = false;
                btnInsertar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnRefrescar.Enabled = false;
                btnCancelar.Enabled = false;
                btnConsultar.Enabled = false;
                btnImprimir.Enabled = false;
                btnAtras.Enabled = false;
                btnFinal.Enabled = false;
                btnAdelante.Enabled = false;
                btnAyuda.Enabled = false;
                btnSalir.Enabled = false;
                btnGuardar.Enabled = false;
            }
       
            
           
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            //refresca el formulario
            Bitacora.insert("Refrescar Datos", aplicacion);
            procActualizarData();
            DatosActualizar.CurrentCell = DatosActualizar.Rows[0].Cells[0];

            int i = -1;
            foreach (var item in control)
            {
                i++;
                // MessageBox.Show("Item: " + item.Name);
                string datico = DatosActualizar.Rows[0].Cells[i].Value.ToString();

                if (item is DateTimePicker)
                {
                    DateTimePicker ll = (DateTimePicker)item;
                    ll.Value = Convert.ToDateTime(datico);
                }
                else
                {
                    item.Text = datico;
                }
                //MessageBox.Show("data: " + datico);
            }
            TextBox text = (TextBox)control.First();
            text.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(formulario != null)
            {
                //cierra el formulario en el que esta posicionado
                DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea salir de la aplicacion?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.OK)
                {
                    Bitacora.insert("Salir de la aplicacion", aplicacion);
                    formulario.Dispose();
                }
            }else
            {
                MessageBox.Show("ERROR NO SE ESTA ENVIANDO NINGUN FORMULARIO", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //se cancela la operacion actual y recarga el formulario nuevamente
            procBloquear();
            Bitacora.insert("Cancelar", aplicacion);
            foreach (var item in control)
            {
                if (item is TextBox)
                {

                    item.Text = "";
                }
                else if (item is ComboBox)
                {
                    item.Text = "";
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker SeleccionadorFecha = (DateTimePicker)item;
                    SeleccionadorFecha.Value = DateTime.Now;
                }
            }
            DatosActualizar.CurrentCell = DatosActualizar.Rows[0].Cells[0];

            int i = -1;
            foreach (var item in control)
            {
                i++;
                // MessageBox.Show("Item: " + item.Name);
                string datico = DatosActualizar.Rows[0].Cells[i].Value.ToString();

                if (item is DateTimePicker)
                {
                    DateTimePicker ll = (DateTimePicker)item;
                    ll.Value = Convert.ToDateTime(datico);
                }
                else
                {
                    item.Text = datico;
                }
                //MessageBox.Show("data: " + datico);
            }
            procPermisosBotones();
            TextBox text = (TextBox)control.First();
            text.Enabled = false;
            /*  btnInsertar.Enabled = true;
              btnModificar.Enabled = true;
              btnEliminar.Enabled = true;*/
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnRefrescar.Enabled = true;

        }


        public void procParametrosEliminar(string tabla, string campo, string campoid, TextBox textBox)
        {
            //procemiento para eliminar el un dato
            if (cn.funcEliminar(tabla, campo, campoid, textBox.Text, aplicacion))
            {
                MessageBox.Show("Registro Eliminado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El registro no pudo eliminarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //se elimina el dato y se actualiza el formulario
            //DialogResult dialogResult = (MessageBox.Show("¿Esta Seguro de eliminar este resgistro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning));
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro de eliminar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.OK)
            {
                Bitacora.insert("Eliminacion de Datos", aplicacion);
                TextBox text = (TextBox)control.First();
                procParametrosEliminar(tbl, campoEstado, control.First().Tag.ToString(), text);

                DatosActualizar.CurrentCell = DatosActualizar.Rows[0].Cells[0];

                int i = -1;
                foreach (var item in control)
                {
                    i++;
                    // MessageBox.Show("Item: " + item.Name);
                    string datico = DatosActualizar.Rows[0].Cells[i].Value.ToString();

                    if (item is DateTimePicker)
                    {
                        DateTimePicker ll = (DateTimePicker)item;
                        ll.Value = Convert.ToDateTime(datico);
                    }
                    else
                    {
                        item.Text = datico;
                    }
                    //MessageBox.Show("data: " + datico);
                }

            }

            procActualizarData();
            procBloquear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //boton de modificar activa y bloquea los botones que no son utiles en esta operacion
            OpGuardar = 0;
            procDesbloquear();
            btnModificar.Enabled = false;
            btnInsertar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //regresa al primer registro de la tabla
            try
            {
                DatosActualizar.CurrentCell = DatosActualizar.Rows[0].Cells[0];
                int i = -1;
                foreach (var item in control)
                {
                    i++;
                    // MessageBox.Show("Item: " + item.Name);
                    string datico = DatosActualizar.Rows[0].Cells[i].Value.ToString();

                    if (item is DateTimePicker)
                    {
                        DateTimePicker ll = (DateTimePicker)item;
                        ll.Value = Convert.ToDateTime(datico);
                    }
                    else
                    {
                        item.Text = datico;
                    }
                    //MessageBox.Show("data: " + datico);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esta en el primer elemento de la tabla", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //regresa una posicion en la tabla
            int row = DatosActualizar.CurrentCell.RowIndex;

            try
            {
                DatosActualizar.CurrentCell = DatosActualizar.Rows[row - 1].Cells[0];
                int i = -1;
                foreach (var item in control)
                {
                    i++;
                    // MessageBox.Show("Item: " + item.Name);
                    string datico = DatosActualizar.Rows[row - 1].Cells[i].Value.ToString();

                    if (item is DateTimePicker)
                    {
                        DateTimePicker ll = (DateTimePicker)item;
                        ll.Value = Convert.ToDateTime(datico);
                    }
                    else
                    {
                        item.Text = datico;
                    }
                    //MessageBox.Show("data: " + datico);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ya se encuentra en el primer elemento de la tabla", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            //se mueve hacia adelante en los registros de la tabla
            int row = DatosActualizar.CurrentCell.RowIndex;
            try
            {
                DatosActualizar.CurrentCell = DatosActualizar.Rows[row + 1].Cells[0];
                int i = -1;
                foreach (var item in control)
                {
                    i++;
                    // MessageBox.Show("Item: " + item.Name);
                    string datico = DatosActualizar.Rows[row + 1].Cells[i].Value.ToString();

                    if (item is DateTimePicker)
                    {
                        DateTimePicker ll = (DateTimePicker)item;
                        ll.Value = Convert.ToDateTime(datico);
                    }
                    else
                    {
                        item.Text = datico;
                    }
                    //MessageBox.Show("data: " + datico);
                }
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Ya se encuentra en el ultimo elenemento ¿Desea regresar al primer elemento?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.OK)
                {
                    procActualizarData();
                    DatosActualizar.CurrentCell = DatosActualizar.Rows[0].Cells[0];

                    int i = -1;
                    foreach (var item in control)
                    {
                        i++;
                        // MessageBox.Show("Item: " + item.Name);
                        string datico = DatosActualizar.Rows[0].Cells[i].Value.ToString();

                        if (item is DateTimePicker)
                        {
                            DateTimePicker ll = (DateTimePicker)item;
                            ll.Value = Convert.ToDateTime(datico);
                        }
                        else
                        {
                            item.Text = datico;
                        }
                        //MessageBox.Show("data: " + datico);
                    }
                    TextBox text = (TextBox)control.First();
                    text.Enabled = false;
                }
                   
                
            }
        }
        private void procObtenerPermisos()
        {
            //se obtiene los permisos de la DLL seguridad
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
           string permisos = seguridad.Permisos(aplicacion.ToString(), Usuario);
            word = permisos.Split(',');
          
        }
        public void procPermisosBotones()
        {
            //se comparan los permisos obtenidos de la DLL de seguridad
            //Para Permisos

            if (word[0] == "0")
            {
                btnInsertar.Enabled = false;
            }
            else
            {
                btnInsertar.Enabled = true;
            }
            ////////////////////////////////
            if (word[1]=="0")
            {
                btnModificar.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = true;
            }
            //////////////////////////////////
            if (word[2]=="0")
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
            ////////////////////////////////
            if (word[3]=="0")
            {
                btnConsultar.Enabled = false;
            }
            else
            {
                btnConsultar.Enabled = true;
            }
            ///////////////////////////////
            if (word[4]=="0")
            {
                btnImprimir.Enabled = false;
            }
            else
            {
                btnImprimir.Enabled = true;
            }
        }
        private void btnFinal_Click(object sender, EventArgs e)
        {
            //se mueve al final de la tabla
            int nRowIndex = DatosActualizar.Rows.Count - 1;
            try
            {
                DatosActualizar.CurrentCell = DatosActualizar.Rows[nRowIndex].Cells[0];
                int i = -1;
                foreach (var item in control)
                {
                    i++;
                    // MessageBox.Show("Item: " + item.Name);
                    string datico = DatosActualizar.Rows[nRowIndex].Cells[i].Value.ToString();

                    if (item is DateTimePicker)
                    {
                        DateTimePicker ll = (DateTimePicker)item;
                        ll.Value = Convert.ToDateTime(datico);
                    }
                    else
                    {
                        item.Text = datico;
                    }
                    //MessageBox.Show("data: " + datico);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usted ha llegado al fondo de la tabla y no se encuentran mas datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void procVerificarCampos()
        {
            //se verifican los campos enviados del formulario con los campos de la tabla enviada
            List<string> CamposTabla = cn.funcVerficarCampo(tbl);
            
            foreach (var item in control)
            {
                bool Señal = false;
                string Elemento = item.Tag.ToString();
                foreach (var items in CamposTabla)
                {

                    if (items.Equals(Elemento))
                    {
                        Señal = true;
                    }
                   
                }

           
                if (!Señal)
                {
                    MessageBox.Show("El campo: "+Elemento+" No existe en la tabla "+tbl, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnInicio.Enabled = false;
                    btnInsertar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnRefrescar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnAtras.Enabled = false;
                    btnFinal.Enabled = false;
                    btnAdelante.Enabled = false;
                    btnAyuda.Enabled = false;
                    btnSalir.Enabled = false;
                    btnGuardar.Enabled = false;
                    DatosActualizar.Enabled = false;
                    procBloquear();
                }
            }
            Señal2 = false;
            foreach(var items in CamposTabla)
            {
                if (items.Equals(campoEstado))
                {
                    Señal2 = true;
                }
            }
            if(!Señal2)
            {
                MessageBox.Show("El campo: " + campoEstado + " No existe en la tabla " + tbl, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnInicio.Enabled = false;
                btnInsertar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnRefrescar.Enabled = false;
                btnCancelar.Enabled = false;
                btnConsultar.Enabled = false;
                btnImprimir.Enabled = false;
                btnAtras.Enabled = false;
                btnFinal.Enabled = false;
                btnAdelante.Enabled = false;
                btnAyuda.Enabled = false;
                btnSalir.Enabled = false;
                btnGuardar.Enabled = false;
                DatosActualizar.Enabled = false;
                procBloquear();
            }
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {       
           /* //abre la DLL de Reporteador 
            try
            {
                if (reporte == null)
                {
                    reporte = new frmReporteadorNavegador(aplicacion);
                    reporte.MdiParent = MDIformulario;
                    reporte.FormClosed += (o, args) => reporte = null;
                }
                reporte.Show();
                reporte.BringToFront();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Verifique que si tiene instalado el software necesario para utilizar esta aplicacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
          
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           /* //ABRE LA DLL DE CONSULTAS
            try
            {
                clsVistaBitacora bit = new clsVistaBitacora();
                clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
                if (seguridad.PermisosAcceso("201", Usuario) == 1)
                {
                    if (UsuarioAvanzado == null)
                    {
                        UsuarioAvanzado = new frmUsuarioAvanzado();
                        UsuarioAvanzado.MdiParent = MDIformulario;
                        UsuarioAvanzado.FormClosed += (o, args) => UsuarioAvanzado = null;
                    }
                    bit.user(Usuario);
                    UsuarioAvanzado.Show();
                    UsuarioAvanzado.BringToFront();
                }
                else
                {
                    if (UsuarioNormal == null)
                    {
                        UsuarioNormal = new frmUsuarioNormal(tbl);
                        UsuarioNormal.MdiParent = MDIformulario;
                        UsuarioNormal.FormClosed += (o, args) => UsuarioNormal = null;
                    }
                    bit.user(Usuario);
                    UsuarioNormal.Show();
                    UsuarioNormal.BringToFront();


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Verifique la funcionabilidad del Objeto Común Reporteador", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }*/

        }
    }
}
