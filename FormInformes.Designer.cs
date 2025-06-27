namespace pryVargas_IEFI
{
    partial class FormInformes
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
            this.btnTareasTerminadas = new FontAwesome.Sharp.IconButton();
            this.panelInformes = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnPersonas = new FontAwesome.Sharp.IconButton();
            this.btnTiempoApp = new FontAwesome.Sharp.IconButton();
            this.panelInformes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTareasTerminadas
            // 
            this.btnTareasTerminadas.BackColor = System.Drawing.Color.Transparent;
            this.btnTareasTerminadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTareasTerminadas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareasTerminadas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTareasTerminadas.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnTareasTerminadas.IconColor = System.Drawing.Color.Gold;
            this.btnTareasTerminadas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTareasTerminadas.IconSize = 70;
            this.btnTareasTerminadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareasTerminadas.Location = new System.Drawing.Point(679, 203);
            this.btnTareasTerminadas.Name = "btnTareasTerminadas";
            this.btnTareasTerminadas.Size = new System.Drawing.Size(311, 124);
            this.btnTareasTerminadas.TabIndex = 2;
            this.btnTareasTerminadas.Text = "Tareas finalizadas";
            this.btnTareasTerminadas.UseVisualStyleBackColor = false;
            // 
            // panelInformes
            // 
            this.panelInformes.Controls.Add(this.btnTareasTerminadas);
            this.panelInformes.Controls.Add(this.btnPersonas);
            this.panelInformes.Controls.Add(this.btnTiempoApp);
            this.panelInformes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInformes.FillColor = System.Drawing.Color.MidnightBlue;
            this.panelInformes.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.panelInformes.FillColor3 = System.Drawing.Color.DarkMagenta;
            this.panelInformes.FillColor4 = System.Drawing.Color.DarkMagenta;
            this.panelInformes.Location = new System.Drawing.Point(0, 0);
            this.panelInformes.Name = "panelInformes";
            this.panelInformes.Size = new System.Drawing.Size(1044, 535);
            this.panelInformes.TabIndex = 3;
            // 
            // btnPersonas
            // 
            this.btnPersonas.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPersonas.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.btnPersonas.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.btnPersonas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonas.IconSize = 70;
            this.btnPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonas.Location = new System.Drawing.Point(363, 203);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(270, 117);
            this.btnPersonas.TabIndex = 3;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.UseVisualStyleBackColor = false;
            // 
            // btnTiempoApp
            // 
            this.btnTiempoApp.BackColor = System.Drawing.Color.Transparent;
            this.btnTiempoApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTiempoApp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiempoApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTiempoApp.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.btnTiempoApp.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTiempoApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTiempoApp.IconSize = 70;
            this.btnTiempoApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiempoApp.Location = new System.Drawing.Point(25, 207);
            this.btnTiempoApp.Name = "btnTiempoApp";
            this.btnTiempoApp.Size = new System.Drawing.Size(321, 113);
            this.btnTiempoApp.TabIndex = 1;
            this.btnTiempoApp.Text = "Tiempo en la APP";
            this.btnTiempoApp.UseVisualStyleBackColor = false;
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 535);
            this.Controls.Add(this.panelInformes);
            this.Name = "FormInformes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.FormInformes_Load);
            this.panelInformes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnTareasTerminadas;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelInformes;
        private FontAwesome.Sharp.IconButton btnPersonas;
        private FontAwesome.Sharp.IconButton btnTiempoApp;
    }
}