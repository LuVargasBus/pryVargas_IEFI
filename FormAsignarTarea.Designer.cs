namespace pryVargas_IEFI
{
    partial class FormAsignarTarea
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsignar = new Guna.UI2.WinForms.Guna2Button();
            this.cmbTareaUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tarea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // btnAsignar
            // 
            this.btnAsignar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAsignar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAsignar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAsignar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAsignar.FillColor = System.Drawing.Color.Indigo;
            this.btnAsignar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.White;
            this.btnAsignar.Location = new System.Drawing.Point(451, 211);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(173, 68);
            this.btnAsignar.TabIndex = 11;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click_1);
            // 
            // cmbTareaUsuario
            // 
            this.cmbTareaUsuario.AutoRoundedCorners = true;
            this.cmbTareaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cmbTareaUsuario.BorderColor = System.Drawing.Color.Indigo;
            this.cmbTareaUsuario.BorderRadius = 17;
            this.cmbTareaUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTareaUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTareaUsuario.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTareaUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTareaUsuario.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbTareaUsuario.ForeColor = System.Drawing.Color.Indigo;
            this.cmbTareaUsuario.ItemHeight = 30;
            this.cmbTareaUsuario.Location = new System.Drawing.Point(50, 109);
            this.cmbTareaUsuario.Name = "cmbTareaUsuario";
            this.cmbTareaUsuario.Size = new System.Drawing.Size(325, 36);
            this.cmbTareaUsuario.TabIndex = 17;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.AutoRoundedCorners = true;
            this.cmbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cmbUsuario.BorderColor = System.Drawing.Color.Indigo;
            this.cmbUsuario.BorderRadius = 17;
            this.cmbUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUsuario.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbUsuario.ForeColor = System.Drawing.Color.Indigo;
            this.cmbUsuario.ItemHeight = 30;
            this.cmbUsuario.Location = new System.Drawing.Point(50, 243);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(325, 36);
            this.cmbUsuario.TabIndex = 18;
            // 
            // FormAsignarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 369);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.cmbTareaUsuario);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAsignarTarea";
            this.Text = "FormAsignarTarea";
            this.Load += new System.EventHandler(this.FormAsignarTarea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAsignar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTareaUsuario;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUsuario;
    }
}