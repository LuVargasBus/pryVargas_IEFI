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
    public partial class FormTareas : Form
    {
        public FormTareas()
        {
            InitializeComponent();
        }

        private void FormTareas_Load(object sender, EventArgs e)
        {

        }

        private Form formularioActual = null;

        private void AbrirFormularioTareasEnPanel(Form formHijo)
        {
            if (formularioActual != null && formularioActual.GetType() == formHijo.GetType())
                return;
            formularioActual = formHijo;
            panelTareas.Controls.Clear();
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelTareas.Controls.Add(formHijo);
            panelTareas.Tag = formHijo;

            formHijo.BringToFront();
            formHijo.Show();
            //lblHome.Text = formHijo.Text;



        }

        private void btnCrearTraea_Click(object sender, EventArgs e)
        {
            AbrirFormularioTareasEnPanel(new FormNuevaTarea());
        }

        private void btnConsultarTarea_Click(object sender, EventArgs e)
        {
            AbrirFormularioTareasEnPanel(new FormConsultarTarea());
        }

        private void btnAsignarTarea_Click(object sender, EventArgs e)
        {
            AbrirFormularioTareasEnPanel(new FormAsignarTarea());
        }
    }
}
