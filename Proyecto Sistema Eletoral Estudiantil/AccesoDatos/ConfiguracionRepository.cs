using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entidades;

namespace AccesoDatos
{
    public class ConfiguracionRepository
    {
        // ==================================================
        // OBTENER CONFIGURACIÓN ACTIVA
        // ==================================================
        public Configuracion ObtenerActiva()
        {
            Configuracion cfg = null;

            using (SqlConnection c = new ConnectionClass().ObtenerConexion())
            {
                string sql = @"SELECT TOP 1 * FROM Configuracion 
                               WHERE Activa = 1 
                               ORDER BY FechaCreacion DESC";

                SqlCommand cmd = new SqlCommand(sql, c);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {
                    cfg = new Configuracion();
                    cfg.Id = (int)r["Id"];
                    cfg.TituloEleccion = r["TituloEleccion"].ToString();
                    cfg.FechaInicio = (DateTime)r["FechaInicio"];
                    cfg.FechaFin = (DateTime)r["FechaFin"];
                    cfg.PadronActivoId = (int)r["PadronActivoId"];
                    cfg.Activa = (bool)r["Activa"];
                    cfg.FechaCreacion = (DateTime)r["FechaCreacion"];
                }
            }

            return cfg;
        }

        // ==================================================
        // GUARDAR NUEVA CONFIGURACIÓN (la activa)
        // ==================================================
        public void Guardar(Configuracion cfg)
        {
            using (SqlConnection c = new ConnectionClass().ObtenerConexion())
            {
                // 1. Desactivar las anteriores
                string sqlOff = "UPDATE Configuracion SET Activa = 0";
                SqlCommand cmdOff = new SqlCommand(sqlOff, c);
                cmdOff.ExecuteNonQuery();

                // 2. Insertar la nueva como activa
                string sql = @"INSERT INTO Configuracion 
                               (TituloEleccion, FechaInicio, FechaFin, PadronActivoId, Activa)
                               VALUES (@titulo, @inicio, @fin, @padron, 1)";

                SqlCommand cmd = new SqlCommand(sql, c);
                cmd.Parameters.AddWithValue("@titulo", cfg.TituloEleccion);
                cmd.Parameters.AddWithValue("@inicio", cfg.FechaInicio);
                cmd.Parameters.AddWithValue("@fin", cfg.FechaFin);
                cmd.Parameters.AddWithValue("@padron", cfg.PadronActivoId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}