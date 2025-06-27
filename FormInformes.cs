using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVargas_IEFI
{
    public partial class Informes : Form
    {
        private RepositorioSolicitudxUsuario repoSolicitud = new RepositorioSolicitudxUsuario();
        private Usuario usuarioLogueado;
        public int IdSesion { get; set; }

        public Informes()
        {
            InitializeComponent();
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
            dgvSolicitud.Visible = false;
            chartTiempos.Visible = false;
            flowLayoutPanelProgreso.Visible = false;

        }

      
        private void btnSolicitudes_Click(object sender, EventArgs e)
        {

            lblInforme.Visible = true;
            lblInforme.Text = "Solicitudes";

            // Oculto todos
           
            chartTiempos.Visible = false;
            flowLayoutPanelProgreso.Visible = false;

            // Solo muestro dgvSolicitud
            dgvSolicitud.Visible = true;

            var listaSolicitudes = repoSolicitud.ObtenerTodasLasSolicitudes();

            dgvSolicitud.DataSource = null;
            dgvSolicitud.DataSource = listaSolicitudes;

            
            dgvSolicitud.Columns["NombreUsuario"].HeaderText = "Nombre";
            dgvSolicitud.Columns["ApellidoUsuario"].HeaderText = "Apellido";
            dgvSolicitud.Columns["TipoSolicitud"].HeaderText = "Tipo de Solicitud";
            dgvSolicitud.Columns["FechaSolicitud"].HeaderText = "Fecha";
            dgvSolicitud.Columns["EstadoSolicitud"].HeaderText = "Estado";
        }

        private void btnTiempoApp_Click(object sender, EventArgs e)
        {

            lblInforme.Visible = true;
            lblInforme.Text = "Tiempo en la App";

            // Oculto todos
            dgvSolicitud.Visible = false;
            flowLayoutPanelProgreso.Visible = false;

            // Solo muestro chartTiempos
            chartTiempos.Visible = true;

            RepositorioSesion repo = new RepositorioSesion();
            var datos = repo.ObtenerTiempoTotalPorUsuario();

            chartTiempos.Series.Clear();
            var serie = chartTiempos.Series.Add("Tiempo en app");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            foreach (var (nombre, segundos) in datos)
            {
                TimeSpan duracion = TimeSpan.FromSeconds(segundos);
                string label = $"{nombre} ({duracion.Hours}h {duracion.Minutes}m)";
                serie.Points.AddXY(label, duracion.TotalMinutes);
            }

            chartTiempos.ChartAreas[0].AxisY.Title = "Minutos en la app";
        }


        private void MostrarProgresoTareas()
        {
            flowLayoutPanelProgreso.Controls.Clear(); 

            RepositorioTareaxUsuario repo = new RepositorioTareaxUsuario();
            var datos = repo.ObtenerProgresoTareasPorUsuario(); 

            foreach (var (nombre, total, finalizadas) in datos)
            {
                // Label con el nombre y porcentaje
                Label lbl = new Label();
                lbl.Text = $"{nombre} - {finalizadas} de {total} tareas finalizadas ({(total == 0 ? 0 : (finalizadas * 100 / total))}%)";
                lbl.AutoSize = true;

                // Barra de progreso
                ProgressBar pb = new ProgressBar();
                pb.Minimum = 0;
                pb.Maximum = total > 0 ? total : 1; // para evitar division por cero
                pb.Value = finalizadas;
                pb.Width = 200;
                pb.Height = 20;

                // Contenedor para orden vertical
                Panel panel = new Panel();
                panel.Width = 250;
                panel.Height = 40;
                panel.Margin = new Padding(5);

                // Añadimos label y barra al panel
                lbl.Location = new Point(0, 0);
                pb.Location = new Point(0, 20);

                panel.Controls.Add(lbl);
                panel.Controls.Add(pb);

                flowLayoutPanelProgreso.Controls.Add(panel);
            }
        }

        private void btnTareasTerminadas_Click(object sender, EventArgs e)
        {
            lblInforme.Visible = true;
            lblInforme.Text = "Tareas Terminadas";

            // Oculto todos
            dgvSolicitud.Visible = false;
            chartTiempos.Visible = false;
          

            // Solo muestro flowLayoutPanelProgreso
            flowLayoutPanelProgreso.Visible = true;
            MostrarProgresoTareas();
        }
    }
}
  

