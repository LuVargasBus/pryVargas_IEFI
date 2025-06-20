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

    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAdministracion_Load(object sender, EventArgs e)
        {

        }
        private Form formularioActual = null;
        private void AbrirFormularioEnPanel(Form formHijo )
        {
            if (formularioActual != null && formularioActual.GetType() == formHijo.GetType())
                return;
            formularioActual = formHijo;
            panelEscritorio.Controls.Clear();
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formHijo);
            panelEscritorio.Tag = formHijo;
           
            formHijo.BringToFront();
            formHijo.Show();
            lblHome.Text = formHijo.Text;



        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormPersonas());
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormTareas());
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormInformes());
        }
    }
}
