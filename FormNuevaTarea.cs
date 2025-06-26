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
    public partial class FormNuevaTarea : Form
    {
        RepositorioTareas repositorioTareas = new RepositorioTareas();
        public FormNuevaTarea()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Tareas nuevaTarea = new Tareas()
                {
                    NombreTarea = txtTarea.Text,
                    CategoriaTarea = txtCategoria.Text,
                    DescripcionTarea = txtDescripcion.Text,
                    PrioridadTarea = cmbPrioridadTarea.Text,
                    VencimientoTarea = DateTime.Parse(dataTimeVencimiento.Text)

                };

                repositorioTareas.GuardarTarea(nuevaTarea);
                MessageBox.Show("Tarea guardadada correctamente.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     
    }
    
}
