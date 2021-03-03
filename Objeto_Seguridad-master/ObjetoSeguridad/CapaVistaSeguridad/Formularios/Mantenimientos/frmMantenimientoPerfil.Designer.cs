namespace CapaVistaSeguridad.Formularios.Mantenimientos
{
    partial class frmMantenimientoPerfil
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
            this.dgvperfil = new System.Windows.Forms.DataGridView();
            this.lblCodigoPerfil = new System.Windows.Forms.Label();
            this.lblNombrePerfil = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.gbxEstado = new System.Windows.Forms.GroupBox();
            this.rbtnDesabilitado = new System.Windows.Forms.RadioButton();
            this.rbtnHabilitado = new System.Windows.Forms.RadioButton();
            this.txtCodPerfil = new System.Windows.Forms.TextBox();
            this.txtNombrePerfil = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.navegador2 = new CapaVistaNavegador.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgvperfil)).BeginInit();
            this.gbxEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvperfil
            // 
            this.dgvperfil.AllowUserToAddRows = false;
            this.dgvperfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvperfil.Location = new System.Drawing.Point(405, 167);
            this.dgvperfil.Name = "dgvperfil";
            this.dgvperfil.ReadOnly = true;
            this.dgvperfil.Size = new System.Drawing.Size(502, 208);
            this.dgvperfil.TabIndex = 14;
            // 
            // lblCodigoPerfil
            // 
            this.lblCodigoPerfil.AutoSize = true;
            this.lblCodigoPerfil.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPerfil.Location = new System.Drawing.Point(15, 121);
            this.lblCodigoPerfil.Name = "lblCodigoPerfil";
            this.lblCodigoPerfil.Size = new System.Drawing.Size(83, 16);
            this.lblCodigoPerfil.TabIndex = 0;
            this.lblCodigoPerfil.Text = "Código Perfil";
            // 
            // lblNombrePerfil
            // 
            this.lblNombrePerfil.AutoSize = true;
            this.lblNombrePerfil.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.lblNombrePerfil.Location = new System.Drawing.Point(11, 157);
            this.lblNombrePerfil.Name = "lblNombrePerfil";
            this.lblNombrePerfil.Size = new System.Drawing.Size(87, 16);
            this.lblNombrePerfil.TabIndex = 0;
            this.lblNombrePerfil.Text = "Nombre Prefil";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.lblDescripcion.Location = new System.Drawing.Point(21, 198);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(77, 16);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción";
            // 
            // gbxEstado
            // 
            this.gbxEstado.Controls.Add(this.rbtnDesabilitado);
            this.gbxEstado.Controls.Add(this.rbtnHabilitado);
            this.gbxEstado.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.gbxEstado.Location = new System.Drawing.Point(36, 293);
            this.gbxEstado.Name = "gbxEstado";
            this.gbxEstado.Size = new System.Drawing.Size(291, 65);
            this.gbxEstado.TabIndex = 6;
            this.gbxEstado.TabStop = false;
            this.gbxEstado.Text = "Estado";
            // 
            // rbtnDesabilitado
            // 
            this.rbtnDesabilitado.AutoSize = true;
            this.rbtnDesabilitado.Location = new System.Drawing.Point(140, 22);
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
            this.rbtnHabilitado.Location = new System.Drawing.Point(18, 22);
            this.rbtnHabilitado.Name = "rbtnHabilitado";
            this.rbtnHabilitado.Size = new System.Drawing.Size(85, 20);
            this.rbtnHabilitado.TabIndex = 7;
            this.rbtnHabilitado.TabStop = true;
            this.rbtnHabilitado.Text = "Habilitado";
            this.rbtnHabilitado.UseVisualStyleBackColor = true;
            this.rbtnHabilitado.CheckedChanged += new System.EventHandler(this.rbtnHabilitado_CheckedChanged);
            // 
            // txtCodPerfil
            // 
            this.txtCodPerfil.Location = new System.Drawing.Point(115, 121);
            this.txtCodPerfil.Name = "txtCodPerfil";
            this.txtCodPerfil.Size = new System.Drawing.Size(153, 20);
            this.txtCodPerfil.TabIndex = 15;
            this.txtCodPerfil.Tag = "pk_id_perfil";
            // 
            // txtNombrePerfil
            // 
            this.txtNombrePerfil.Location = new System.Drawing.Point(115, 157);
            this.txtNombrePerfil.Name = "txtNombrePerfil";
            this.txtNombrePerfil.Size = new System.Drawing.Size(212, 20);
            this.txtNombrePerfil.TabIndex = 16;
            this.txtNombrePerfil.Tag = "nombre_perfil";
            this.txtNombrePerfil.TextChanged += new System.EventHandler(this.txtNombrePerfil_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(115, 194);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(212, 93);
            this.txtDescripcion.TabIndex = 17;
            this.txtDescripcion.Tag = "descripcion_perfil";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(24, 261);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(50, 20);
            this.txtEstado.TabIndex = 18;
            this.txtEstado.Tag = "estado_perfil";
            this.txtEstado.Visible = false;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(17, 17);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1059, 98);
            this.navegador1.TabIndex = 19;
            this.navegador1.Load += new System.EventHandler(this.Navegador_Load);
            // 
            // navegador2
            // 
            this.navegador2.BackColor = System.Drawing.Color.Transparent;
            this.navegador2.Location = new System.Drawing.Point(373, 441);
            this.navegador2.Name = "navegador2";
            this.navegador2.Size = new System.Drawing.Size(1059, 105);
            this.navegador2.TabIndex = 20;
            // 
            // frmMantenimientoPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1089, 440);
            this.Controls.Add(this.navegador2);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombrePerfil);
            this.Controls.Add(this.txtCodPerfil);
            this.Controls.Add(this.dgvperfil);
            this.Controls.Add(this.gbxEstado);
            this.Controls.Add(this.lblCodigoPerfil);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombrePerfil);
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0004-Mantenimiento Perfil";
            this.Load += new System.EventHandler(this.frmMantenimientoPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvperfil)).EndInit();
            this.gbxEstado.ResumeLayout(false);
            this.gbxEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvperfil;
        private System.Windows.Forms.Label lblCodigoPerfil;
        private System.Windows.Forms.Label lblNombrePerfil;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox gbxEstado;
        private System.Windows.Forms.RadioButton rbtnDesabilitado;
        private System.Windows.Forms.RadioButton rbtnHabilitado;
        private System.Windows.Forms.TextBox txtCodPerfil;
        private System.Windows.Forms.TextBox txtNombrePerfil;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtEstado;
        private CapaVistaNavegador.Navegador navegador1;
        private CapaVistaNavegador.Navegador navegador2;
    }
}