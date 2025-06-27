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
    public partial class FormAdministracion : Form
    {
        public FormAdministracion()
        {
            InitializeComponent();
        }

    
        private void frmAdministracion_Load(object sender, EventArgs e)
        {

        }

        private Form formularioActual = null;
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (formularioActual != null)
                formularioActual.Close();

            formularioActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelContenedorHijos.Controls.Clear();
            panelContenedorHijos.Controls.Add(formHijo);
            panelContenedorHijos.Tag = formHijo;

            formHijo.BringToFront();
            formHijo.Show();
            lblHomee.Text = formHijo.Text;
        }
        private void btnPersonas_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormNuevoUsuario());
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormTareas());
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormInformes());
        }

        private void lblHomee_Click(object sender, EventArgs e)
        {

        }
    }
}
