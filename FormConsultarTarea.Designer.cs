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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPanel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFiltroUsuario = new System.Windows.Forms.ComboBox();
            this.cmbFiltroTarea = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvPanelTareas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrioridadTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VencimientoTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanelTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPanel
            // 
            this.lblPanel.AutoSize = true;
            this.lblPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanel.Location = new System.Drawing.Point(51, 300);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(125, 21);
            this.lblPanel.TabIndex = 11;
            this.lblPanel.Text = "Panel de tareas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prioridad";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(30, 142);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(255, 24);
            this.cmbPrioridad.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Usuario";
        
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tarea";
            // 
            // cmbFiltroUsuario
            // 
            this.cmbFiltroUsuario.FormattingEnabled = true;
            this.cmbFiltroUsuario.Location = new System.Drawing.Point(351, 67);
            this.cmbFiltroUsuario.Name = "cmbFiltroUsuario";
            this.cmbFiltroUsuario.Size = new System.Drawing.Size(255, 24);
            this.cmbFiltroUsuario.TabIndex = 4;
          
            // 
            // cmbFiltroTarea
            // 
            this.cmbFiltroTarea.FormattingEnabled = true;
            this.cmbFiltroTarea.Location = new System.Drawing.Point(30, 67);
            this.cmbFiltroTarea.Name = "cmbFiltroTarea";
            this.cmbFiltroTarea.Size = new System.Drawing.Size(255, 24);
            this.cmbFiltroTarea.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(351, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dgvPanelTareas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPanelTareas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPanelTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPanelTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPanelTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.nombreUsuario,
            this.ApellidoUsuario,
            this.IdTarea,
            this.NombreTarea,
            this.CategoriaTarea,
            this.DescripcionTarea,
            this.PrioridadTarea,
            this.VencimientoTarea,
            this.FechaAsignacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPanelTareas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPanelTareas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPanelTareas.Location = new System.Drawing.Point(30, 355);
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
            this.dgvPanelTareas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "Id Usuario";
            this.IdUsuario.MinimumWidth = 6;
            this.IdUsuario.Name = "IdUsuario";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.HeaderText = "Nombre Usuario";
            this.nombreUsuario.MinimumWidth = 6;
            this.nombreUsuario.Name = "nombreUsuario";
            // 
            // ApellidoUsuario
            // 
            this.ApellidoUsuario.HeaderText = "ApellidoUsuario";
            this.ApellidoUsuario.MinimumWidth = 6;
            this.ApellidoUsuario.Name = "ApellidoUsuario";
            // 
            // IdTarea
            // 
            this.IdTarea.HeaderText = "Id Tarea";
            this.IdTarea.MinimumWidth = 6;
            this.IdTarea.Name = "IdTarea";
            // 
            // NombreTarea
            // 
            this.NombreTarea.HeaderText = "Nombre Tarea";
            this.NombreTarea.MinimumWidth = 6;
            this.NombreTarea.Name = "NombreTarea";
            // 
            // CategoriaTarea
            // 
            this.CategoriaTarea.HeaderText = "Categoría Tarea";
            this.CategoriaTarea.MinimumWidth = 6;
            this.CategoriaTarea.Name = "CategoriaTarea";
            // 
            // DescripcionTarea
            // 
            this.DescripcionTarea.HeaderText = "Descripción Tarea";
            this.DescripcionTarea.MinimumWidth = 6;
            this.DescripcionTarea.Name = "DescripcionTarea";
            // 
            // PrioridadTarea
            // 
            this.PrioridadTarea.HeaderText = "Prioridad Tarea";
            this.PrioridadTarea.MinimumWidth = 6;
            this.PrioridadTarea.Name = "PrioridadTarea";
            // 
            // VencimientoTarea
            // 
            this.VencimientoTarea.HeaderText = "Vencimiento Tarea";
            this.VencimientoTarea.MinimumWidth = 6;
            this.VencimientoTarea.Name = "VencimientoTarea";
            // 
            // FechaAsignacion
            // 
            this.FechaAsignacion.HeaderText = "Fecha Asignación";
            this.FechaAsignacion.MinimumWidth = 6;
            this.FechaAsignacion.Name = "FechaAsignacion";
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(738, 126);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 45);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            // 
            // FormConsultarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 584);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFiltroUsuario);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.dgvPanelTareas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPanel);
            this.Controls.Add(this.cmbFiltroTarea);
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
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFiltroUsuario;
        private System.Windows.Forms.ComboBox cmbFiltroTarea;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPanelTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrioridadTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn VencimientoTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAsignacion;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
    }
}