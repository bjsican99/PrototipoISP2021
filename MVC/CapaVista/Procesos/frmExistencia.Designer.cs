
namespace CapaVista.Procesos
{
    partial class frmExistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExistencia));
            this.button2 = new System.Windows.Forms.Button();
            this.txtCodBodega = new System.Windows.Forms.TextBox();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCodBodega = new System.Windows.Forms.ComboBox();
            this.cmbCodProducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(222, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 56);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtCodBodega
            // 
            this.txtCodBodega.Enabled = false;
            this.txtCodBodega.Location = new System.Drawing.Point(208, 170);
            this.txtCodBodega.Name = "txtCodBodega";
            this.txtCodBodega.Size = new System.Drawing.Size(51, 20);
            this.txtCodBodega.TabIndex = 4;
            this.txtCodBodega.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Enabled = false;
            this.txtCodProducto.Location = new System.Drawing.Point(208, 232);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(51, 20);
            this.txtCodProducto.TabIndex = 5;
            this.txtCodProducto.TextChanged += new System.EventHandler(this.txtCodProducto_TextChanged);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(208, 281);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(178, 20);
            this.txtSaldo.TabIndex = 6;
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo De Bodega";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo de Producto";
            // 
            // cmbCodBodega
            // 
            this.cmbCodBodega.FormattingEnabled = true;
            this.cmbCodBodega.Location = new System.Drawing.Point(265, 169);
            this.cmbCodBodega.Name = "cmbCodBodega";
            this.cmbCodBodega.Size = new System.Drawing.Size(121, 21);
            this.cmbCodBodega.TabIndex = 9;
            this.cmbCodBodega.SelectedIndexChanged += new System.EventHandler(this.cmbCodBodega_SelectedIndexChanged);
            // 
            // cmbCodProducto
            // 
            this.cmbCodProducto.FormattingEnabled = true;
            this.cmbCodProducto.Location = new System.Drawing.Point(265, 231);
            this.cmbCodProducto.Name = "cmbCodProducto";
            this.cmbCodProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbCodProducto.TabIndex = 10;
            this.cmbCodProducto.SelectedIndexChanged += new System.EventHandler(this.cmbCodProducto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Saldo Existencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Actualizar Registro";
            // 
            // frmExistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(490, 490);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCodProducto);
            this.Controls.Add(this.cmbCodBodega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtCodProducto);
            this.Controls.Add(this.txtCodBodega);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.Name = "frmExistencia";
            this.Text = "Existencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCodBodega;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCodBodega;
        private System.Windows.Forms.ComboBox cmbCodProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}