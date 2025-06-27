using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryVargas_IEFI
{
    public class SolicitudesxUsuario
    {
        public Usuario Usuario;
        public Solicitud Solicitud;

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }

        public  string TipoSolicitud { get; set; }
        public  DateTime FechaSolicitud { get; set; }
        public  string EstadoSolicitud { get; set; }
    }
}
