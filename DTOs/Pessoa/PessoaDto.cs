using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaizenAPI.DTOs.Pessoa
{
    public record PessoaDto
    {
        public string PrimeiroNome { get; init; }
        public string? SegundoNome { get; init; }
        public string Sobrenome { get; init;}
        public string Cpf { get; init; }
        public string? Rg { get; init; }
    }
}