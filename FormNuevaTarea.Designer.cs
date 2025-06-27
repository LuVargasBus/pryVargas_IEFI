namespace pryVargas_IEFI
{
    partial class FormNuevaTarea
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPrioridadTarea = new System.Windows.Forms.ComboBox();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.dataTimeVencimiento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Vencimiento";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(428, 50);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(384, 151);
            this.txtDescripcion.TabIndex = 21;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(37, 161);
            this.txtCategoria.Multiline = true;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(325, 40);
            this.txtCategoria.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Descripción de la tarea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Prioridad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tarea";
            // 
            // cmbPrioridadTarea
            // 
            this.cmbPrioridadTarea.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioridadTarea.FormattingEnabled = true;
            this.cmbPrioridadTarea.Items.AddRange(new object[] {
            "Alta ",
            "Media",
            "Baja"});
            this.cmbPrioridadTarea.Location = new System.Drawing.Point(37, 291);
            this.cmbPrioridadTarea.Name = "cmbPrioridadTarea";
            this.cmbPrioridadTarea.Size = new System.Drawing.Size(325, 32);
            this.cmbPrioridadTarea.TabIndex = 15;
            // 
            // txtTarea
            // 
            this.txtTarea.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarea.Location = new System.Drawing.Point(37, 50);
            this.txtTarea.Multiline = true;
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(325, 40);
            this.txtTarea.TabIndex = 13;
            // 
            // dataTimeVencimiento
            // 
            this.dataTimeVencimiento.Checked = true;
            this.dataTimeVencimiento.FillColor = System.Drawing.Color.Violet;
            this.dataTimeVencimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataTimeVencimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataTimeVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dataTimeVencimiento.Location = new System.Drawing.Point(428, 291);
            this.dataTimeVencimiento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataTimeVencimiento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataTimeVencimiento.Name = "dataTimeVencimiento";
            this.dataTimeVencimiento.Size = new System.Drawing.Size(370, 54);
            this.dataTimeVencimiento.TabIndex = 25;
            this.dataTimeVencimiento.Value = new System.DateTime(2025, 6, 20, 15, 19, 2, 225);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.FillColor = System.Drawing.Color.Purple;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(602, 397);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 45);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormNuevaTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 490);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataTimeVencimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPrioridadTarea);
            this.Controls.Add(this.txtTarea);
            this.Name = "FormNuevaTarea";
            this.Text = "FormNuevaTarea";
            this.Load += new System.EventHandler(this.FormNuevaTarea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPrioridadTarea;
        private System.Windows.Forms.TextBox txtTarea;
        private Guna.UI2.WinForms.Guna2DateTimePicker dataTimeVencimiento;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
    }
}