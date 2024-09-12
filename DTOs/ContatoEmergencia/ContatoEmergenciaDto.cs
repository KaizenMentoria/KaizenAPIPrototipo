using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaizenAPI.DTOs.ContatoEmergencia
{
    public record ContatoEmergenciaDto
    {
        public string Nome { get; init; }
        public string Telefone { get; init; }
    }
}