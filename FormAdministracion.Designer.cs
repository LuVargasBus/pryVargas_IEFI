namespace pryVargas_IEFI
{
    partial class FormAdministracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministracion));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.btnPersonas = new FontAwesome.Sharp.IconButton();
            this.btnTareas = new FontAwesome.Sharp.IconButton();
            this.btnInformes = new FontAwesome.Sharp.IconButton();
            this.panelBotones = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblHome);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 106);
            this.panel2.TabIndex = 1;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHome.Location = new System.Drawing.Point(73, 47);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(44, 16);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Home";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DeepPink;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DeepPink;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(26, 37);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 35);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(200, 106);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(906, 523);
            this.panelEscritorio.TabIndex = 2;
            // 
            // panelPicture
            // 
            this.panelPicture.Controls.Add(this.picAdmin);
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPicture.Location = new System.Drawing.Point(0, 0);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(200, 160);
            this.panelPicture.TabIndex = 5;
            // 
            // picAdmin
            // 
            this.picAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picAdmin.Image")));
            this.picAdmin.Location = new System.Drawing.Point(21, 25);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(160, 113);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdmin.TabIndex = 0;
            this.picAdmin.TabStop = false;
            // 
            // btnPersonas
            // 
            this.btnPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonas.ForeColor = System.Drawing.Color.White;
            this.btnPersonas.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnPersonas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPersonas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonas.IconSize = 58;
            this.btnPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonas.Location = new System.Drawing.Point(0, 160);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(200, 138);
            this.btnPersonas.TabIndex = 2;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.UseVisualStyleBackColor = false;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click_1);
            // 
            // btnTareas
            // 
            this.btnTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTareas.IconChar = FontAwesome.Sharp.IconChar.RectangleList;
            this.btnTareas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTareas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTareas.IconSize = 58;
            this.btnTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareas.Location = new System.Drawing.Point(0, 298);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(200, 169);
            this.btnTareas.TabIndex = 6;
            this.btnTareas.Text = "Tareas";
            this.btnTareas.UseVisualStyleBackColor = false;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInformes.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            this.btnInformes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformes.IconSize = 58;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(0, 467);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(200, 147);
            this.btnInformes.TabIndex = 7;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelBotones.Controls.Add(this.btnInformes);
            this.panelBotones.Controls.Add(this.btnTareas);
            this.panelBotones.Controls.Add(this.btnPersonas);
            this.panelBotones.Controls.Add(this.panelPicture);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(200, 629);
            this.panelBotones.TabIndex = 0;
            // 
            // FormAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 629);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBotones);
            this.Name = "FormAdministracion";
            this.Text = "frmAdministracion";
            this.Load += new System.EventHandler(this.frmAdministracion_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHome;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panelEscritorio;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox picAdmin;
        private FontAwesome.Sharp.IconButton btnPersonas;
        private FontAwesome.Sharp.IconButton btnTareas;
        private FontAwesome.Sharp.IconButton btnInformes;
        private Guna.UI2.WinForms.Guna2Panel panelBotones;
    }
}