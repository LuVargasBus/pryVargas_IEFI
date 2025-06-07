using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVargas_IEFI
{
    internal class ConexionDB
    {  
            string connectionString = "Server=localhost;Database=AuditoriaIEFI;Trusted_Connection=True;";
            private SqlConnection conn;
            public ConexionDB()
            {

                conn = new SqlConnection(connectionString);

            }
            public void AbrirConexion()
            {
                try
                {

                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        conn.Open();
                        MessageBox.Show("Conexión exitosa a la base de datos.");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);

                }
            }
            public SqlConnection ObtenerConexion()
            {
                return new SqlConnection(connectionString);
            }

    }
 }




