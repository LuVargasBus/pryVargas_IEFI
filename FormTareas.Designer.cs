namespace pryVargas_IEFI
{
    partial class FormTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTareas));
            this.panelTareas = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnAsignarTarea = new FontAwesome.Sharp.IconButton();
            this.btnConsultarTareas = new FontAwesome.Sharp.IconButton();
            this.btnCrearTareas = new FontAwesome.Sharp.IconButton();
            this.panelTareas.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTareas
            // 
            this.panelTareas.BackColor = System.Drawing.Color.White;
            this.panelTareas.Controls.Add(this.guna2CustomGradientPanel1);
            this.panelTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTareas.Location = new System.Drawing.Point(0, 0);
            this.panelTareas.Name = "panelTareas";
            this.panelTareas.Size = new System.Drawing.Size(1356, 758);
            this.panelTareas.TabIndex = 2;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.btnAsignarTarea);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnConsultarTareas);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnCrearTareas);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Purple;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Purple;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1356, 805);
            this.guna2CustomGradientPanel1.TabIndex = 12;
            // 
            // btnAsignarTarea
            // 
            this.btnAsignarTarea.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsignarTarea.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarTarea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAsignarTarea.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.btnAsignarTarea.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAsignarTarea.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAsignarTarea.IconSize = 70;
            this.btnAsignarTarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarTarea.Location = new System.Drawing.Point(428, 266);
            this.btnAsignarTarea.Name = "btnAsignarTarea";
            this.btnAsignarTarea.Size = new System.Drawing.Size(400, 107);
            this.btnAsignarTarea.TabIndex = 10;
            this.btnAsignarTarea.Text = "Asignar Tarea";
            this.btnAsignarTarea.UseVisualStyleBackColor = false;
            this.btnAsignarTarea.Click += new System.EventHandler(this.btnAsignarTarea_Click_1);
            // 
            // btnConsultarTareas
            // 
            this.btnConsultarTareas.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarTareas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarTareas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTareas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarTareas.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnConsultarTareas.IconColor = System.Drawing.Color.DeepPink;
            this.btnConsultarTareas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnConsultarTareas.IconSize = 70;
            this.btnConsultarTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarTareas.Location = new System.Drawing.Point(428, 438);
            this.btnConsultarTareas.Name = "btnConsultarTareas";
            this.btnConsultarTareas.Size = new System.Drawing.Size(404, 107);
            this.btnConsultarTareas.TabIndex = 11;
            this.btnConsultarTareas.Text = "Consultar tareas";
            this.btnConsultarTareas.UseVisualStyleBackColor = false;
            this.btnConsultarTareas.Click += new System.EventHandler(this.btnConsultarTareas_Click);
            // 
            // btnCrearTareas
            // 
            this.btnCrearTareas.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearTareas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearTareas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTareas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearTareas.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.btnCrearTareas.IconColor = System.Drawing.Color.Gold;
            this.btnCrearTareas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearTareas.IconSize = 70;
            this.btnCrearTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearTareas.Location = new System.Drawing.Point(417, 88);
            this.btnCrearTareas.Name = "btnCrearTareas";
            this.btnCrearTareas.Size = new System.Drawing.Size(411, 107);
            this.btnCrearTareas.TabIndex = 9;
            this.btnCrearTareas.Text = "Crear tarea";
            this.btnCrearTareas.UseVisualStyleBackColor = false;
            this.btnCrearTareas.Click += new System.EventHandler(this.btnCrearTareas_Click);
            // 
            // FormTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 758);
            this.Controls.Add(this.panelTareas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTareas";
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.FormTareas_Load);
            this.panelTareas.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTareas;
        private FontAwesome.Sharp.IconButton btnConsultarTareas;
        private FontAwesome.Sharp.IconButton btnAsignarTarea;
        private FontAwesome.Sharp.IconButton btnCrearTareas;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}