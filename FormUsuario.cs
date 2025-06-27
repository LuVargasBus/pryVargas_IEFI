using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVargas_IEFI
{
    public partial class FormUsuario : Form
    {
        private ConexionDB conexion = new ConexionDB();
        private Usuario usuarioLogueado;

        public int IdSesion { get; set; }
        public FormUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.FormClosing += frmUsuario_FormClosing;
            usuarioLogueado = usuario;
        }

        private void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            RepositorioSesion repoSesion = new RepositorioSesion();
            repoSesion.RegistrarFinSesion(IdSesion);
        }

        private Form formularioActual = null;
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (formularioActual != null && formularioActual.GetType() == formHijo.GetType())
                return;
            formularioActual = formHijo;
            panelUsuario.Controls.Clear();
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelUsuario.Controls.Add(formHijo);
            panelUsuario.Tag = formHijo;

            formHijo.BringToFront();
            formHijo.Show();
           
           lblNickname.Text = usuarioLogueado.NickName;



        }


        //private void btnEdiatrPerfil_Click(object sender, EventArgs e)
        //{
        //    //AbrirFormularioEnPanel(new FormEditarPerfil());
        //}

        private void FormUsuario_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormTareasUsuario(usuarioLogueado.IdUsuario));
        }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormSolicitud());
        }

     
    }
}
