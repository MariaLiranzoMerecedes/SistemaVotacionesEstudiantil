using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entidades;
namespace AccesoDatos
{
    public class PartidoRepository
    {
        public List<Partido> ObtenerTodos()
        {
            List<Partido> lista = new List<Partido>();

            using (SqlConnection c = new ConnectionClass().ObtenerConexion())
            {
                string sql = @"SELECT * FROM Partidos WHERE Activo = 1";   // ← solo activos

                SqlCommand cmd = new SqlCommand(sql, c);
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    Partido p = new Partido();
                    p.Id = (int)r["Id"];
                    p.Nombre = r["Nombre"].ToString();
                    // ↓↓↓ MANEJO DE NULL ↓↓↓
                    p.Lema = r["Lema"] == DBNull.Value ? "" : r["Lema"].ToString();
                    p.ColorHex = r["ColorHex"] == DBNull.Value ? "#1a6fc4" : r["ColorHex"].ToString();
                    p.LogoPath = r["LogoPath"] == DBNull.Value ? "" : r["LogoPath"].ToString();
                    p.Activo = (bool)r["Activo"];
                    // ↑↑↑ MANEJO DE NULL ↑↑↑
                    lista.Add(p);
                }
            }

            return lista;
        }

        public void Guardar(Partido p)
        {
            using (SqlConnection c =
                 new ConnectionClass().ObtenerConexion())
            {
                string sql =
                @"INSERT INTO Partidos
                (
                    Nombre,
                    Lema,
                    LogoPath,
                    ColorHex
                )
                OUTPUT INSERTED.Id
                VALUES
                (
                    @n,@l,@logo,@color
                )";

                SqlCommand cmd =
                    new SqlCommand(sql, c);

                cmd.Parameters.AddWithValue("@n", p.Nombre);
                cmd.Parameters.AddWithValue("@l", p.Lema);
                cmd.Parameters.AddWithValue("@logo", p.LogoPath);
                cmd.Parameters.AddWithValue("@color", p.ColorHex);

                int partidoId =
                    (int)cmd.ExecuteScalar();

                foreach (Candidato can in p.Candidatos)
                {
                    string sqlCan =
                    @"INSERT INTO Candidatos
                    (
                        Nombre,
                        PartidoId,
                        Puesto,
                        Orden
                    )
                    VALUES
                    (
                        @n,@p,@pu,@o
                    )";

                    SqlCommand cmdCan =
                        new SqlCommand(sqlCan, c);

                    cmdCan.Parameters.AddWithValue("@n", can.Nombre);
                    cmdCan.Parameters.AddWithValue("@p", partidoId);
                    cmdCan.Parameters.AddWithValue("@pu", can.Puesto);
                    cmdCan.Parameters.AddWithValue("@o", can.Orden);

                    cmdCan.ExecuteNonQuery();
                }
            }
        }
    }
}
