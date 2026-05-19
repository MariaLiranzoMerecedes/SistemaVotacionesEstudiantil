using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Matricula { get; set; }

        public string Curso { get; set; }

        public string Seccion { get; set; }

        public string PasswordHash { get; set; }

        public string Rol { get; set; }

        public int PadronId { get; set; }

        public int CantidadVotos { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaRegistro { get; set; }

        public bool YaVoto => CantidadVotos >= 1;

        public bool EsVotante()
        {
            return Rol == "Votante";
        }
    }

    // =====================================================

    public class Partido
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Lema { get; set; }

        public string LogoPath { get; set; }

        public string ColorHex { get; set; }

        public bool Activo { get; set; }

        public List<Candidato> Candidatos { get; set; }
            = new List<Candidato>();
    }

    // =====================================================

    public class Candidato
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int PartidoId { get; set; }

        public string Puesto { get; set; }

        public int Orden { get; set; }
    }

    // =====================================================

    public class Estadisticas
    {
        public int TotalPadron { get; set; }

        public int TotalVotos { get; set; }

        public int VotosNulos { get; set; }

        public int SinVotar { get; set; }

        public decimal Participacion { get; set; }

        public List<ResultadoPartido> Resultados { get; set; }
            = new List<ResultadoPartido>();
    }

    // =====================================================

    public class ResultadoPartido
    {
        public string Nombre { get; set; }

        public int TotalVotos { get; set; }

        public decimal Porcentaje { get; set; }
    }

    public class Configuracion
    {
        public int Id { get; set; }
        public string TituloEleccion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int PadronActivoId { get; set; }
        public bool Activa { get; set; }
        public DateTime FechaCreacion { get; set; }
    }

    // =====================================================

    public class Padron
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }

}
