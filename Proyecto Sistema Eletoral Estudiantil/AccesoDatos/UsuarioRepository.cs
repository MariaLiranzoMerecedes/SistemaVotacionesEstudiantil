using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AccesoDatos;
using Entidades;


namespace AccesoDatos
{
    public class UsuarioRepository
    {
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista =
                new List<Usuario>();

            using (SqlConnection c =
                new ConnectionClass().ObtenerConexion())
            {
                string sql =
                @"SELECT * FROM Usuarios";

                SqlCommand cmd =
                    new SqlCommand(sql, c);

                SqlDataReader r =
                    cmd.ExecuteReader();

                while (r.Read())
                {
                    Usuario u = new Usuario();

                    u.Id = (int)r["Id"];
                    u.Nombre = r["Nombre"].ToString();
                    u.Matricula = r["Matricula"].ToString();
                    u.Curso = r["Curso"].ToString();
                    u.Seccion = r["Seccion"].ToString();
                    u.Rol = r["Rol"].ToString();
                    u.PasswordHash =
                        r["PasswordHash"].ToString();

                    lista.Add(u);
                }

                return lista;
            }
        }

        public void Guardar(Usuario u)
        {
            using (SqlConnection c =
               new ConnectionClass().ObtenerConexion())
            {
                string sql =
                @"INSERT INTO Usuarios
                (
                    Nombre,
                    Matricula,
                    Curso,
                    Seccion,
                    PasswordHash,
                    Rol,
                    PadronId
                )
                VALUES
                (
                    @n,@m,@c,@s,@p,@r,@pa
                )";

                SqlCommand cmd =
                    new SqlCommand(sql, c);

                cmd.Parameters.AddWithValue("@n", u.Nombre);
                cmd.Parameters.AddWithValue("@m", u.Matricula);
                cmd.Parameters.AddWithValue("@c", u.Curso);
                cmd.Parameters.AddWithValue("@s", u.Seccion);
                cmd.Parameters.AddWithValue("@p", u.PasswordHash);
                cmd.Parameters.AddWithValue("@r", u.Rol);
                cmd.Parameters.AddWithValue("@pa", u.PadronId);

                cmd.ExecuteNonQuery();
            }
        }

        public Usuario Login(
            string matricula,
            string passwordHash)
        {
            using (SqlConnection c =
              new ConnectionClass().ObtenerConexion())
            {
                string sql =
                @"SELECT TOP 1 * FROM Usuarios
                WHERE Matricula=@m
                AND PasswordHash=@p";

                SqlCommand cmd =
                    new SqlCommand(sql, c);

                cmd.Parameters.AddWithValue("@m", matricula);
                cmd.Parameters.AddWithValue("@p", passwordHash);

                SqlDataReader r =
                    cmd.ExecuteReader();

                if (r.Read())
                {
                    Usuario u = new Usuario();

                    u.Id = (int)r["Id"];
                    u.Nombre = r["Nombre"].ToString();
                    u.Rol = r["Rol"].ToString();

                    return u;
                }

                return null;
            }
        }

        public void ActualizarYaVoto(int usuarioId, bool yaVoto)
        {
            using (SqlConnection cn =
               new ConnectionClass().ObtenerConexion())
            {
               
                string sql = "UPDATE Usuarios SET CantidadVotos = @Cant WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", usuarioId);
                    cmd.Parameters.AddWithValue("@Cant", yaVoto ? 1 : 0);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int ContarTotalVotantes()
        {
            using (SqlConnection cn = new ConnectionClass().ObtenerConexion())
            {
                string sql = "SELECT COUNT(*) FROM Usuarios WHERE Rol = 'Votante' AND Activo = 1";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public int ContarYaVotaron()
        {
            using (SqlConnection cn = new ConnectionClass().ObtenerConexion())
            {
                string sql = "SELECT COUNT(*) FROM Usuarios WHERE CantidadVotos >= 1 AND Rol = 'Votante'";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public int ContarSinVotar()
        {
            using (SqlConnection cn = new ConnectionClass().ObtenerConexion())
            {
                string sql = "SELECT COUNT(*) FROM Usuarios WHERE CantidadVotos = 0 AND Rol = 'Votante' AND Activo = 1";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }



    }
}

