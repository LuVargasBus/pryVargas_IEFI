using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryVargas_IEFI
{
    internal class Usuario
    {
     
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string ContrasenaUsuario { get; set; }
        public string NickName { get; set; }
        public string ImagenUsuario { get; set; }
        public string  RolUsuario {  get; set; }


        public string NombreCompleto => NombreUsuario + " " + ApellidoUsuario;
    }
}
