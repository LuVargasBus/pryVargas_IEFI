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
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.panelAdmin = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnPersonas = new FontAwesome.Sharp.IconButton();
            this.btnInformes = new FontAwesome.Sharp.IconButton();
            this.btnTareas = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.lblHomee = new System.Windows.Forms.Label();
            this.panelContenedorHijos = new System.Windows.Forms.Panel();
            this.panelEscritorio.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelEscritorio.Controls.Add(this.panelContenedorHijos);
            this.panelEscritorio.Controls.Add(this.guna2CustomGradientPanel1);
            this.panelEscritorio.Controls.Add(this.panelAdmin);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(0, 0);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(1106, 629);
            this.panelEscritorio.TabIndex = 2;
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.panel1);
            this.panelAdmin.Controls.Add(this.btnPersonas);
            this.panelAdmin.Controls.Add(this.btnInformes);
            this.panelAdmin.Controls.Add(this.btnTareas);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdmin.FillColor = System.Drawing.Color.MidnightBlue;
            this.panelAdmin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelAdmin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(234, 629);
            this.panelAdmin.TabIndex = 21;
            // 
            // btnPersonas
            // 
            this.btnPersonas.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonas.ForeColor = System.Drawing.Color.White;
            this.btnPersonas.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnPersonas.IconColor = System.Drawing.Color.Yellow;
            this.btnPersonas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonas.IconSize = 58;
            this.btnPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonas.Location = new System.Drawing.Point(12, 487);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.btnPersonas.Size = new System.Drawing.Size(189, 120);
            this.btnPersonas.TabIndex = 2;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonas.UseVisualStyleBackColor = false;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click_1);
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.Transparent;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInformes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInformes.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            this.btnInformes.IconColor = System.Drawing.Color.SpringGreen;
            this.btnInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformes.IconSize = 58;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(12, 345);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.btnInformes.Size = new System.Drawing.Size(189, 125);
            this.btnInformes.TabIndex = 7;
            this.btnInformes.Text = "Informes";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnTareas
            // 
            this.btnTareas.BackColor = System.Drawing.Color.Transparent;
            this.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTareas.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTareas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTareas.IconChar = FontAwesome.Sharp.IconChar.RectangleList;
            this.btnTareas.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTareas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTareas.IconSize = 58;
            this.btnTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareas.Location = new System.Drawing.Point(12, 204);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.btnTareas.Size = new System.Drawing.Size(189, 115);
            this.btnTareas.TabIndex = 6;
            this.btnTareas.Text = "Tareas";
            this.btnTareas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTareas.UseVisualStyleBackColor = false;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 176);
            this.panel1.TabIndex = 8;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(35, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(166, 153);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.lblHomee);
            this.guna2CustomGradientPanel1.Controls.Add(this.iconPictureBox2);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Purple;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.MidnightBlue;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.MidnightBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(234, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(872, 141);
            this.guna2CustomGradientPanel1.TabIndex = 22;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconPictureBox2.IconColor = System.Drawing.Color.MediumVioletRed;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 64;
            this.iconPictureBox2.Location = new System.Drawing.Point(40, 37);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(71, 64);
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            // 
            // lblHomee
            // 
            this.lblHomee.AutoSize = true;
            this.lblHomee.BackColor = System.Drawing.Color.Transparent;
            this.lblHomee.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHomee.Location = new System.Drawing.Point(127, 58);
            this.lblHomee.Name = "lblHomee";
            this.lblHomee.Size = new System.Drawing.Size(63, 24);
            this.lblHomee.TabIndex = 1;
            this.lblHomee.Text = "Home";
            
            // 
            // panelContenedorHijos
            // 
            this.panelContenedorHijos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorHijos.Location = new System.Drawing.Point(234, 141);
            this.panelContenedorHijos.Name = "panelContenedorHijos";
            this.panelContenedorHijos.Size = new System.Drawing.Size(872, 488);
            this.panelContenedorHijos.TabIndex = 23;
            // 
            // FormAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 629);
            this.Controls.Add(this.panelEscritorio);
            this.Name = "FormAdministracion";
            this.Text = "Panel de administración";
            this.Load += new System.EventHandler(this.frmAdministracion_Load);
            this.panelEscritorio.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelEscritorio;
        private FontAwesome.Sharp.IconButton btnPersonas;
        private FontAwesome.Sharp.IconButton btnTareas;
        private FontAwesome.Sharp.IconButton btnInformes;
        private Guna.UI2.WinForms.Guna2GradientPanel panelAdmin;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label lblHomee;
        private System.Windows.Forms.Panel panelContenedorHijos;
    }
}