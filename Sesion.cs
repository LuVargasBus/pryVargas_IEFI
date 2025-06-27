using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryVargas_IEFI
{
    internal class Sesion
    {
        public int IdUsuario { get; set; }
        public int IdSesion { get; set; }
        public static Usuario UsuarioActual { get; set; }

        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public TimeSpan Duracion { get; set; }
    }
}
