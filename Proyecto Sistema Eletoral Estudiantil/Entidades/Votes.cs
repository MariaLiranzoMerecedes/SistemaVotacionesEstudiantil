using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Votes
    {
    int Id { get; set; }
    string TokenVoto { get; set; }
    int PartidoId { get; set; }
    string EsNulo { get; set; }
    int PadronId { get; set; }
    DateTime FechaHora { get; set; }
    }
}
