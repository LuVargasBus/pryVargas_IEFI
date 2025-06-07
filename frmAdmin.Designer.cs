namespace pryVargas_IEFI
{
    partial class frmAdmin
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
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnAuditoria = new System.Windows.Forms.Button();
            this.picBoxNick = new System.Windows.Forms.PictureBox();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnBuscarAuditoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(45, 417);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(123, 48);
            this.btnCrearUsuario.TabIndex = 0;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAuditoria
            // 
            this.btnAuditoria.Location = new System.Drawing.Point(197, 417);
            this.btnAuditoria.Name = "btnAuditoria";
            this.btnAuditoria.Size = new System.Drawing.Size(123, 48);
            this.btnAuditoria.TabIndex = 1;
            this.btnAuditoria.Text = "Auditoría";
            this.btnAuditoria.UseVisualStyleBackColor = true;
            this.btnAuditoria.Click += new System.EventHandler(this.btnAuditoria_Click);
            // 
            // picBoxNick
            // 
            this.picBoxNick.Location = new System.Drawing.Point(45, 131);
            this.picBoxNick.Name = "picBoxNick";
            this.picBoxNick.Size = new System.Drawing.Size(258, 239);
            this.picBoxNick.TabIndex = 4;
            this.picBoxNick.TabStop = false;
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(42, 80);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(39, 16);
            this.lblSaludo.TabIndex = 5;
            this.lblSaludo.Text = "Hola!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(634, 300);
            this.dataGridView1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(673, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(356, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(506, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 9;
            // 
            // btnBuscarAuditoria
            // 
            this.btnBuscarAuditoria.Location = new System.Drawing.Point(888, 80);
            this.btnBuscarAuditoria.Name = "btnBuscarAuditoria";
            this.btnBuscarAuditoria.Size = new System.Drawing.Size(102, 38);
            this.btnBuscarAuditoria.TabIndex = 10;
            this.btnBuscarAuditoria.Text = "Buscar";
            this.btnBuscarAuditoria.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 534);
            this.Controls.Add(this.btnBuscarAuditoria);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.picBoxNick);
            this.Controls.Add(this.btnAuditoria);
            this.Controls.Add(this.btnCrearUsuario);
            this.Name = "frmAdmin";
            this.Text = "Administración ";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnAuditoria;
        private System.Windows.Forms.PictureBox picBoxNick;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnBuscarAuditoria;
    }
}