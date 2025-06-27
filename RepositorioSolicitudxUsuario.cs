using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryVargas_IEFI
{
    public class RepositorioSolicitudxUsuario
    {
         
        private ConexionDB conexion = new ConexionDB();

        public void CrearSolicitud(Usuario usuario, Solicitud solicitud)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = @"INSERT INTO Solicitudes_Usuario 
                (id_usuario, nombre_usuario, apellido_usuario, tipo_solicitud, fecha_solicitud, estado_solicitud)
                VALUES 
                (@id_usuario, @nombre_usuario, @apellido_usuario, @tipo_solicitud, @fecha_solicitud, @estado_solicitud)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_usuario", usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@apellido_usuario", usuario.ApellidoUsuario);
                    cmd.Parameters.AddWithValue("@tipo_solicitud", solicitud.TipoSolicitud);
                    cmd.Parameters.AddWithValue("@fecha_solicitud", solicitud.FechaSolicitud);
                    cmd.Parameters.AddWithValue("@estado_solicitud", solicitud.EstadoSolicitud);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<SolicitudesxUsuario> ObtenerTodasLasSolicitudes()
        {
            List<SolicitudesxUsuario> lista = new List<SolicitudesxUsuario>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT id_usuario, nombre_usuario, apellido_usuario, tipo_solicitud, fecha_solicitud, estado_solicitud
                         FROM Solicitudes_Usuario";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SolicitudesxUsuario solicitud = new SolicitudesxUsuario
                            {
                                IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                                NombreUsuario = reader["nombre_usuario"].ToString(),
                                ApellidoUsuario = reader["apellido_usuario"].ToString(),
                                TipoSolicitud = reader["tipo_solicitud"].ToString(),
                                FechaSolicitud = Convert.ToDateTime(reader["fecha_solicitud"]),
                                EstadoSolicitud = reader["estado_solicitud"].ToString()
                            };
                            lista.Add(solicitud);
                        }
                    }
                }
            }

            return lista;
        }

    }
}

