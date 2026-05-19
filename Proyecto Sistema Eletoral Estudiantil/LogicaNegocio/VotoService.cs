using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class VotoService
    {
        VotoRepository repo =
            new VotoRepository();

        public Estadisticas ObtenerEstadisticas()
        {
            return repo.ObtenerEstadisticas();
        }
    }
}
