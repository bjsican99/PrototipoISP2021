namespace CapaVistaSeguridad.Formularios.Mantenimientos
{
    partial class frmAgregarAplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarAplicacion));
            this.dgvAplicaciones = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbxAplicacionesdisponibles = new System.Windows.Forms.GroupBox();
            this.lblAplicacion = new System.Windows.Forms.Label();
            this.txtAplicacion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAplicaciones)).BeginInit();
            this.gbxAplicacionesdisponibles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAplicaciones
            // 
            this.dgvAplicaciones.AllowUserToAddRows = false;
            this.dgvAplicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAplicaciones.Location = new System.Drawing.Point(24, 76);
            this.dgvAplicaciones.Name = "dgvAplicaciones";
            this.dgvAplicaciones.ReadOnly = true;
            this.dgvAplicaciones.RowHeadersVisible = false;
            this.dgvAplicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAplicaciones.Size = new System.Drawing.Size(445, 157);
            this.dgvAplicaciones.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.White;
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeleccionar.Location = new System.Drawing.Point(77, 252);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(83, 58);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(270, 252);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 58);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbxAplicacionesdisponibles
            // 
            this.gbxAplicacionesdisponibles.Controls.Add(this.lblAplicacion);
            this.gbxAplicacionesdisponibles.Controls.Add(this.txtAplicacion);
            this.gbxAplicacionesdisponibles.Controls.Add(this.txtCodigo);
            this.gbxAplicacionesdisponibles.Controls.Add(this.lblcodigo);
            this.gbxAplicacionesdisponibles.Controls.Add(this.dgvAplicaciones);
            this.gbxAplicacionesdisponibles.Controls.Add(this.btnSalir);
            this.gbxAplicacionesdisponibles.Controls.Add(this.btnSeleccionar);
            this.gbxAplicacionesdisponibles.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAplicacionesdisponibles.Location = new System.Drawing.Point(23, 12);
            this.gbxAplicacionesdisponibles.Name = "gbxAplicacionesdisponibles";
            this.gbxAplicacionesdisponibles.Size = new System.Drawing.Size(486, 323);
            this.gbxAplicacionesdisponibles.TabIndex = 5;
            this.gbxAplicacionesdisponibles.TabStop = false;
            this.gbxAplicacionesdisponibles.Text = "Aplicaciones Disponibles";
            // 
            // lblAplicacion
            // 
            this.lblAplicacion.AutoSize = true;
            this.lblAplicacion.Location = new System.Drawing.Point(229, 34);
            this.lblAplicacion.Name = "lblAplicacion";
            this.lblAplicacion.Size = new System.Drawing.Size(69, 16);
            this.lblAplicacion.TabIndex = 12;
            this.lblAplicacion.Text = "Aplicación";
            // 
            // txtAplicacion
            // 
            this.txtAplicacion.Location = new System.Drawing.Point(315, 31);
            this.txtAplicacion.Name = "txtAplicacion";
            this.txtAplicacion.Size = new System.Drawing.Size(142, 23);
            this.txtAplicacion.TabIndex = 11;
            this.txtAplicacion.TextChanged += new System.EventHandler(this.txtAplicacion_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(77, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(128, 23);
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(20, 31);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(51, 16);
            this.lblcodigo.TabIndex = 9;
            this.lblcodigo.Text = "Código";
            // 
            // frmAgregarAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.gbxAplicacionesdisponibles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarAplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0007-Agregar Aplicación";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAplicaciones)).EndInit();
            this.gbxAplicacionesdisponibles.ResumeLayout(false);
            this.gbxAplicacionesdisponibles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbxAplicacionesdisponibles;
        public System.Windows.Forms.DataGridView dgvAplicaciones;
        private System.Windows.Forms.Label lblAplicacion;
        private System.Windows.Forms.TextBox txtAplicacion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblcodigo;
    }
}