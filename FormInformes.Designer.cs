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
            this.panelControlInformes = new System.Windows.Forms.Panel();
            this.panelInformes = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTiempoApp = new FontAwesome.Sharp.IconButton();
            this.btnTareasTerminadas = new FontAwesome.Sharp.IconButton();
            this.btnPersonas = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelControlInformes.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlInformes
            // 
            this.panelControlInformes.Controls.Add(this.btnPersonas);
            this.panelControlInformes.Controls.Add(this.btnTareasTerminadas);
            this.panelControlInformes.Controls.Add(this.btnTiempoApp);
            this.panelControlInformes.Controls.Add(this.panel4);
            this.panelControlInformes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControlInformes.Location = new System.Drawing.Point(0, 0);
            this.panelControlInformes.Name = "panelControlInformes";
            this.panelControlInformes.Size = new System.Drawing.Size(200, 535);
            this.panelControlInformes.TabIndex = 0;
            // 
            // panelInformes
            // 
            this.panelInformes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInformes.Location = new System.Drawing.Point(200, 0);
            this.panelInformes.Name = "panelInformes";
            this.panelInformes.Size = new System.Drawing.Size(844, 535);
            this.panelInformes.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconPictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            // 
            // btnTiempoApp
            // 
            this.btnTiempoApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTiempoApp.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.btnTiempoApp.IconColor = System.Drawing.Color.Black;
            this.btnTiempoApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTiempoApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiempoApp.Location = new System.Drawing.Point(0, 100);
            this.btnTiempoApp.Name = "btnTiempoApp";
            this.btnTiempoApp.Size = new System.Drawing.Size(200, 101);
            this.btnTiempoApp.TabIndex = 1;
            this.btnTiempoApp.Text = "Tiempo en la APP";
            this.btnTiempoApp.UseVisualStyleBackColor = true;
            // 
            // btnTareasTerminadas
            // 
            this.btnTareasTerminadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTareasTerminadas.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnTareasTerminadas.IconColor = System.Drawing.Color.Black;
            this.btnTareasTerminadas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTareasTerminadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareasTerminadas.Location = new System.Drawing.Point(0, 201);
            this.btnTareasTerminadas.Name = "btnTareasTerminadas";
            this.btnTareasTerminadas.Size = new System.Drawing.Size(200, 98);
            this.btnTareasTerminadas.TabIndex = 2;
            this.btnTareasTerminadas.Text = "Tareas finalizadas";
            this.btnTareasTerminadas.UseVisualStyleBackColor = true;
            // 
            // btnPersonas
            // 
            this.btnPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonas.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.btnPersonas.IconColor = System.Drawing.Color.Black;
            this.btnPersonas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonas.Location = new System.Drawing.Point(0, 299);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(200, 109);
            this.btnPersonas.TabIndex = 3;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 53;
            this.iconPictureBox1.Location = new System.Drawing.Point(60, 24);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(60, 53);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 535);
            this.Controls.Add(this.panelInformes);
            this.Controls.Add(this.panelControlInformes);
            this.Name = "FormInformes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.FormInformes_Load);
            this.panelControlInformes.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControlInformes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelInformes;
        private FontAwesome.Sharp.IconButton btnPersonas;
        private FontAwesome.Sharp.IconButton btnTareasTerminadas;
        private FontAwesome.Sharp.IconButton btnTiempoApp;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}