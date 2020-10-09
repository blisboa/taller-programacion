namespace calculadora03
{
    partial class saludo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaludar = new System.Windows.Forms.Button();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaludar.ForeColor = System.Drawing.Color.Blue;
            this.btnSaludar.Location = new System.Drawing.Point(308, 281);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(153, 47);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(300, 158);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(161, 20);
            this.txtEstudiante.TabIndex = 1;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(178, 161);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(116, 13);
            this.lblEstudiante.TabIndex = 2;
            this.lblEstudiante.Text = "Nombre del estudiante:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(181, 191);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(113, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido del estudiante";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(300, 191);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(161, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(300, 227);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(161, 20);
            this.txtMatricula.TabIndex = 5;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(181, 230);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(79, 13);
            this.lblMatricula.TabIndex = 6;
            this.lblMatricula.Text = "N° de matricula";
            // 
            // saludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.btnSaludar);
            this.Name = "saludo";
            this.Text = "Saludos";
            this.Load += new System.EventHandler(this.saludo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
    }
}

