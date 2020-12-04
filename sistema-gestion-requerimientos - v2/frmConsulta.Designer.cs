namespace sistema_gestion_requerimientos
{
    partial class frmConsulta
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
            this.cmbTipoRequerimiento = new System.Windows.Forms.ComboBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblTipoRequerimiento = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvRequeriminetos = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.rbtPendiente = new System.Windows.Forms.RadioButton();
            this.rbtResuelto = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequeriminetos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoRequerimiento
            // 
            this.cmbTipoRequerimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoRequerimiento.FormattingEnabled = true;
            this.cmbTipoRequerimiento.Location = new System.Drawing.Point(163, 36);
            this.cmbTipoRequerimiento.Name = "cmbTipoRequerimiento";
            this.cmbTipoRequerimiento.Size = new System.Drawing.Size(212, 21);
            this.cmbTipoRequerimiento.TabIndex = 0;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(163, 75);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(212, 21);
            this.cmbPrioridad.TabIndex = 1;
            // 
            // lblTipoRequerimiento
            // 
            this.lblTipoRequerimiento.AutoSize = true;
            this.lblTipoRequerimiento.Location = new System.Drawing.Point(43, 39);
            this.lblTipoRequerimiento.Name = "lblTipoRequerimiento";
            this.lblTipoRequerimiento.Size = new System.Drawing.Size(114, 13);
            this.lblTipoRequerimiento.TabIndex = 2;
            this.lblTipoRequerimiento.Text = "Tipo de Requerimiento";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(43, 83);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(48, 13);
            this.lblPrioridad.TabIndex = 3;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(300, 123);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvRequeriminetos
            // 
            this.dgvRequeriminetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequeriminetos.Location = new System.Drawing.Point(46, 181);
            this.dgvRequeriminetos.Name = "dgvRequeriminetos";
            this.dgvRequeriminetos.Size = new System.Drawing.Size(625, 150);
            this.dgvRequeriminetos.TabIndex = 7;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(46, 13);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 13);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario conectado:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(163, 10);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(212, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // rbtPendiente
            // 
            this.rbtPendiente.AutoSize = true;
            this.rbtPendiente.Checked = true;
            this.rbtPendiente.Location = new System.Drawing.Point(49, 126);
            this.rbtPendiente.Name = "rbtPendiente";
            this.rbtPendiente.Size = new System.Drawing.Size(78, 17);
            this.rbtPendiente.TabIndex = 10;
            this.rbtPendiente.TabStop = true;
            this.rbtPendiente.Text = "Pendientes";
            this.rbtPendiente.UseVisualStyleBackColor = true;
            // 
            // rbtResuelto
            // 
            this.rbtResuelto.AutoSize = true;
            this.rbtResuelto.Location = new System.Drawing.Point(163, 123);
            this.rbtResuelto.Name = "rbtResuelto";
            this.rbtResuelto.Size = new System.Drawing.Size(72, 17);
            this.rbtResuelto.TabIndex = 11;
            this.rbtResuelto.Text = "Resueltos";
            this.rbtResuelto.UseVisualStyleBackColor = true;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 366);
            this.Controls.Add(this.rbtResuelto);
            this.Controls.Add(this.rbtPendiente);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.dgvRequeriminetos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblTipoRequerimiento);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.cmbTipoRequerimiento);
            this.Name = "frmConsulta";
            this.Text = "Consulta de Requerimientos";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequeriminetos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoRequerimiento;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label lblTipoRequerimiento;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvRequeriminetos;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.RadioButton rbtPendiente;
        private System.Windows.Forms.RadioButton rbtResuelto;
    }
}