using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryVargas_IEFI
{
    internal class Tareas
    {
        public int IdTarea { get; set; }
        public string NombreTarea { get; set; }
        public string CategoriaTarea { get; set; }
        public string DescripcionTarea { get; set; }
        public string PrioridadTarea { get; set; }
        public DateTime VencimientoTarea { get; set; }

        public string EstadoTarea { get; set; }
    }
}
