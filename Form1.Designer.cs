namespace TodoListform
{
    partial class frmPrincipal
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
            this.dbgrdMostrar = new System.Windows.Forms.DataGridView();
            this.Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.btnBorrarD = new System.Windows.Forms.Button();
            this.btnSalirP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dbgrdMostrar
            // 
            this.dbgrdMostrar.AllowUserToAddRows = false;
            this.dbgrdMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarea,
            this.Statu,
            this.Usuario,
            this.Fecha,
            this.Hora});
            this.dbgrdMostrar.Location = new System.Drawing.Point(63, 31);
            this.dbgrdMostrar.Name = "dbgrdMostrar";
            this.dbgrdMostrar.ReadOnly = true;
            this.dbgrdMostrar.Size = new System.Drawing.Size(245, 238);
            this.dbgrdMostrar.TabIndex = 0;
            // 
            // Tarea
            // 
            this.Tarea.HeaderText = "Tarea";
            this.Tarea.Name = "Tarea";
            this.Tarea.ReadOnly = true;
            // 
            // Statu
            // 
            this.Statu.HeaderText = "Statu";
            this.Statu.Name = "Statu";
            this.Statu.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Visible = false;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardar.Location = new System.Drawing.Point(346, 31);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 50);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDetalle.Location = new System.Drawing.Point(380, 150);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(77, 33);
            this.btnDetalle.TabIndex = 2;
            this.btnDetalle.Text = "Detalles";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatus.Location = new System.Drawing.Point(488, 31);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(98, 50);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.Text = "Editar Estatu";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detalles de la tarea:";
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(450, 124);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(100, 20);
            this.txtDetalles.TabIndex = 5;
            // 
            // btnBorrarD
            // 
            this.btnBorrarD.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBorrarD.Location = new System.Drawing.Point(356, 227);
            this.btnBorrarD.Name = "btnBorrarD";
            this.btnBorrarD.Size = new System.Drawing.Size(88, 42);
            this.btnBorrarD.TabIndex = 6;
            this.btnBorrarD.Text = "Borrar";
            this.btnBorrarD.UseVisualStyleBackColor = false;
            this.btnBorrarD.Click += new System.EventHandler(this.btnBorrarD_Click);
            // 
            // btnSalirP
            // 
            this.btnSalirP.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSalirP.Location = new System.Drawing.Point(500, 229);
            this.btnSalirP.Name = "btnSalirP";
            this.btnSalirP.Size = new System.Drawing.Size(86, 40);
            this.btnSalirP.TabIndex = 7;
            this.btnSalirP.Text = "Salir";
            this.btnSalirP.UseVisualStyleBackColor = false;
            this.btnSalirP.Click += new System.EventHandler(this.btnSalirP_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(622, 305);
            this.Controls.Add(this.btnSalirP);
            this.Controls.Add(this.btnBorrarD);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dbgrdMostrar);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dbgrdMostrar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnDetalle;
        public System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.Button btnBorrarD;
        private System.Windows.Forms.Button btnSalirP;
    }
}

