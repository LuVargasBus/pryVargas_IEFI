using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryVargas_IEFI
{
    public class RepositorioSesion
    {

        private ConexionDB conexion = new ConexionDB();
        public int RegistrarInicioSesion(int idUsuario)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Sesiones (id_usuario, inicio_sesion) OUTPUT INSERTED.id_sesion VALUES (@idUsuario, GETDATE())";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    int idSesion = (int)cmd.ExecuteScalar();
                    return idSesion;
                }
            }
        }


        public void RegistrarFinSesion(int idSesion)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Sesiones SET fin_sesion = GETDATE() WHERE id_sesion = @idSesion";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idSesion", idSesion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public TimeSpan ObtenerTiempoConexion(int idUsuario, int idSesion)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT DATEDIFF (SECOND, inicio_sesion, fin_sesion) 
                FROM Sesiones
                WHERE id_sesion = @idSesion
                AND id_usuario = @idUsuario AND fin_sesion IS NOT NULL";
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idSesion", idSesion);
                    cmd.Parameters.AddWithValue("idUsuario", idUsuario);

                    object result = cmd.ExecuteScalar(); 

                    if (result != null && result != DBNull.Value)
                    {
                        int segundos = Convert.ToInt32(result);
                        return TimeSpan.FromSeconds(segundos);
                    } else 
                        return TimeSpan.Zero;
                }

            }

        }
    }
}
