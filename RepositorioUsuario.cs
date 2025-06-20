using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryVargas_IEFI
{
    internal class RepositorioUsuario
    {
        
        
            private ConexionDB conexion = new ConexionDB();

            public void GuardarUsuario(Usuario usuario)
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "INSERT INTO Usuarios (nombre_usuario, apellido_usuario, contrasena_usuario, nickname_usuario, imagen_usuario, rol_usuario) VALUES (@nombre, @apellido, @contrasena, @nickname, @imagen, @rol)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", usuario.NombreUsuario);
                        cmd.Parameters.AddWithValue("@apellido", usuario.ApellidoUsuario);
                        cmd.Parameters.AddWithValue("@contrasena", usuario.ContrasenaUsuario);
                        cmd.Parameters.AddWithValue("@nickname", usuario.NickName);
                        cmd.Parameters.AddWithValue("@imagen", usuario.ImagenUsuario);
                        cmd.Parameters.AddWithValue("@rol", usuario.RolUsuario);

                        cmd.ExecuteNonQuery();
                    }
                }
            }


        public Usuario ObtenerUsuario(string nickname, string contrasena)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT id_usuario, rol_usuario FROM Usuarios WHERE nickname_usuario = @nickname AND contrasena_usuario = @contrasena";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nickname", nickname);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                IdUsuario = reader.GetInt32(0),
                                RolUsuario = reader.GetString(1),
                                NickName = nickname,
                                ContrasenaUsuario = contrasena
                            };
                        } 

                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public List<Usuario> obtenerTodosLosUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT id_usuario, nombre_usuario, apellido_usuario, nick_name, contrasena_usuario FROM Usuarios";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario
                        {
                            IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                            NombreUsuario = reader["nombre_usuario"].ToString(),
                            ApellidoUsuario = reader["apellido_usuario"].ToString(),

                        };

                        listaUsuarios.Add(usuario);
                    }
                }
            }

            return listaUsuarios;
        }


    }
}


