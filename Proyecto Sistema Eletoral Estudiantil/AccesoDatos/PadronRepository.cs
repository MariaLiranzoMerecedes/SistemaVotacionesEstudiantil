using System.Collections.Generic;
using System.Data.SqlClient;
using Entidades;

namespace AccesoDatos
{
    public class PadronRepository
    {
        public List<Padron> ObtenerActivos()
        {
            List<Padron> lista = new List<Padron>();

            using (SqlConnection c = new ConnectionClass().ObtenerConexion())
            {
                string sql = "SELECT * FROM Padrones WHERE Activo = 1";
                SqlCommand cmd = new SqlCommand(sql, c);
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    Padron p = new Padron();
                    p.Id = (int)r["Id"];
                    p.Nombre = r["Nombre"].ToString();
                    lista.Add(p);
                }
            }

            return lista;
        }
    }
}