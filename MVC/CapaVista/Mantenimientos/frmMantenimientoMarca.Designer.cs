
namespace CapaVista.Mantenimientos
{
    partial class frmMantenimientoMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoMarca));
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.lblcodMarca = new System.Windows.Forms.Label();
            this.lblNombreMarca = new System.Windows.Forms.Label();
            this.lblEstatusMarca = new System.Windows.Forms.Label();
            this.txtCodigoMarca = new System.Windows.Forms.TextBox();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.txtEstatusMarca = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // lblcodMarca
            // 
            this.lblcodMarca.AutoSize = true;
            this.lblcodMarca.Location = new System.Drawing.Point(137, 178);
            this.lblcodMarca.Name = "lblcodMarca";
            this.lblcodMarca.Size = new System.Drawing.Size(73, 13);
            this.lblcodMarca.TabIndex = 1;
            this.lblcodMarca.Text = "Codigo Marca";
            // 
            // lblNombreMarca
            // 
            this.lblNombreMarca.AutoSize = true;
            this.lblNombreMarca.Location = new System.Drawing.Point(133, 229);
            this.lblNombreMarca.Name = "lblNombreMarca";
            this.lblNombreMarca.Size = new System.Drawing.Size(77, 13);
            this.lblNombreMarca.TabIndex = 2;
            this.lblNombreMarca.Text = "Nombre Marca";
            // 
            // lblEstatusMarca
            // 
            this.lblEstatusMarca.AutoSize = true;
            this.lblEstatusMarca.Location = new System.Drawing.Point(137, 285);
            this.lblEstatusMarca.Name = "lblEstatusMarca";
            this.lblEstatusMarca.Size = new System.Drawing.Size(75, 13);
            this.lblEstatusMarca.TabIndex = 3;
            this.lblEstatusMarca.Text = "Estatus Marca";
            // 
            // txtCodigoMarca
            // 
            this.txtCodigoMarca.Location = new System.Drawing.Point(214, 175);
            this.txtCodigoMarca.Name = "txtCodigoMarca";
            this.txtCodigoMarca.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoMarca.TabIndex = 4;
            this.txtCodigoMarca.Tag = "codigo_marca";
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Location = new System.Drawing.Point(214, 226);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMarca.TabIndex = 5;
            this.txtNombreMarca.Tag = "nombre_marca";
            // 
            // txtEstatusMarca
            // 
            this.txtEstatusMarca.Location = new System.Drawing.Point(214, 282);
            this.txtEstatusMarca.Name = "txtEstatusMarca";
            this.txtEstatusMarca.Size = new System.Drawing.Size(100, 20);
            this.txtEstatusMarca.TabIndex = 6;
            this.txtEstatusMarca.Tag = "estatus_marca";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(473, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 235);
            this.dataGridView1.TabIndex = 7;
            // 
            // frmMantenimientoMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1083, 494);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEstatusMarca);
            this.Controls.Add(this.txtNombreMarca);
            this.Controls.Add(this.txtCodigoMarca);
            this.Controls.Add(this.lblEstatusMarca);
            this.Controls.Add(this.lblNombreMarca);
            this.Controls.Add(this.lblcodMarca);
            this.Controls.Add(this.navegador1);
            this.DoubleBuffered = true;
            this.Name = "frmMantenimientoMarca";
            this.Text = "frmMantenimientoMarca";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.Label lblcodMarca;
        private System.Windows.Forms.Label lblNombreMarca;
        private System.Windows.Forms.Label lblEstatusMarca;
        private System.Windows.Forms.TextBox txtCodigoMarca;
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.TextBox txtEstatusMarca;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}