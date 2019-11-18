namespace TodoListform
{
    partial class AgregarUsuario
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblStatu = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblNTarea = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtStatu = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtNTarea = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.Window;
            this.btnCrear.Location = new System.Drawing.Point(66, 329);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 40);
            this.btnCrear.TabIndex = 21;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblStatu
            // 
            this.lblStatu.AutoSize = true;
            this.lblStatu.Location = new System.Drawing.Point(63, 252);
            this.lblStatu.Name = "lblStatu";
            this.lblStatu.Size = new System.Drawing.Size(85, 13);
            this.lblStatu.TabIndex = 20;
            this.lblStatu.Text = "Statu de la tarea";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(63, 203);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 13);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha de la tarea";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(63, 144);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(86, 13);
            this.lblHora.TabIndex = 18;
            this.lblHora.Text = "Hora de la tarea:";
            // 
            // lblNTarea
            // 
            this.lblNTarea.AutoSize = true;
            this.lblNTarea.Location = new System.Drawing.Point(63, 98);
            this.lblNTarea.Name = "lblNTarea";
            this.lblNTarea.Size = new System.Drawing.Size(89, 13);
            this.lblNTarea.TabIndex = 17;
            this.lblNTarea.Text = "Nombre de tarea:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(63, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 13);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre del usuario";
            // 
            // txtStatu
            // 
            this.txtStatu.Location = new System.Drawing.Point(66, 268);
            this.txtStatu.Name = "txtStatu";
            this.txtStatu.Size = new System.Drawing.Size(100, 20);
            this.txtStatu.TabIndex = 15;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(66, 219);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 14;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(66, 169);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 13;
            // 
            // txtNTarea
            // 
            this.txtNTarea.Location = new System.Drawing.Point(66, 114);
            this.txtNTarea.Name = "txtNTarea";
            this.txtNTarea.Size = new System.Drawing.Size(100, 20);
            this.txtNTarea.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(261, 450);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblStatu);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblNTarea);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtStatu);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtNTarea);
            this.Controls.Add(this.txtNombre);
            this.Name = "AgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCrear;
        public System.Windows.Forms.Label lblStatu;
        public System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Label lblHora;
        public System.Windows.Forms.Label lblNTarea;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox txtStatu;
        public System.Windows.Forms.TextBox txtFecha;
        public System.Windows.Forms.TextBox txtHora;
        public System.Windows.Forms.TextBox txtNTarea;
        public System.Windows.Forms.TextBox txtNombre;
    }
}