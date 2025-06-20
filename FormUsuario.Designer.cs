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
            this.lblPerfil = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.lblTareasUsuario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrarTareasUsuario = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(231, 84);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(68, 16);
            this.lblNickname.TabIndex = 3;
            this.lblNickname.Text = "Nickname";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(37, 30);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(53, 16);
            this.lblPerfil.TabIndex = 5;
            this.lblPerfil.Text = "Mi perfil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 120);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Location = new System.Drawing.Point(686, 84);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(111, 45);
            this.btnEditarPerfil.TabIndex = 7;
            this.btnEditarPerfil.Text = "Editar mi perfil";
            this.btnEditarPerfil.UseVisualStyleBackColor = true;
            // 
            // lblTareasUsuario
            // 
            this.lblTareasUsuario.AutoSize = true;
            this.lblTareasUsuario.Location = new System.Drawing.Point(40, 289);
            this.lblTareasUsuario.Name = "lblTareasUsuario";
            this.lblTareasUsuario.Size = new System.Drawing.Size(69, 16);
            this.lblTareasUsuario.TabIndex = 8;
            this.lblTareasUsuario.Text = "Mis tareas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 160);
            this.dataGridView1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(292, 289);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(455, 291);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnFiltrarTareasUsuario
            // 
            this.btnFiltrarTareasUsuario.Location = new System.Drawing.Point(686, 277);
            this.btnFiltrarTareasUsuario.Name = "btnFiltrarTareasUsuario";
            this.btnFiltrarTareasUsuario.Size = new System.Drawing.Size(111, 45);
            this.btnFiltrarTareasUsuario.TabIndex = 12;
            this.btnFiltrarTareasUsuario.Text = "Filtrar";
            this.btnFiltrarTareasUsuario.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(686, 159);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(111, 45);
            this.btnCerrarSesion.TabIndex = 13;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 534);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnFiltrarTareasUsuario);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTareasUsuario);
            this.Controls.Add(this.btnEditarPerfil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblNickname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuario";
            this.Text = "Perfil de usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditarPerfil;
        private System.Windows.Forms.Label lblTareasUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnFiltrarTareasUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}