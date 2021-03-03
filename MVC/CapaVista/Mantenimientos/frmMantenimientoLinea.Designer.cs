
namespace CapaVista.Mantenimientos
{
    partial class frmMantenimientoLinea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoLinea));
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.lblCodigoLinea = new System.Windows.Forms.Label();
            this.lblNombreLinea = new System.Windows.Forms.Label();
            this.lblEstatusLinea = new System.Windows.Forms.Label();
            this.txtCodigoLinea = new System.Windows.Forms.TextBox();
            this.txtNombreLinea = new System.Windows.Forms.TextBox();
            this.txtEstatusLinea = new System.Windows.Forms.TextBox();
            this.dgvLinea = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinea)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1059, 105);
            this.navegador1.TabIndex = 0;
            // 
            // lblCodigoLinea
            // 
            this.lblCodigoLinea.AutoSize = true;
            this.lblCodigoLinea.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoLinea.Location = new System.Drawing.Point(77, 158);
            this.lblCodigoLinea.Name = "lblCodigoLinea";
            this.lblCodigoLinea.Size = new System.Drawing.Size(84, 13);
            this.lblCodigoLinea.TabIndex = 1;
            this.lblCodigoLinea.Text = "Codigo de Linea";
            // 
            // lblNombreLinea
            // 
            this.lblNombreLinea.AutoSize = true;
            this.lblNombreLinea.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreLinea.Location = new System.Drawing.Point(58, 208);
            this.lblNombreLinea.Name = "lblNombreLinea";
            this.lblNombreLinea.Size = new System.Drawing.Size(103, 13);
            this.lblNombreLinea.TabIndex = 2;
            this.lblNombreLinea.Text = "Nombre de La Linea";
            // 
            // lblEstatusLinea
            // 
            this.lblEstatusLinea.AutoSize = true;
            this.lblEstatusLinea.BackColor = System.Drawing.Color.Transparent;
            this.lblEstatusLinea.Location = new System.Drawing.Point(73, 255);
            this.lblEstatusLinea.Name = "lblEstatusLinea";
            this.lblEstatusLinea.Size = new System.Drawing.Size(88, 13);
            this.lblEstatusLinea.TabIndex = 3;
            this.lblEstatusLinea.Text = "Estatus De Linea";
            // 
            // txtCodigoLinea
            // 
            this.txtCodigoLinea.Location = new System.Drawing.Point(167, 155);
            this.txtCodigoLinea.Name = "txtCodigoLinea";
            this.txtCodigoLinea.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoLinea.TabIndex = 4;
            this.txtCodigoLinea.Tag = "codigo_linea";
            // 
            // txtNombreLinea
            // 
            this.txtNombreLinea.Location = new System.Drawing.Point(167, 205);
            this.txtNombreLinea.Name = "txtNombreLinea";
            this.txtNombreLinea.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLinea.TabIndex = 5;
            this.txtNombreLinea.Tag = "nombre_linea";
            // 
            // txtEstatusLinea
            // 
            this.txtEstatusLinea.Location = new System.Drawing.Point(167, 252);
            this.txtEstatusLinea.Name = "txtEstatusLinea";
            this.txtEstatusLinea.Size = new System.Drawing.Size(100, 20);
            this.txtEstatusLinea.TabIndex = 6;
            this.txtEstatusLinea.Tag = "estatus_linea";
            // 
            // dgvLinea
            // 
            this.dgvLinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinea.Location = new System.Drawing.Point(365, 155);
            this.dgvLinea.Name = "dgvLinea";
            this.dgvLinea.Size = new System.Drawing.Size(623, 188);
            this.dgvLinea.TabIndex = 7;
            // 
            // frmMantenimientoLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.dgvLinea);
            this.Controls.Add(this.txtEstatusLinea);
            this.Controls.Add(this.txtNombreLinea);
            this.Controls.Add(this.txtCodigoLinea);
            this.Controls.Add(this.lblEstatusLinea);
            this.Controls.Add(this.lblNombreLinea);
            this.Controls.Add(this.lblCodigoLinea);
            this.Controls.Add(this.navegador1);
            this.DoubleBuffered = true;
            this.Name = "frmMantenimientoLinea";
            this.Text = "Mantenimiento Linea";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCodigoLinea;
        private System.Windows.Forms.Label lblNombreLinea;
        private System.Windows.Forms.Label lblEstatusLinea;
        private System.Windows.Forms.TextBox txtCodigoLinea;
        private System.Windows.Forms.TextBox txtNombreLinea;
        private System.Windows.Forms.TextBox txtEstatusLinea;
        private System.Windows.Forms.DataGridView dgvLinea;
    }
}