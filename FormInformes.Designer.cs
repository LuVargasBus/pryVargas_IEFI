namespace pryVargas_IEFI
{
    partial class Informes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informes));
            this.btnTareasTerminadas = new FontAwesome.Sharp.IconButton();
            this.panelInformes = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnTiempoApp = new FontAwesome.Sharp.IconButton();
            this.btnSolicitudes = new FontAwesome.Sharp.IconButton();
            this.lblInforme = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.flowLayoutPanelProgreso = new System.Windows.Forms.FlowLayoutPanel();
            this.chartTiempos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvSolicitud = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelInformes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiempos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitud)).BeginInit();
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
            this.btnTareasTerminadas.IconSize = 50;
            this.btnTareasTerminadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareasTerminadas.Location = new System.Drawing.Point(798, 47);
            this.btnTareasTerminadas.Name = "btnTareasTerminadas";
            this.btnTareasTerminadas.Size = new System.Drawing.Size(354, 58);
            this.btnTareasTerminadas.TabIndex = 2;
            this.btnTareasTerminadas.Text = "Tareas finalizadas";
            this.btnTareasTerminadas.UseVisualStyleBackColor = false;
            this.btnTareasTerminadas.Click += new System.EventHandler(this.btnTareasTerminadas_Click);
            // 
            // panelInformes
            // 
            this.panelInformes.Controls.Add(this.dgvSolicitud);
            this.panelInformes.Controls.Add(this.chartTiempos);
            this.panelInformes.Controls.Add(this.flowLayoutPanelProgreso);
            this.panelInformes.Controls.Add(this.lblInforme);
            this.panelInformes.Controls.Add(this.btnSolicitudes);
            this.panelInformes.Controls.Add(this.btnTareasTerminadas);
            this.panelInformes.Controls.Add(this.btnTiempoApp);
            this.panelInformes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInformes.FillColor = System.Drawing.Color.MidnightBlue;
            this.panelInformes.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.panelInformes.FillColor3 = System.Drawing.Color.DarkMagenta;
            this.panelInformes.FillColor4 = System.Drawing.Color.DarkMagenta;
            this.panelInformes.Location = new System.Drawing.Point(0, 0);
            this.panelInformes.Name = "panelInformes";
            this.panelInformes.Size = new System.Drawing.Size(1356, 758);
            this.panelInformes.TabIndex = 3;
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
            this.btnTiempoApp.IconSize = 50;
            this.btnTiempoApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiempoApp.Location = new System.Drawing.Point(37, 47);
            this.btnTiempoApp.Name = "btnTiempoApp";
            this.btnTiempoApp.Size = new System.Drawing.Size(387, 58);
            this.btnTiempoApp.TabIndex = 1;
            this.btnTiempoApp.Text = "Tiempo en la APP";
            this.btnTiempoApp.UseVisualStyleBackColor = false;
            this.btnTiempoApp.Click += new System.EventHandler(this.btnTiempoApp_Click);
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.BackColor = System.Drawing.Color.Transparent;
            this.btnSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSolicitudes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitudes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSolicitudes.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.btnSolicitudes.IconColor = System.Drawing.Color.DeepPink;
            this.btnSolicitudes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSolicitudes.IconSize = 50;
            this.btnSolicitudes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitudes.Location = new System.Drawing.Point(430, 47);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(362, 58);
            this.btnSolicitudes.TabIndex = 4;
            this.btnSolicitudes.Text = "Solicitudes recibidas";
            this.btnSolicitudes.UseVisualStyleBackColor = false;
            this.btnSolicitudes.Click += new System.EventHandler(this.btnSolicitudes_Click);
            // 
            // lblInforme
            // 
            this.lblInforme.AutoSize = true;
            this.lblInforme.BackColor = System.Drawing.Color.Transparent;
            this.lblInforme.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInforme.Location = new System.Drawing.Point(33, 139);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(80, 24);
            this.lblInforme.TabIndex = 6;
            this.lblInforme.Text = "Informe";
            this.lblInforme.Visible = false;
            // 
            // flowLayoutPanelProgreso
            // 
            this.flowLayoutPanelProgreso.BackColor = System.Drawing.SystemColors.HighlightText;
            this.flowLayoutPanelProgreso.ForeColor = System.Drawing.Color.Indigo;
            this.flowLayoutPanelProgreso.Location = new System.Drawing.Point(98, 186);
            this.flowLayoutPanelProgreso.Name = "flowLayoutPanelProgreso";
            this.flowLayoutPanelProgreso.Size = new System.Drawing.Size(817, 332);
            this.flowLayoutPanelProgreso.TabIndex = 8;
            // 
            // chartTiempos
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTiempos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTiempos.Legends.Add(legend2);
            this.chartTiempos.Location = new System.Drawing.Point(37, 253);
            this.chartTiempos.Name = "chartTiempos";
            this.chartTiempos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTiempos.Series.Add(series2);
            this.chartTiempos.Size = new System.Drawing.Size(631, 334);
            this.chartTiempos.TabIndex = 9;
            this.chartTiempos.Text = "Tiempo en la App";
            // 
            // dgvSolicitud
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvSolicitud.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitud.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSolicitud.ColumnHeadersHeight = 4;
            this.dgvSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitud.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSolicitud.Enabled = false;
            this.dgvSolicitud.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSolicitud.Location = new System.Drawing.Point(181, 226);
            this.dgvSolicitud.Name = "dgvSolicitud";
            this.dgvSolicitud.RowHeadersVisible = false;
            this.dgvSolicitud.RowHeadersWidth = 51;
            this.dgvSolicitud.RowTemplate.Height = 24;
            this.dgvSolicitud.Size = new System.Drawing.Size(822, 292);
            this.dgvSolicitud.TabIndex = 10;
            this.dgvSolicitud.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSolicitud.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSolicitud.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSolicitud.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSolicitud.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSolicitud.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSolicitud.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSolicitud.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSolicitud.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSolicitud.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSolicitud.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSolicitud.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSolicitud.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvSolicitud.ThemeStyle.ReadOnly = false;
            this.dgvSolicitud.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSolicitud.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSolicitud.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSolicitud.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Indigo;
            this.dgvSolicitud.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSolicitud.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSolicitud.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 758);
            this.Controls.Add(this.panelInformes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Informes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.FormInformes_Load);
            this.panelInformes.ResumeLayout(false);
            this.panelInformes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiempos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnTareasTerminadas;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelInformes;
        private FontAwesome.Sharp.IconButton btnTiempoApp;
        private FontAwesome.Sharp.IconButton btnSolicitudes;
        private System.Windows.Forms.Label lblInforme;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProgreso;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSolicitud;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTiempos;
    }
}