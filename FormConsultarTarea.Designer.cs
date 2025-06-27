namespace pryVargas_IEFI
{
    partial class FormConsultarTarea
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPanel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPanelTareas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.cmbFiltroTarea = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbPrioridad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbFiltroUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpFiltroFechas = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanelTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPanel
            // 
            this.lblPanel.AutoSize = true;
            this.lblPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanel.Location = new System.Drawing.Point(26, 275);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(149, 24);
            this.lblPanel.TabIndex = 11;
            this.lblPanel.Text = "Panel de tareas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prioridad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tarea";
            // 
            // dgvPanelTareas
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvPanelTareas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPanelTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPanelTareas.ColumnHeadersHeight = 34;
            this.dgvPanelTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPanelTareas.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPanelTareas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPanelTareas.Location = new System.Drawing.Point(15, 321);
            this.dgvPanelTareas.Name = "dgvPanelTareas";
            this.dgvPanelTareas.RowHeadersVisible = false;
            this.dgvPanelTareas.RowHeadersWidth = 51;
            this.dgvPanelTareas.RowTemplate.Height = 24;
            this.dgvPanelTareas.Size = new System.Drawing.Size(931, 150);
            this.dgvPanelTareas.TabIndex = 13;
            this.dgvPanelTareas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPanelTareas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPanelTareas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPanelTareas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPanelTareas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPanelTareas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPanelTareas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPanelTareas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dgvPanelTareas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPanelTareas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPanelTareas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPanelTareas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPanelTareas.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvPanelTareas.ThemeStyle.ReadOnly = false;
            this.dgvPanelTareas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPanelTareas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPanelTareas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPanelTareas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPanelTareas.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPanelTareas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPanelTareas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.FillColor = System.Drawing.Color.Indigo;
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(766, 162);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 63);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            // 
            // cmbFiltroTarea
            // 
            this.cmbFiltroTarea.AutoRoundedCorners = true;
            this.cmbFiltroTarea.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltroTarea.BorderColor = System.Drawing.Color.Indigo;
            this.cmbFiltroTarea.BorderRadius = 17;
            this.cmbFiltroTarea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltroTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroTarea.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroTarea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroTarea.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbFiltroTarea.ForeColor = System.Drawing.Color.Indigo;
            this.cmbFiltroTarea.ItemHeight = 30;
            this.cmbFiltroTarea.Location = new System.Drawing.Point(12, 67);
            this.cmbFiltroTarea.Name = "cmbFiltroTarea";
            this.cmbFiltroTarea.Size = new System.Drawing.Size(325, 36);
            this.cmbFiltroTarea.TabIndex = 18;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.AutoRoundedCorners = true;
            this.cmbPrioridad.BackColor = System.Drawing.Color.Transparent;
            this.cmbPrioridad.BorderColor = System.Drawing.Color.Indigo;
            this.cmbPrioridad.BorderRadius = 17;
            this.cmbPrioridad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPrioridad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPrioridad.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbPrioridad.ForeColor = System.Drawing.Color.Indigo;
            this.cmbPrioridad.ItemHeight = 30;
            this.cmbPrioridad.Location = new System.Drawing.Point(12, 189);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(325, 36);
            this.cmbPrioridad.TabIndex = 19;
            // 
            // cmbFiltroUsuario
            // 
            this.cmbFiltroUsuario.AutoRoundedCorners = true;
            this.cmbFiltroUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltroUsuario.BorderColor = System.Drawing.Color.Indigo;
            this.cmbFiltroUsuario.BorderRadius = 17;
            this.cmbFiltroUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltroUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroUsuario.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroUsuario.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbFiltroUsuario.ForeColor = System.Drawing.Color.Indigo;
            this.cmbFiltroUsuario.ItemHeight = 30;
            this.cmbFiltroUsuario.Location = new System.Drawing.Point(377, 72);
            this.cmbFiltroUsuario.Name = "cmbFiltroUsuario";
            this.cmbFiltroUsuario.Size = new System.Drawing.Size(325, 36);
            this.cmbFiltroUsuario.TabIndex = 20;
            // 
            // dtpFiltroFechas
            // 
            this.dtpFiltroFechas.Checked = true;
            this.dtpFiltroFechas.FillColor = System.Drawing.Color.Violet;
            this.dtpFiltroFechas.FocusedColor = System.Drawing.Color.DimGray;
            this.dtpFiltroFechas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFiltroFechas.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFiltroFechas.Location = new System.Drawing.Point(378, 189);
            this.dtpFiltroFechas.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFiltroFechas.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFiltroFechas.Name = "dtpFiltroFechas";
            this.dtpFiltroFechas.Size = new System.Drawing.Size(325, 36);
            this.dtpFiltroFechas.TabIndex = 21;
            this.dtpFiltroFechas.Value = new System.DateTime(2025, 6, 26, 23, 53, 35, 588);
            // 
            // FormConsultarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 584);
            this.Controls.Add(this.dtpFiltroFechas);
            this.Controls.Add(this.cmbFiltroUsuario);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.cmbFiltroTarea);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPanelTareas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPanel);
            this.Name = "FormConsultarTarea";
            this.Text = "FormConsultarTarea";
            this.Load += new System.EventHandler(this.FormConsultarTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanelTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPanelTareas;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroTarea;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPrioridad;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroUsuario;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFiltroFechas;
    }
}