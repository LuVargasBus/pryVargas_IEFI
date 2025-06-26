using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pryVargas_IEFI
{
    internal class RepositorioTareas
    {
        private ConexionDB conexion = new ConexionDB();

        public void GuardarTarea(Tareas tareas)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Tareas (nombre_tarea, categoria_tarea, descripcion_tarea, prioridad_tarea, vencimiento_tarea) VALUES (@nombre, @categoria, @descripcion, @prioridad, @vencimiento)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", tareas.NombreTarea);
                    cmd.Parameters.AddWithValue("@categoria", tareas.CategoriaTarea);
                    cmd.Parameters.AddWithValue("@descripcion", tareas.DescripcionTarea);
                    cmd.Parameters.AddWithValue("@prioridad", tareas.PrioridadTarea);
                    cmd.Parameters.AddWithValue("@vencimiento", tareas.VencimientoTarea);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public List<Tareas> obtenerTodasLasTareas()
        {
            List<Tareas> listaTareas = new List<Tareas>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT id_Tarea, nombre_Tarea FROM Tareas";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tareas Tarea = new Tareas()
                        {
                            IdTarea = Convert.ToInt32(reader["id_tarea"]),
                            NombreTarea = reader["nombre_tarea"].ToString(),

                        };

                        listaTareas.Add(Tarea);
                    }
                }
            }

            return listaTareas;
        }


    }
}
