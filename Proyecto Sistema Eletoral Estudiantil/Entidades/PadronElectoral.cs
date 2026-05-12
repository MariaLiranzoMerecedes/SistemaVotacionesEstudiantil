using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PadronElectoral
    {
        int id {  get; set; }
        string nombre { get; set; }
        string Descripcion { get; set; }
        string Activo { get; set; }
        DateTime FechaCreacion { get; set; }

    }
}
