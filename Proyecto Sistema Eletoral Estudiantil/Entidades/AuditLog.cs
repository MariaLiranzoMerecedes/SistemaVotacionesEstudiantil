using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AuditLog
    {
        int Id { get; set; }
        int UsuarioId { get; set; }
        string Accion { get; set; }
        string Detalle { get; set; }
        string IPMaquina { get; set; }
        DateTime FechaHora { get; set; }
    }
}
