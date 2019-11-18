namespace TodoListform
{
    partial class CambiarStatu
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
            this.lblTarea = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCabS = new System.Windows.Forms.TextBox();
            this.txtNuevSta = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Location = new System.Drawing.Point(36, 29);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(102, 13);
            this.lblTarea.TabIndex = 0;
            this.lblTarea.Text = "Tarea a editar statu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nuevo Statu:";
            // 
            // txtCabS
            // 
            this.txtCabS.Location = new System.Drawing.Point(144, 26);
            this.txtCabS.Name = "txtCabS";
            this.txtCabS.Size = new System.Drawing.Size(100, 20);
            this.txtCabS.TabIndex = 2;
            // 
            // txtNuevSta
            // 
            this.txtNuevSta.Location = new System.Drawing.Point(144, 78);
            this.txtNuevSta.Name = "txtNuevSta";
            this.txtNuevSta.Size = new System.Drawing.Size(100, 20);
            this.txtNuevSta.TabIndex = 3;
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCambiar.Location = new System.Drawing.Point(126, 129);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 4;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // CambiarStatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(322, 178);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.txtNuevSta);
            this.Controls.Add(this.txtCabS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTarea);
            this.Name = "CambiarStatu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarStatu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTarea;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCabS;
        public System.Windows.Forms.TextBox txtNuevSta;
        public System.Windows.Forms.Button btnCambiar;
    }
}