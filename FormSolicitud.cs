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
    public partial class FormSolicitud : Form
    {
       
        public Solicitud solicitud;
        private RepositorioSolicitudxUsuario solicitudxUsuario;
        public FormSolicitud()
        {
            InitializeComponent();
            
            this.solicitud = solicitud ?? new Solicitud();
            this.solicitudxUsuario = new RepositorioSolicitudxUsuario();
        }

        private void FormSolicitud_Load(object sender, EventArgs e)
        {
            int id = Sesion.UsuarioActual.IdUsuario;
            string rol = Sesion.UsuarioActual.RolUsuario;
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {

            if (radioBtnEstudio.Checked)
                solicitud.TipoSolicitud = "Estudio";
            else if (radioBtnMaternidad.Checked)
                solicitud.TipoSolicitud = "Maternidad";
            else if (radioBtnVacaciones.Checked)
                solicitud.TipoSolicitud = "Vacaciones";
            else if (radioBtnMatrimonio.Checked)
                solicitud.TipoSolicitud = "Matrimonio";
            else if (radioBtnSalud.Checked)
                    solicitud.TipoSolicitud = "Salud";
            else
            {
                MessageBox.Show("Debes seleccionar un tipo de solicitud.");
                return;
            }

            solicitud.FechaSolicitud = DateTime.Now;
            solicitud.EstadoSolicitud = "Pendiente";

            solicitudxUsuario.CrearSolicitud(Sesion.UsuarioActual, solicitud);
            MessageBox.Show("Solicitud registrada correctamente.");
            this.Close();
        }
    }
   


}

