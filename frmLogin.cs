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
    public partial class frmLogin : Form
    {
        private RepositorioUsuario repositorioUsuario = new RepositorioUsuario();
    
        private RepositorioSesion repositorioSesion = new RepositorioSesion();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nickname = txtNombreUsuario.Text;
            string contrasena = txtContrasena.Text;

            Usuario usuario = repositorioUsuario.ObtenerUsuario(nickname, contrasena);

            if (usuario == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                return;
            }

            int idSesion = repositorioSesion.RegistrarInicioSesion(usuario.IdUsuario);

            if (usuario.RolUsuario == "admin")
            {
                frmAdmin adminForm = new frmAdmin();
               
                adminForm.Show();
            }
            else if (usuario.RolUsuario == "usuario")
            {
                frmUsuario userForm = new frmUsuario();
                userForm.IdSesion = idSesion;
                userForm.Show();
            }
            else
            {
                MessageBox.Show("Rol desconocido.");
                return;
            }

           
        }
    }
}
