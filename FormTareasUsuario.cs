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
           
        }

        private void CargarPrioridad()
        {
            cmbPrioridadTarea.Items.Clear();
            
            cmbPrioridadTarea.Items.Add("Todas"); 
            cmbPrioridadTarea.Items.Add("Alta");
            cmbPrioridadTarea.Items.Add("Media");
            cmbPrioridadTarea.Items.Add("Baja");
            
        }

        private void CargarTareasDelUsuario()
        {
            var tareas = repoTareaUsuario.ObtenerTareasUsuarioLogueado(idUsuario);
            dgvTareaUsuario.DataSource = null;
            dgvTareaUsuario.DataSource = tareas;
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

    }
}

