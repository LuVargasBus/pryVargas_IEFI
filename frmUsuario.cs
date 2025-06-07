using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVargas_IEFI
{
    public partial class frmUsuario : Form
    {
         private ConexionDB conexion = new ConexionDB();
        public int IdSesion { get; set; }
        public frmUsuario()
        {
            InitializeComponent();
            this.FormClosing += frmUsuario_FormClosing;
        }

        private void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            RepositorioSesion repoSesion = new RepositorioSesion();
            repoSesion.RegistrarFinSesion(IdSesion);
        }
    }
}
