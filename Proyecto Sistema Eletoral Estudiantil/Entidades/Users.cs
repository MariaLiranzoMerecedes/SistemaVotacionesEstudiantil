using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Entidades
{
    public class Users
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Matricula { get; set; }
        string Curso { get; set; }
        string Seccion { get; set; }
        string PasswordHash { get; set; }
        int PadronId { get; set; }
        int CantidadVotos { get; set; }
        string Activo { get; set; }
        DateTime FechaRegistro { get; set; }



    }
}
