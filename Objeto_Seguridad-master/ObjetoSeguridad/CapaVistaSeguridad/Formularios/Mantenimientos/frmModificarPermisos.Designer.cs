namespace CapaVistaSeguridad.Formularios.Mantenimientos
{
    partial class frmModificarPermisos
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
            this.cb_insertar = new System.Windows.Forms.CheckBox();
            this.cb_modificar = new System.Windows.Forms.CheckBox();
            this.cb_eliminar = new System.Windows.Forms.CheckBox();
            this.cb_consultar = new System.Windows.Forms.CheckBox();
            this.cb_imprimir = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_insertar
            // 
            this.cb_insertar.AutoSize = true;
            this.cb_insertar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_insertar.Location = new System.Drawing.Point(61, 52);
            this.cb_insertar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_insertar.Name = "cb_insertar";
            this.cb_insertar.Size = new System.Drawing.Size(91, 21);
            this.cb_insertar.TabIndex = 0;
            this.cb_insertar.Text = "INSERTAR";
            this.cb_insertar.UseVisualStyleBackColor = true;
            // 
            // cb_modificar
            // 
            this.cb_modificar.AutoSize = true;
            this.cb_modificar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_modificar.Location = new System.Drawing.Point(61, 74);
            this.cb_modificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_modificar.Name = "cb_modificar";
            this.cb_modificar.Size = new System.Drawing.Size(105, 21);
            this.cb_modificar.TabIndex = 1;
            this.cb_modificar.Text = "MODIFICAR";
            this.cb_modificar.UseVisualStyleBackColor = true;
            // 
            // cb_eliminar
            // 
            this.cb_eliminar.AutoSize = true;
            this.cb_eliminar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_eliminar.Location = new System.Drawing.Point(61, 97);
            this.cb_eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_eliminar.Name = "cb_eliminar";
            this.cb_eliminar.Size = new System.Drawing.Size(91, 21);
            this.cb_eliminar.TabIndex = 2;
            this.cb_eliminar.Text = "ELIMINAR";
            this.cb_eliminar.UseVisualStyleBackColor = true;
            // 
            // cb_consultar
            // 
            this.cb_consultar.AutoSize = true;
            this.cb_consultar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_consultar.Location = new System.Drawing.Point(61, 119);
            this.cb_consultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_consultar.Name = "cb_consultar";
            this.cb_consultar.Size = new System.Drawing.Size(108, 21);
            this.cb_consultar.TabIndex = 3;
            this.cb_consultar.Text = "CONSULTAR";
            this.cb_consultar.UseVisualStyleBackColor = true;
            // 
            // cb_imprimir
            // 
            this.cb_imprimir.AutoSize = true;
            this.cb_imprimir.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_imprimir.Location = new System.Drawing.Point(61, 142);
            this.cb_imprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_imprimir.Name = "cb_imprimir";
            this.cb_imprimir.Size = new System.Drawing.Size(87, 21);
            this.cb_imprimir.TabIndex = 4;
            this.cb_imprimir.Text = "IMPRIMIR";
            this.cb_imprimir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(144, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmModificarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(257, 236);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_imprimir);
            this.Controls.Add(this.cb_consultar);
            this.Controls.Add(this.cb_eliminar);
            this.Controls.Add(this.cb_modificar);
            this.Controls.Add(this.cb_insertar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0010-Permisos";
            this.Load += new System.EventHandler(this.frmModificarPermisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_insertar;
        private System.Windows.Forms.CheckBox cb_modificar;
        private System.Windows.Forms.CheckBox cb_eliminar;
        private System.Windows.Forms.CheckBox cb_consultar;
        private System.Windows.Forms.CheckBox cb_imprimir;
        private System.Windows.Forms.Button button1;
    }
}