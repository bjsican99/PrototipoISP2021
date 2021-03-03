namespace CapaVistaSeguridad.Formularios.Mantenimientos
{
    partial class frmModulo
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
            this.txtDescripcionModulo = new System.Windows.Forms.TextBox();
            this.lblCodigoModulo = new System.Windows.Forms.Label();
            this.lblRegistroAplicacion = new System.Windows.Forms.Label();
            this.dtlModulo = new System.Windows.Forms.DataGridView();
            this.txtNombreModulo = new System.Windows.Forms.TextBox();
            this.txtCodigoModulo = new System.Windows.Forms.TextBox();
            this.lblDescripcionModulo = new System.Windows.Forms.Label();
            this.lblNombreModulo = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.gbxEstado = new System.Windows.Forms.GroupBox();
            this.rbtnDesabilitado = new System.Windows.Forms.RadioButton();
            this.rbtnHabilitado = new System.Windows.Forms.RadioButton();
            this.navegadorModulo = new CapaVistaNavegador.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dtlModulo)).BeginInit();
            this.gbxEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcionModulo
            // 
            this.txtDescripcionModulo.Location = new System.Drawing.Point(281, 321);
            this.txtDescripcionModulo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDescripcionModulo.Name = "txtDescripcionModulo";
            this.txtDescripcionModulo.Size = new System.Drawing.Size(198, 23);
            this.txtDescripcionModulo.TabIndex = 27;
            this.txtDescripcionModulo.Tag = "descripcion_modulo";
            // 
            // lblCodigoModulo
            // 
            this.lblCodigoModulo.AutoSize = true;
            this.lblCodigoModulo.Location = new System.Drawing.Point(29, 221);
            this.lblCodigoModulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodigoModulo.Name = "lblCodigoModulo";
            this.lblCodigoModulo.Size = new System.Drawing.Size(61, 17);
            this.lblCodigoModulo.TabIndex = 26;
            this.lblCodigoModulo.Text = "Codigo:";
            this.lblCodigoModulo.Click += new System.EventHandler(this.lb_codigo_aplicacion_Click);
            // 
            // lblRegistroAplicacion
            // 
            this.lblRegistroAplicacion.AutoSize = true;
            this.lblRegistroAplicacion.Location = new System.Drawing.Point(523, 189);
            this.lblRegistroAplicacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegistroAplicacion.Name = "lblRegistroAplicacion";
            this.lblRegistroAplicacion.Size = new System.Drawing.Size(124, 17);
            this.lblRegistroAplicacion.TabIndex = 25;
            this.lblRegistroAplicacion.Text = "Registros modulo:";
            this.lblRegistroAplicacion.Click += new System.EventHandler(this.lb_registros_aplicacion_Click);
            // 
            // dtlModulo
            // 
            this.dtlModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlModulo.Location = new System.Drawing.Point(650, 189);
            this.dtlModulo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtlModulo.Name = "dtlModulo";
            this.dtlModulo.RowHeadersWidth = 51;
            this.dtlModulo.Size = new System.Drawing.Size(639, 217);
            this.dtlModulo.TabIndex = 24;
            this.dtlModulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtl_registro_aplicacion_CellContentClick);
            // 
            // txtNombreModulo
            // 
            this.txtNombreModulo.Location = new System.Drawing.Point(281, 268);
            this.txtNombreModulo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNombreModulo.Name = "txtNombreModulo";
            this.txtNombreModulo.Size = new System.Drawing.Size(198, 23);
            this.txtNombreModulo.TabIndex = 19;
            this.txtNombreModulo.Tag = "nombre_modulo";
            this.txtNombreModulo.TextChanged += new System.EventHandler(this.txtNombreModulo_TextChanged);
            // 
            // txtCodigoModulo
            // 
            this.txtCodigoModulo.Location = new System.Drawing.Point(281, 215);
            this.txtCodigoModulo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCodigoModulo.Name = "txtCodigoModulo";
            this.txtCodigoModulo.Size = new System.Drawing.Size(198, 23);
            this.txtCodigoModulo.TabIndex = 18;
            this.txtCodigoModulo.Tag = "pk_id_modulo";
            // 
            // lblDescripcionModulo
            // 
            this.lblDescripcionModulo.AutoSize = true;
            this.lblDescripcionModulo.Location = new System.Drawing.Point(29, 321);
            this.lblDescripcionModulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripcionModulo.Name = "lblDescripcionModulo";
            this.lblDescripcionModulo.Size = new System.Drawing.Size(163, 17);
            this.lblDescripcionModulo.TabIndex = 17;
            this.lblDescripcionModulo.Text = "Descripcion de modulo:";
            this.lblDescripcionModulo.Click += new System.EventHandler(this.lb_infome_de_aplicacion_Click);
            // 
            // lblNombreModulo
            // 
            this.lblNombreModulo.AutoSize = true;
            this.lblNombreModulo.Location = new System.Drawing.Point(29, 268);
            this.lblNombreModulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombreModulo.Name = "lblNombreModulo";
            this.lblNombreModulo.Size = new System.Drawing.Size(139, 17);
            this.lblNombreModulo.TabIndex = 16;
            this.lblNombreModulo.Text = "Nombre de modulo:";
            this.lblNombreModulo.Click += new System.EventHandler(this.lb_nombre_de_aplicacion_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(33, 390);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(65, 23);
            this.txtEstado.TabIndex = 30;
            this.txtEstado.Tag = "estado_modulo";
            this.txtEstado.Visible = false;
            // 
            // gbxEstado
            // 
            this.gbxEstado.Controls.Add(this.rbtnDesabilitado);
            this.gbxEstado.Controls.Add(this.rbtnHabilitado);
            this.gbxEstado.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.gbxEstado.Location = new System.Drawing.Point(183, 390);
            this.gbxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.gbxEstado.Name = "gbxEstado";
            this.gbxEstado.Padding = new System.Windows.Forms.Padding(4);
            this.gbxEstado.Size = new System.Drawing.Size(388, 80);
            this.gbxEstado.TabIndex = 29;
            this.gbxEstado.TabStop = false;
            this.gbxEstado.Text = "Estado";
            // 
            // rbtnDesabilitado
            // 
            this.rbtnDesabilitado.AutoSize = true;
            this.rbtnDesabilitado.Location = new System.Drawing.Point(207, 27);
            this.rbtnDesabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnDesabilitado.Name = "rbtnDesabilitado";
            this.rbtnDesabilitado.Size = new System.Drawing.Size(105, 20);
            this.rbtnDesabilitado.TabIndex = 8;
            this.rbtnDesabilitado.TabStop = true;
            this.rbtnDesabilitado.Text = "Deshabilitado";
            this.rbtnDesabilitado.UseVisualStyleBackColor = true;
            this.rbtnDesabilitado.CheckedChanged += new System.EventHandler(this.rbtnDesabilitado_CheckedChanged);
            // 
            // rbtnHabilitado
            // 
            this.rbtnHabilitado.AutoSize = true;
            this.rbtnHabilitado.Location = new System.Drawing.Point(59, 28);
            this.rbtnHabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnHabilitado.Name = "rbtnHabilitado";
            this.rbtnHabilitado.Size = new System.Drawing.Size(85, 20);
            this.rbtnHabilitado.TabIndex = 7;
            this.rbtnHabilitado.TabStop = true;
            this.rbtnHabilitado.Text = "Habilitado";
            this.rbtnHabilitado.UseVisualStyleBackColor = true;
            this.rbtnHabilitado.CheckedChanged += new System.EventHandler(this.rbtnHabilitado_CheckedChanged);
            // 
            // navegadorModulo
            // 
            this.navegadorModulo.BackColor = System.Drawing.Color.Transparent;
            this.navegadorModulo.Location = new System.Drawing.Point(13, 13);
            this.navegadorModulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegadorModulo.Name = "navegadorModulo";
            this.navegadorModulo.Size = new System.Drawing.Size(1418, 117);
            this.navegadorModulo.TabIndex = 31;
            this.navegadorModulo.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // frmModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1422, 498);
            this.Controls.Add(this.navegadorModulo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.gbxEstado);
            this.Controls.Add(this.txtDescripcionModulo);
            this.Controls.Add(this.lblCodigoModulo);
            this.Controls.Add(this.lblRegistroAplicacion);
            this.Controls.Add(this.dtlModulo);
            this.Controls.Add(this.txtNombreModulo);
            this.Controls.Add(this.txtCodigoModulo);
            this.Controls.Add(this.lblDescripcionModulo);
            this.Controls.Add(this.lblNombreModulo);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmModulo";
            this.Text = "0008-Modulo";
            ((System.ComponentModel.ISupportInitialize)(this.dtlModulo)).EndInit();
            this.gbxEstado.ResumeLayout(false);
            this.gbxEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcionModulo;
        private System.Windows.Forms.Label lblCodigoModulo;
        private System.Windows.Forms.Label lblRegistroAplicacion;
        private System.Windows.Forms.DataGridView dtlModulo;
        private System.Windows.Forms.TextBox txtNombreModulo;
        private System.Windows.Forms.TextBox txtCodigoModulo;
        private System.Windows.Forms.Label lblDescripcionModulo;
        private System.Windows.Forms.Label lblNombreModulo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox gbxEstado;
        private System.Windows.Forms.RadioButton rbtnDesabilitado;
        private System.Windows.Forms.RadioButton rbtnHabilitado;
        private CapaVistaNavegador.Navegador navegadorModulo;
    }
}