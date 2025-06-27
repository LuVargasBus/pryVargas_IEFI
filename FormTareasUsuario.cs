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
    public partial class FormTareasUsuario : Form

    {
        private int idUsuario;
        private RepositorioTareaxUsuario repoTareaUsuario = new RepositorioTareaxUsuario();
        
      

        public FormTareasUsuario(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;

        }

        private void FormTareasUsuario_Load(object sender, EventArgs e)
        {
            CargarTareasDelUsuario();
            CargarPrioridad();
            CargarEstados();
           


        }

        private void CargarPrioridad()
        {
            cmbPrioridadTarea.Items.Clear();
            
            cmbPrioridadTarea.Items.Add("Todas"); 
            cmbPrioridadTarea.Items.Add("Alta");
            cmbPrioridadTarea.Items.Add("Media");
            cmbPrioridadTarea.Items.Add("Baja");
            
        }

        private void CargarEstados()
        {
            cmbEstadoTarea.Items.Clear();

            cmbEstadoTarea.Items.Add("Todas");
            cmbEstadoTarea.Items.Add("Pendiente");
            cmbEstadoTarea.Items.Add("En curso");
            cmbEstadoTarea.Items.Add("Finalizadas");

        }

        private void CargarTareasDelUsuario()
        {
            var tareas = repoTareaUsuario.ObtenerTareasUsuarioLogueado(idUsuario);
            dgvTareaUsuario.DataSource = null;
            dgvTareaUsuario.DataSource = tareas;
            ConfigurarColumnaEstadoEditable();
        }
        private void ConfigurarColumnaEstadoEditable()
        {
            if (!dgvTareaUsuario.Columns.Contains("EstadoEditable"))
            {
                DataGridViewComboBoxColumn comboEstado = new DataGridViewComboBoxColumn();
                comboEstado.HeaderText = "Modificar Estado";
                comboEstado.Name = "EstadoEditable";
                comboEstado.DataPropertyName = "EstadoTarea";
                comboEstado.Items.AddRange("Pendiente", "En curso", "Finalizadas");
                dgvTareaUsuario.Columns.Add(comboEstado);
            }
        }


        private void cmbPrioridadTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prioridadSeleccionada = cmbPrioridadTarea.SelectedItem.ToString();
            var todasTareas = repoTareaUsuario.ObtenerTareasUsuarioLogueado(idUsuario);

            List<TareasPorUsuario> filtradas = new List<TareasPorUsuario>();

            if (prioridadSeleccionada == "Alta")
            {
                foreach (var tarea in todasTareas)
                {
                    if (tarea.PrioridadTarea == "Alta")
                    {
                        filtradas.Add(tarea);
                    }
                }
            }
            else if (prioridadSeleccionada == "Media")
            {
                foreach (var tarea in todasTareas)
                {
                    if (tarea.PrioridadTarea == "Media")
                    {
                        filtradas.Add(tarea);
                    }
                }
            }
            else if (prioridadSeleccionada == "Baja")
            {
                foreach (var tarea in todasTareas)
                {
                    if (tarea.PrioridadTarea == "Baja")
                    {
                        filtradas.Add(tarea);
                    }
                }
            }
            else if (prioridadSeleccionada == "Todas")
            {
                filtradas = todasTareas;
            }

            dgvTareaUsuario.DataSource = null;
            dgvTareaUsuario.DataSource = filtradas;
        }

        private void cmbEstadoTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string EstadoSeleccionado = cmbEstadoTarea.SelectedItem.ToString();
            var todasTareas = repoTareaUsuario.ObtenerTareasUsuarioLogueado(idUsuario);

            List<TareasPorUsuario> filtradas = new List<TareasPorUsuario>();

            if (EstadoSeleccionado == "Pendiente")
            {
                foreach (var tarea in todasTareas)
                {
                    if (tarea.EstadoTarea == "Pendiente")
                    {
                        filtradas.Add(tarea);
                    }
                }
            }
            else if (EstadoSeleccionado == "En curso")
            {
                foreach (var tarea in todasTareas)
                {
                    if (tarea.EstadoTarea == "En curso")
                    {
                        filtradas.Add(tarea);
                    }
                }
            }
            else if (EstadoSeleccionado == "Finalizadas")
            {
                foreach (var tarea in todasTareas)
                {
                    if (tarea.EstadoTarea == "Finalizadas")
                    {
                        filtradas.Add(tarea);
                    }
                }
            }
            else if (EstadoSeleccionado == "Todas")
            {
                filtradas = todasTareas;
            }

            dgvTareaUsuario.DataSource = null;
            dgvTareaUsuario.DataSource = filtradas;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvTareaUsuario.Rows)
            {
                if (row.Cells["EstadoEditable"].Value != null)
                {
                    int idTarea = Convert.ToInt32(row.Cells["IdTarea"].Value);
                    string nuevoEstado = row.Cells["EstadoEditable"].Value.ToString();

                    repoTareaUsuario.ModificarEstadoTarea(idTarea, nuevoEstado);
                }
            }

            MessageBox.Show("Estados actualizados correctamente.");
            CargarTareasDelUsuario();
        }
    }
}

