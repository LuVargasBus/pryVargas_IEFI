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
            this.panelTareas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultarTareas = new FontAwesome.Sharp.IconButton();
            this.btnAsignarTarea = new FontAwesome.Sharp.IconButton();
            this.btnCrearTareas = new FontAwesome.Sharp.IconButton();
            this.panelTareas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTareas
            // 
            this.panelTareas.BackColor = System.Drawing.Color.Yellow;
            this.panelTareas.Controls.Add(this.panel1);
            this.panelTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTareas.Location = new System.Drawing.Point(0, 0);
            this.panelTareas.Name = "panelTareas";
            this.panelTareas.Size = new System.Drawing.Size(1071, 631);
            this.panelTareas.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConsultarTareas);
            this.panel1.Controls.Add(this.btnAsignarTarea);
            this.panel1.Controls.Add(this.btnCrearTareas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 112);
            this.panel1.TabIndex = 11;
            // 
            // btnConsultarTareas
            // 
            this.btnConsultarTareas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsultarTareas.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnConsultarTareas.IconColor = System.Drawing.Color.Black;
            this.btnConsultarTareas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnConsultarTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarTareas.Location = new System.Drawing.Point(717, 0);
            this.btnConsultarTareas.Name = "btnConsultarTareas";
            this.btnConsultarTareas.Size = new System.Drawing.Size(354, 112);
            this.btnConsultarTareas.TabIndex = 11;
            this.btnConsultarTareas.Text = "Consultar tareas";
            this.btnConsultarTareas.UseVisualStyleBackColor = true;
            this.btnConsultarTareas.Click += new System.EventHandler(this.btnConsultarTareas_Click);
            // 
            // btnAsignarTarea
            // 
            this.btnAsignarTarea.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAsignarTarea.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.btnAsignarTarea.IconColor = System.Drawing.Color.Black;
            this.btnAsignarTarea.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAsignarTarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarTarea.Location = new System.Drawing.Point(362, 0);
            this.btnAsignarTarea.Name = "btnAsignarTarea";
            this.btnAsignarTarea.Size = new System.Drawing.Size(355, 112);
            this.btnAsignarTarea.TabIndex = 10;
            this.btnAsignarTarea.Text = "Asignar Tarea";
            this.btnAsignarTarea.UseVisualStyleBackColor = true;
            this.btnAsignarTarea.Click += new System.EventHandler(this.btnAsignarTarea_Click_1);
            // 
            // btnCrearTareas
            // 
            this.btnCrearTareas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCrearTareas.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.btnCrearTareas.IconColor = System.Drawing.Color.Black;
            this.btnCrearTareas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearTareas.Location = new System.Drawing.Point(0, 0);
            this.btnCrearTareas.Name = "btnCrearTareas";
            this.btnCrearTareas.Size = new System.Drawing.Size(362, 112);
            this.btnCrearTareas.TabIndex = 9;
            this.btnCrearTareas.Text = "Crear tarea";
            this.btnCrearTareas.UseVisualStyleBackColor = true;
            this.btnCrearTareas.Click += new System.EventHandler(this.btnCrearTareas_Click);
            // 
            // FormTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 631);
            this.Controls.Add(this.panelTareas);
            this.Name = "FormTareas";
            this.Text = "FormTareas";
            this.Load += new System.EventHandler(this.FormTareas_Load);
            this.panelTareas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTareas;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnConsultarTareas;
        private FontAwesome.Sharp.IconButton btnAsignarTarea;
        private FontAwesome.Sharp.IconButton btnCrearTareas;
    }
}