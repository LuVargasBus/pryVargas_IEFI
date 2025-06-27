namespace pryVargas_IEFI
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.lblNickname = new System.Windows.Forms.Label();
            this.picBoxUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelUser = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnSolicitudes = new FontAwesome.Sharp.IconButton();
            this.btnVerTareas = new FontAwesome.Sharp.IconButton();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.btnEdiatrPerfil = new FontAwesome.Sharp.IconButton();
            this.lblSaludo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.BackColor = System.Drawing.Color.Transparent;
            this.lblNickname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNickname.Location = new System.Drawing.Point(112, 38);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(110, 24);
            this.lblNickname.TabIndex = 3;
            this.lblNickname.Text = "Nickname";
            // 
            // picBoxUser
            // 
            this.picBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.picBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUser.Image")));
            this.picBoxUser.ImageRotate = 0F;
            this.picBoxUser.Location = new System.Drawing.Point(31, 94);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picBoxUser.Size = new System.Drawing.Size(170, 161);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUser.TabIndex = 14;
            this.picBoxUser.TabStop = false;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.lblSaludo);
            this.panelUser.Controls.Add(this.btnSolicitudes);
            this.panelUser.Controls.Add(this.btnVerTareas);
            this.panelUser.Controls.Add(this.lblNickname);
            this.panelUser.Controls.Add(this.picBoxUser);
            this.panelUser.Controls.Add(this.btnEdiatrPerfil);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUser.FillColor = System.Drawing.Color.MidnightBlue;
            this.panelUser.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelUser.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(259, 631);
            this.panelUser.TabIndex = 15;
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.BackColor = System.Drawing.Color.Transparent;
            this.btnSolicitudes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSolicitudes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSolicitudes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitudes.ForeColor = System.Drawing.Color.Transparent;
            this.btnSolicitudes.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnSolicitudes.IconColor = System.Drawing.Color.SpringGreen;
            this.btnSolicitudes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSolicitudes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitudes.Location = new System.Drawing.Point(12, 509);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(231, 110);
            this.btnSolicitudes.TabIndex = 17;
            this.btnSolicitudes.Text = "Solicitudes";
            this.btnSolicitudes.UseVisualStyleBackColor = false;
            this.btnSolicitudes.Click += new System.EventHandler(this.btnSolicitudes_Click);
            // 
            // btnVerTareas
            // 
            this.btnVerTareas.BackColor = System.Drawing.Color.Transparent;
            this.btnVerTareas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerTareas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerTareas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerTareas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTareas.ForeColor = System.Drawing.Color.Transparent;
            this.btnVerTareas.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.btnVerTareas.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVerTareas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerTareas.Location = new System.Drawing.Point(12, 390);
            this.btnVerTareas.Name = "btnVerTareas";
            this.btnVerTareas.Padding = new System.Windows.Forms.Padding(0, 20, 25, 0);
            this.btnVerTareas.Size = new System.Drawing.Size(231, 105);
            this.btnVerTareas.TabIndex = 16;
            this.btnVerTareas.Text = "Ver mis tareas";
            this.btnVerTareas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerTareas.UseVisualStyleBackColor = false;
            this.btnVerTareas.Click += new System.EventHandler(this.btnVerTareas_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsuario.Location = new System.Drawing.Point(259, 0);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(830, 631);
            this.panelUsuario.TabIndex = 16;
            // 
            // btnEdiatrPerfil
            // 
            this.btnEdiatrPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdiatrPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnEdiatrPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdiatrPerfil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdiatrPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdiatrPerfil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdiatrPerfil.ForeColor = System.Drawing.Color.Transparent;
            this.btnEdiatrPerfil.IconChar = FontAwesome.Sharp.IconChar.Odysee;
            this.btnEdiatrPerfil.IconColor = System.Drawing.Color.DeepPink;
            this.btnEdiatrPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdiatrPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdiatrPerfil.Location = new System.Drawing.Point(12, 274);
            this.btnEdiatrPerfil.Name = "btnEdiatrPerfil";
            this.btnEdiatrPerfil.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.btnEdiatrPerfil.Size = new System.Drawing.Size(231, 110);
            this.btnEdiatrPerfil.TabIndex = 15;
            this.btnEdiatrPerfil.Text = "Editar perfil";
            this.btnEdiatrPerfil.UseVisualStyleBackColor = false;
            this.btnEdiatrPerfil.Click += new System.EventHandler(this.btnEdiatrPerfil_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaludo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSaludo.Location = new System.Drawing.Point(45, 38);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(61, 24);
            this.lblSaludo.TabIndex = 18;
            this.lblSaludo.Text = "Hola,";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 631);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.panelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsuario";
            this.Text = "Mi perfil";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNickname;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picBoxUser;
        private Guna.UI2.WinForms.Guna2GradientPanel panelUser;
        private FontAwesome.Sharp.IconButton btnVerTareas;
        private FontAwesome.Sharp.IconButton btnSolicitudes;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Label lblSaludo;
        private FontAwesome.Sharp.IconButton btnEdiatrPerfil;
    }
}