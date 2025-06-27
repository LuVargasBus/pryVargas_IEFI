namespace pryVargas_IEFI
{
    partial class FormTareasUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTareasUsuario = new System.Windows.Forms.Label();
            this.cmbPrioridadTarea = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvTareaUsuario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstadoTarea = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTareasUsuario
            // 
            this.lblTareasUsuario.AutoSize = true;
            this.lblTareasUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTareasUsuario.Location = new System.Drawing.Point(44, 199);
            this.lblTareasUsuario.Name = "lblTareasUsuario";
            this.lblTareasUsuario.Size = new System.Drawing.Size(101, 24);
            this.lblTareasUsuario.TabIndex = 13;
            this.lblTareasUsuario.Text = "Mis tareas";
            // 
            // cmbPrioridadTarea
            // 
            this.cmbPrioridadTarea.AutoRoundedCorners = true;
            this.cmbPrioridadTarea.BackColor = System.Drawing.Color.Transparent;
            this.cmbPrioridadTarea.BorderColor = System.Drawing.Color.Indigo;
            this.cmbPrioridadTarea.BorderRadius = 17;
            this.cmbPrioridadTarea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPrioridadTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridadTarea.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPrioridadTarea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPrioridadTarea.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbPrioridadTarea.ForeColor = System.Drawing.Color.Indigo;
            this.cmbPrioridadTarea.ItemHeight = 30;
            this.cmbPrioridadTarea.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.cmbPrioridadTarea.Location = new System.Drawing.Point(38, 97);
            this.cmbPrioridadTarea.Name = "cmbPrioridadTarea";
            this.cmbPrioridadTarea.Size = new System.Drawing.Size(325, 36);
            this.cmbPrioridadTarea.TabIndex = 16;
            this.cmbPrioridadTarea.SelectedIndexChanged += new System.EventHandler(this.cmbPrioridadTarea_SelectedIndexChanged);
            // 
            // dgvTareaUsuario
            // 
            this.dgvTareaUsuario.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTareaUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTareaUsuario.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareaUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTareaUsuario.ColumnHeadersHeight = 4;
            this.dgvTareaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTareaUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTareaUsuario.GridColor = System.Drawing.Color.Indigo;
            this.dgvTareaUsuario.Location = new System.Drawing.Point(38, 237);
            this.dgvTareaUsuario.Name = "dgvTareaUsuario";
            this.dgvTareaUsuario.RowHeadersVisible = false;
            this.dgvTareaUsuario.RowHeadersWidth = 51;
            this.dgvTareaUsuario.RowTemplate.Height = 24;
            this.dgvTareaUsuario.Size = new System.Drawing.Size(946, 255);
            this.dgvTareaUsuario.TabIndex = 17;
            this.dgvTareaUsuario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTareaUsuario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTareaUsuario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTareaUsuario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTareaUsuario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTareaUsuario.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvTareaUsuario.ThemeStyle.GridColor = System.Drawing.Color.Indigo;
            this.dgvTareaUsuario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTareaUsuario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTareaUsuario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTareaUsuario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTareaUsuario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTareaUsuario.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTareaUsuario.ThemeStyle.ReadOnly = false;
            this.dgvTareaUsuario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTareaUsuario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTareaUsuario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTareaUsuario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTareaUsuario.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTareaUsuario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTareaUsuario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Prioridad de tarea";
            // 
            // cmbEstadoTarea
            // 
            this.cmbEstadoTarea.AutoRoundedCorners = true;
            this.cmbEstadoTarea.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstadoTarea.BorderColor = System.Drawing.Color.Indigo;
            this.cmbEstadoTarea.BorderRadius = 17;
            this.cmbEstadoTarea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstadoTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoTarea.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstadoTarea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstadoTarea.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbEstadoTarea.ForeColor = System.Drawing.Color.Indigo;
            this.cmbEstadoTarea.ItemHeight = 30;
            this.cmbEstadoTarea.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.cmbEstadoTarea.Location = new System.Drawing.Point(412, 97);
            this.cmbEstadoTarea.Name = "cmbEstadoTarea";
            this.cmbEstadoTarea.Size = new System.Drawing.Size(325, 36);
            this.cmbEstadoTarea.TabIndex = 19;
            this.cmbEstadoTarea.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoTarea_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(408, 57);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(88, 30);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCambios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCambios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardarCambios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardarCambios.FillColor = System.Drawing.Color.Indigo;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(811, 525);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(173, 68);
            this.btnGuardarCambios.TabIndex = 21;
            this.btnGuardarCambios.Text = "Asignar";
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // FormTareasUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1025, 623);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbEstadoTarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTareaUsuario);
            this.Controls.Add(this.cmbPrioridadTarea);
            this.Controls.Add(this.lblTareasUsuario);
            this.Name = "FormTareasUsuario";
            this.Text = "FormTareasUsuario";
            this.Load += new System.EventHandler(this.FormTareasUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTareasUsuario;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPrioridadTarea;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTareaUsuario;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEstadoTarea;
        private System.Windows.Forms.Label lblEstado;
        private Guna.UI2.WinForms.Guna2Button btnGuardarCambios;
    }
}