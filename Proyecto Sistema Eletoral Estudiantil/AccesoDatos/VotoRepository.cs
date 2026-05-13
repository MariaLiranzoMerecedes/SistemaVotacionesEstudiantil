using System.Collections.Generic;
using System.Data.SqlClient;
using Entidades;
using AccesoDatos;


namespace AccesoDatos
{
    public class VotoRepository
    {
        public Estadisticas ObtenerEstadisticas()
        {
            Estadisticas e = new Estadisticas();

            using (SqlConnection c = new ConnectionClass().ObtenerConexion())
            {
                // ===== TOTAL DE VOTANTES (solo rol Votante y activos) =====
                string sql1 = @"SELECT COUNT(*) FROM Usuarios 
                        WHERE Rol = 'Votante' AND Activo = 1";
                SqlCommand cmd1 = new SqlCommand(sql1, c);
                e.TotalPadron = (int)cmd1.ExecuteScalar();

                // ===== TOTAL DE VOTOS =====
                string sql2 = @"SELECT COUNT(*) FROM Votos";
                SqlCommand cmd2 = new SqlCommand(sql2, c);
                e.TotalVotos = (int)cmd2.ExecuteScalar();

                // ===== VOTOS NULOS =====
                string sql3 = @"SELECT COUNT(*) FROM Votos WHERE EsNulo = 1";
                SqlCommand cmd3 = new SqlCommand(sql3, c);
                e.VotosNulos = (int)cmd3.ExecuteScalar();

                // ===== SIN VOTAR =====
                e.SinVotar = e.TotalPadron - e.TotalVotos;
                if (e.SinVotar < 0) e.SinVotar = 0;

                // ===== PARTICIPACIÓN =====
                if (e.TotalPadron > 0)
                {
                    e.Participacion = (decimal)e.TotalVotos / e.TotalPadron * 100;
                }

                // ===== RESULTADOS POR PLANCHA (solo votos válidos) =====
                int votosValidos = e.TotalVotos - e.VotosNulos;

                string sql4 = @"SELECT P.Nombre, 
                               COUNT(V.Id) AS Total
                        FROM Partidos P
                        LEFT JOIN Votos V ON P.Id = V.PartidoId AND V.EsNulo = 0
                        WHERE P.Activo = 1
                        GROUP BY P.Nombre
                        ORDER BY Total DESC";

                SqlCommand cmd4 = new SqlCommand(sql4, c);
                SqlDataReader r = cmd4.ExecuteReader();

                while (r.Read())
                {
                    ResultadoPartido rp = new ResultadoPartido();
                    rp.Nombre = r["Nombre"].ToString();
                    rp.TotalVotos = (int)r["Total"];

                    // ===== PORCENTAJE POR PLANCHA =====
                    if (votosValidos > 0)
                        rp.Porcentaje = (decimal)rp.TotalVotos / votosValidos * 100;
                    else
                        rp.Porcentaje = 0;

                    e.Resultados.Add(rp);
                }
            }

            return e;
        }

        public void RegistrarVoto(int usuarioId, int? partidoId, bool esNulo, int padronId)
        {
            using (SqlConnection c = new ConnectionClass().ObtenerConexion())
            {
                // Token único para el voto secreto
                string token = System.Guid.NewGuid().ToString();

                // 1. Insertar el voto anónimo
                string sql1 = @"INSERT INTO Votos (TokenVoto, PartidoId, EsNulo, PadronId) 
                        VALUES (@token, @partidoId, @esNulo, @padronId)";
                SqlCommand cmd1 = new SqlCommand(sql1, c);
                cmd1.Parameters.AddWithValue("@token", token);
                cmd1.Parameters.AddWithValue("@partidoId",
                    partidoId.HasValue ? (object)partidoId.Value : System.DBNull.Value);
                cmd1.Parameters.AddWithValue("@esNulo", esNulo);
                cmd1.Parameters.AddWithValue("@padronId", padronId);
                cmd1.ExecuteNonQuery();

                // 2. Registrar que el usuario votó (separado para mantener voto secreto)
                string sql2 = @"INSERT INTO RegistroVotantes (UsuarioId, TokenVoto) 
                        VALUES (@usuarioId, @token)";
                SqlCommand cmd2 = new SqlCommand(sql2, c);
                cmd2.Parameters.AddWithValue("@usuarioId", usuarioId);
                cmd2.Parameters.AddWithValue("@token", token);
                cmd2.ExecuteNonQuery();

                // 3. Marcar al usuario como que ya votó
                string sql3 = "UPDATE Usuarios SET CantidadVotos = 1 WHERE Id = @id";
                SqlCommand cmd3 = new SqlCommand(sql3, c);
                cmd3.Parameters.AddWithValue("@id", usuarioId);
                cmd3.ExecuteNonQuery();
            }
        }


    }
    
}
