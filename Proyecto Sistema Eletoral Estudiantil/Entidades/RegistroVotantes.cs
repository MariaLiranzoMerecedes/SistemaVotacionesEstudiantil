using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RegistroVotantes
    {
    int Id { get; set; }
    int UsuarioId { get; set; }
    string TokenVoto { get; set; }
    DateTime FechaHora { get; set; }
    }
}
