
namespace CapaVista.Mantenimientos
{
    partial class frmMantenimientoProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoProductos));
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodLinea = new System.Windows.Forms.TextBox();
            this.cbxCodLinea = new System.Windows.Forms.ComboBox();
            this.txtCodMarca = new System.Windows.Forms.TextBox();
            this.cbxCodMarca = new System.Windows.Forms.ComboBox();
            this.txtExistenciaProd = new System.Windows.Forms.TextBox();
            this.txtestatus = new System.Windows.Forms.TextBox();
            this.rbtnHabilitado = new System.Windows.Forms.RadioButton();
            this.rbtnDeshabilidado = new System.Windows.Forms.RadioButton();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1059, 105);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo De Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre De Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo de Linea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo De Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Existencia De Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Estatus Producto";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(189, 140);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(77, 20);
            this.txtCodigoProducto.TabIndex = 7;
            this.txtCodigoProducto.Tag = "codigo_producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(189, 181);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(185, 20);
            this.txtNombreProducto.TabIndex = 8;
            this.txtNombreProducto.Tag = "nombre_producto";
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            // 
            // txtCodLinea
            // 
            this.txtCodLinea.Enabled = false;
            this.txtCodLinea.Location = new System.Drawing.Point(189, 214);
            this.txtCodLinea.Name = "txtCodLinea";
            this.txtCodLinea.Size = new System.Drawing.Size(35, 20);
            this.txtCodLinea.TabIndex = 9;
            this.txtCodLinea.Tag = "codigo_linea";
            // 
            // cbxCodLinea
            // 
            this.cbxCodLinea.FormattingEnabled = true;
            this.cbxCodLinea.Location = new System.Drawing.Point(230, 214);
            this.cbxCodLinea.Name = "cbxCodLinea";
            this.cbxCodLinea.Size = new System.Drawing.Size(144, 21);
            this.cbxCodLinea.TabIndex = 10;
            this.cbxCodLinea.Tag = "saltar";
            this.cbxCodLinea.SelectedIndexChanged += new System.EventHandler(this.cbxCodLinea_SelectedIndexChanged);
            // 
            // txtCodMarca
            // 
            this.txtCodMarca.Enabled = false;
            this.txtCodMarca.Location = new System.Drawing.Point(189, 246);
            this.txtCodMarca.Name = "txtCodMarca";
            this.txtCodMarca.Size = new System.Drawing.Size(35, 20);
            this.txtCodMarca.TabIndex = 11;
            this.txtCodMarca.Tag = "codigo_marca";
            // 
            // cbxCodMarca
            // 
            this.cbxCodMarca.FormattingEnabled = true;
            this.cbxCodMarca.Location = new System.Drawing.Point(230, 246);
            this.cbxCodMarca.Name = "cbxCodMarca";
            this.cbxCodMarca.Size = new System.Drawing.Size(144, 21);
            this.cbxCodMarca.TabIndex = 12;
            this.cbxCodMarca.Tag = "saltar";
            this.cbxCodMarca.SelectedIndexChanged += new System.EventHandler(this.cbxCodMarca_SelectedIndexChanged);
            // 
            // txtExistenciaProd
            // 
            this.txtExistenciaProd.Location = new System.Drawing.Point(189, 278);
            this.txtExistenciaProd.Name = "txtExistenciaProd";
            this.txtExistenciaProd.Size = new System.Drawing.Size(185, 20);
            this.txtExistenciaProd.TabIndex = 13;
            this.txtExistenciaProd.Tag = "existencia_producto";
            this.txtExistenciaProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistenciaProd_KeyPress);
            // 
            // txtestatus
            // 
            this.txtestatus.Location = new System.Drawing.Point(189, 345);
            this.txtestatus.Name = "txtestatus";
            this.txtestatus.Size = new System.Drawing.Size(100, 20);
            this.txtestatus.TabIndex = 14;
            this.txtestatus.Tag = "estatus_producto";
            this.txtestatus.Visible = false;
            // 
            // rbtnHabilitado
            // 
            this.rbtnHabilitado.AutoSize = true;
            this.rbtnHabilitado.Location = new System.Drawing.Point(189, 311);
            this.rbtnHabilitado.Name = "rbtnHabilitado";
            this.rbtnHabilitado.Size = new System.Drawing.Size(72, 17);
            this.rbtnHabilitado.TabIndex = 15;
            this.rbtnHabilitado.TabStop = true;
            this.rbtnHabilitado.Text = "Habilitado";
            this.rbtnHabilitado.UseVisualStyleBackColor = true;
            this.rbtnHabilitado.CheckedChanged += new System.EventHandler(this.rbtnHabilitado_CheckedChanged);
            // 
            // rbtnDeshabilidado
            // 
            this.rbtnDeshabilidado.AutoSize = true;
            this.rbtnDeshabilidado.Location = new System.Drawing.Point(280, 311);
            this.rbtnDeshabilidado.Name = "rbtnDeshabilidado";
            this.rbtnDeshabilidado.Size = new System.Drawing.Size(89, 17);
            this.rbtnDeshabilidado.TabIndex = 16;
            this.rbtnDeshabilidado.TabStop = true;
            this.rbtnDeshabilidado.Text = "Deshabilitado";
            this.rbtnDeshabilidado.UseVisualStyleBackColor = true;
            this.rbtnDeshabilidado.CheckedChanged += new System.EventHandler(this.rbtnDeshabilidado_CheckedChanged);
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(456, 123);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(586, 211);
            this.dgvProducto.TabIndex = 17;
            // 
            // frmMantenimientoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.rbtnDeshabilidado);
            this.Controls.Add(this.rbtnHabilitado);
            this.Controls.Add(this.txtestatus);
            this.Controls.Add(this.txtExistenciaProd);
            this.Controls.Add(this.cbxCodMarca);
            this.Controls.Add(this.txtCodMarca);
            this.Controls.Add(this.cbxCodLinea);
            this.Controls.Add(this.txtCodLinea);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.DoubleBuffered = true;
            this.Name = "frmMantenimientoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodLinea;
        private System.Windows.Forms.ComboBox cbxCodLinea;
        private System.Windows.Forms.TextBox txtCodMarca;
        private System.Windows.Forms.ComboBox cbxCodMarca;
        private System.Windows.Forms.TextBox txtExistenciaProd;
        private System.Windows.Forms.TextBox txtestatus;
        private System.Windows.Forms.RadioButton rbtnHabilitado;
        private System.Windows.Forms.RadioButton rbtnDeshabilidado;
        private System.Windows.Forms.DataGridView dgvProducto;
    }
}