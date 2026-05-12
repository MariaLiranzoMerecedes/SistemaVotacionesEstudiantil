using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccesoDatos
{
    public class ConnectionClass
    {

        string cadenaConexion = "Server=DESKTOP-GBDI4S5\\SQLEXPRESS;Database=ProyectoSistemaEletoralEstudiantil\r\n;Trusted_Connection=True;";

        public SqlConnection ObtenerConexion()
        { 
        
            SqlConnection connection = new SqlConnection(cadenaConexion);
            connection.Open();
            return connection;
        }
    }
}
