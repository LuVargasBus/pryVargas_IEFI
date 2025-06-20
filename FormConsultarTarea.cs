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
    public partial class FormConsultarTarea : Form
    {
        private List<Usuario> listaUsuarios;
        private RepositorioUsuario repoUsuario = new RepositorioUsuario();
        private List<Tareas> listaTareas;
        private RepositorioTareas repoTrarea = new RepositorioTareas();
        private RepositorioTareaxUsuario repoTareaUsuario = new RepositorioTareaxUsuario();
        private List<TareasPorUsuario> listaTareasPorUsuario;

        public FormConsultarTarea()
        {
            InitializeComponent();
            listaUsuarios = repoUsuario.obtenerTodosLosUsuarios();
            listaTareas = repoTrarea.obtenerTodasLasTareas();
            listaTareasPorUsuario = repoTareaUsuario.obtenerTareasPorUsuario();
        }

       
        private void FormConsultarTarea_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarTareas();
            CargarPanelTareas();
        }

        public void CargarPanelTareas()
        {
            dgvPanelTareas.DataSource = null;
            dgvPanelTareas.DataSource = listaTareasPorUsuario;

        }

        private void CargarUsuarios()
        {
            cmbFiltroUsuario.DataSource = listaUsuarios;
            cmbFiltroUsuario.DisplayMember = "NombreCompleto";
            cmbFiltroUsuario.ValueMember = "IdUsuario";
        }

        private void CargarTareas()
        {
   
            cmbFiltroTarea.DataSource = listaTareas;
            cmbFiltroTarea.DisplayMember = "NombreTarea";
            cmbFiltroTarea.ValueMember = "IdTarea";

        }

    }
}
