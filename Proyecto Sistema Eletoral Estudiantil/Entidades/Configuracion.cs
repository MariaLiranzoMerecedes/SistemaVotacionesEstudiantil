using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Configuracion
    {
     int Id { get; set; }
    string TituloEleccion { get; set; }
    DateTime FechaInicio { get; set; }
    DateTime FechaFin { get; set; }
    int PadronActivoId { get; set; }
    string Activa { get; set; }
    DateTime FechaCreacion { get; set; }
    }
}
