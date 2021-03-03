namespace CapaVistaSeguridad.Formularios.Mantenimientos
{
    partial class frmConsultarPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarPerfil));
            this.gbxPerfilesdisponibles = new System.Windows.Forms.GroupBox();
            this.lblAplicacion = new System.Windows.Forms.Label();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.dgvPerfilDisponibles = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.gbxPerfilesdisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfilDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPerfilesdisponibles
            // 
            this.gbxPerfilesdisponibles.Controls.Add(this.lblAplicacion);
            this.gbxPerfilesdisponibles.Controls.Add(this.txtPerfil);
            this.gbxPerfilesdisponibles.Controls.Add(this.txtCodigo);
            this.gbxPerfilesdisponibles.Controls.Add(this.lblcodigo);
            this.gbxPerfilesdisponibles.Controls.Add(this.dgvPerfilDisponibles);
            this.gbxPerfilesdisponibles.Controls.Add(this.btnSalir);
            this.gbxPerfilesdisponibles.Controls.Add(this.btnSeleccionar);
            this.gbxPerfilesdisponibles.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPerfilesdisponibles.Location = new System.Drawing.Point(23, 12);
            this.gbxPerfilesdisponibles.Name = "gbxPerfilesdisponibles";
            this.gbxPerfilesdisponibles.Size = new System.Drawing.Size(486, 323);
            this.gbxPerfilesdisponibles.TabIndex = 6;
            this.gbxPerfilesdisponibles.TabStop = false;
            this.gbxPerfilesdisponibles.Text = "Perfiles Disponibles";
            // 
            // lblAplicacion
            // 
            this.lblAplicacion.AutoSize = true;
            this.lblAplicacion.Location = new System.Drawing.Point(228, 36);
            this.lblAplicacion.Name = "lblAplicacion";
            this.lblAplicacion.Size = new System.Drawing.Size(87, 16);
            this.lblAplicacion.TabIndex = 8;
            this.lblAplicacion.Text = "Nombre Perfil";
            // 
            // txtPerfil
            // 
            this.txtPerfil.Location = new System.Drawing.Point(321, 33);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(142, 23);
            this.txtPerfil.TabIndex = 7;
            this.txtPerfil.TextChanged += new System.EventHandler(this.txtPerfil_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(83, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(128, 23);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(26, 33);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(51, 16);
            this.lblcodigo.TabIndex = 5;
            this.lblcodigo.Text = "Código";
            // 
            // dgvPerfilDisponibles
            // 
            this.dgvPerfilDisponibles.AllowUserToAddRows = false;
            this.dgvPerfilDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfilDisponibles.Location = new System.Drawing.Point(18, 76);
            this.dgvPerfilDisponibles.Name = "dgvPerfilDisponibles";
            this.dgvPerfilDisponibles.ReadOnly = true;
            this.dgvPerfilDisponibles.RowHeadersVisible = false;
            this.dgvPerfilDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerfilDisponibles.Size = new System.Drawing.Size(445, 157);
            this.dgvPerfilDisponibles.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(263, 253);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 57);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.White;
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeleccionar.Location = new System.Drawing.Point(89, 253);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(84, 57);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(487, 12);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(35, 33);
            this.btnAyuda.TabIndex = 20;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // frmConsultarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.gbxPerfilesdisponibles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0009-Consultar Perfil";
            this.gbxPerfilesdisponibles.ResumeLayout(false);
            this.gbxPerfilesdisponibles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfilDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPerfilesdisponibles;
        public System.Windows.Forms.DataGridView dgvPerfilDisponibles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblAplicacion;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button btnAyuda;
    }
}