using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryVargas_IEFI
{
    internal class RepositorioTareaxUsuario
    {
        private ConexionDB conexion = new ConexionDB();

        public void Asignar(Usuario usuario, Tareas tareas)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Tareas_Usuario (id_tarea, id_usuario, fecha_asignacion)
                 VALUES (@id_tarea, @id_usuario, @fecha_asignacion)"; ;

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_tarea", tareas.IdTarea);
                    cmd.Parameters.AddWithValue("@id_usuario", usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@fecha_asignacion", DateTime.Now);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<TareasPorUsuario> obtenerTareasPorUsuario()
        {
            List<TareasPorUsuario> listaTareasPorUsuario = new List<TareasPorUsuario>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT u.id_usuario, u.nombre_usuario, u.apellido_usuario, 
                        t.id_tarea, t.nombre_tarea, t.categoria_tarea, t.descripcion_tarea, t.prioridad_tarea, t.vencimiento_tarea,
                        tu.fecha_asignacion
                 FROM Usuarios u
                 JOIN Tareas_Usuario tu ON u.id_usuario = tu.id_usuario
                 JOIN Tareas t ON t.id_tarea = tu.id_tarea";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TareasPorUsuario tareaUsuario = new TareasPorUsuario
                        {
                            IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                            NombreUsuario = reader["nombre_usuario"].ToString(),
                            ApellidoUsuario = reader["apellido_usuario"].ToString(),

                            IdTarea = Convert.ToInt32(reader["id_tarea"]),
                            NombreTarea = reader["nombre_tarea"].ToString(),
                            CategoriaTarea = reader["categoria_tarea"].ToString(),
                            DescripcionTarea = reader["descripcion_tarea"].ToString(),
                            PrioridadTarea = reader["prioridad_tarea"].ToString(),
                            FechaAsignacion = Convert.ToDateTime(reader["fecha_asignacion"]),
                            VencimientoTarea = Convert.ToDateTime(reader["vencimiento_tarea"])

                        };

                        listaTareasPorUsuario.Add(tareaUsuario);
                    }
                }
            }

            return listaTareasPorUsuario;
        }

    }
}
