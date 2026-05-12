using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partidos
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Lema { get; set; }
        string LogoPath { get; set; }
        string ColorHex { get; set; }
        string Activo { get; set; }
        DateTime FechaCreacion { get; set; }

    }
}
