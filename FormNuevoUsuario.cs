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
    public partial class FormNuevoUsuario : Form
    {
        private RepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }

       
        private void FormNuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click_1(object sender, EventArgs e)
        {

            try
            {
                Usuario nuevoUsuario = new Usuario
                {
                    NombreUsuario = txtNombre.Text,
                    ApellidoUsuario = txtApellido.Text,
                    RolUsuario = cmbRol.Text,
                    ContrasenaUsuario = txtContraseña.Text,
                    NickName = txtNickname.Text,
                    ImagenUsuario = " "

                };
                repositorioUsuario.GuardarUsuario(nuevoUsuario);
                MessageBox.Show("Usuario guardado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
