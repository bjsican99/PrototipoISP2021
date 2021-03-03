
namespace CapaVista.Mantenimientos
{
    partial class frmBodegas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBodegas));
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.dgvBodegas = new System.Windows.Forms.DataGridView();
            this.lblCodBodega = new System.Windows.Forms.Label();
            this.lblNomBodega = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rbtnHabilitado = new System.Windows.Forms.RadioButton();
            this.rbtnDeshabilidado = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodegas)).BeginInit();
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
            // dgvBodegas
            // 
            this.dgvBodegas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBodegas.Location = new System.Drawing.Point(570, 123);
            this.dgvBodegas.Name = "dgvBodegas";
            this.dgvBodegas.Size = new System.Drawing.Size(468, 198);
            this.dgvBodegas.TabIndex = 1;
            // 
            // lblCodBodega
            // 
            this.lblCodBodega.AutoSize = true;
            this.lblCodBodega.Location = new System.Drawing.Point(140, 143);
            this.lblCodBodega.Name = "lblCodBodega";
            this.lblCodBodega.Size = new System.Drawing.Size(95, 13);
            this.lblCodBodega.TabIndex = 2;
            this.lblCodBodega.Text = "Codigo de Bodega";
            // 
            // lblNomBodega
            // 
            this.lblNomBodega.AutoSize = true;
            this.lblNomBodega.Location = new System.Drawing.Point(136, 192);
            this.lblNomBodega.Name = "lblNomBodega";
            this.lblNomBodega.Size = new System.Drawing.Size(99, 13);
            this.lblNomBodega.TabIndex = 3;
            this.lblNomBodega.Text = "Nombre de Bodega";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(153, 243);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(82, 13);
            this.lblEstatus.TabIndex = 4;
            this.lblEstatus.Text = "Estatus Bodega";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Tag = "codigo_bodega";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(241, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Tag = "nombre_bodega";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(241, 301);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Tag = "estatus_bodega";
            this.textBox3.Visible = false;
            // 
            // rbtnHabilitado
            // 
            this.rbtnHabilitado.AutoSize = true;
            this.rbtnHabilitado.Location = new System.Drawing.Point(241, 241);
            this.rbtnHabilitado.Name = "rbtnHabilitado";
            this.rbtnHabilitado.Size = new System.Drawing.Size(72, 17);
            this.rbtnHabilitado.TabIndex = 8;
            this.rbtnHabilitado.TabStop = true;
            this.rbtnHabilitado.Text = "Habilitado";
            this.rbtnHabilitado.UseVisualStyleBackColor = true;
            // 
            // rbtnDeshabilidado
            // 
            this.rbtnDeshabilidado.AutoSize = true;
            this.rbtnDeshabilidado.Location = new System.Drawing.Point(319, 241);
            this.rbtnDeshabilidado.Name = "rbtnDeshabilidado";
            this.rbtnDeshabilidado.Size = new System.Drawing.Size(89, 17);
            this.rbtnDeshabilidado.TabIndex = 9;
            this.rbtnDeshabilidado.TabStop = true;
            this.rbtnDeshabilidado.Text = "Deshabilitado";
            this.rbtnDeshabilidado.UseVisualStyleBackColor = true;
            // 
            // frmBodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 450);
            this.Controls.Add(this.rbtnDeshabilidado);
            this.Controls.Add(this.rbtnHabilitado);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.lblNomBodega);
            this.Controls.Add(this.lblCodBodega);
            this.Controls.Add(this.dgvBodegas);
            this.Controls.Add(this.navegador1);
            this.DoubleBuffered = true;
            this.Name = "frmBodegas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bodegas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodegas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.DataGridView dgvBodegas;
        private System.Windows.Forms.Label lblCodBodega;
        private System.Windows.Forms.Label lblNomBodega;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton rbtnHabilitado;
        private System.Windows.Forms.RadioButton rbtnDeshabilidado;
    }
}