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
    public partial class FormAsignarTarea : Form
    {
        private List<Usuario> listaUsuarios;
        private RepositorioUsuario repoUsuario = new RepositorioUsuario();
        private List<Tareas> listaTareas;
        private RepositorioTareas repoTarea = new RepositorioTareas();
        private RepositorioTareaxUsuario repoTareaUsuario = new RepositorioTareaxUsuario();
        private List<TareasPorUsuario> listaTareasPorUsuario;

        public FormAsignarTarea()
        {
            InitializeComponent();
            listaUsuarios = repoUsuario.obtenerTodosLosUsuarios();
            listaTareas = repoTarea.obtenerTodasLasTareas();
            listaTareasPorUsuario = repoTareaUsuario.obtenerTareasPorUsuario();
        }

        private void FormAsignarTarea_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarTareas();

        }

   
        private void CargarUsuarios()
        {
            cmbUsuario.DataSource = listaUsuarios;
            cmbUsuario.ValueMember = "IdUsuario";
            cmbUsuario.DisplayMember = "NombreCompleto";
        }

        private void CargarTareas()
        {
            cmbTareaUsuario.DataSource = listaTareas;
            cmbTareaUsuario.DisplayMember = "NombreTarea";
            cmbTareaUsuario.ValueMember = "IdTarea";

        }

        private void btnAsignar_Click_1(object sender, EventArgs e)
        {
            string tarea = cmbTareaUsuario.Text;
            string usuario = cmbUsuario.Text;

            var usuarioSeleccionado = cmbUsuario.SelectedItem as Usuario;
            var tareaSeleccionada = cmbTareaUsuario.SelectedItem as Tareas;


            MessageBox.Show($"Tarea: {tarea}" + "  " + $"asignada a: {usuario}");
            repoTareaUsuario.Asignar(usuarioSeleccionado, tareaSeleccionada);
        }
    }
}
