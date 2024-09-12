using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaizenAPI.DTOs.ContatoEmergencia;

namespace KaizenAPI.Models
{
    public class ContatoEmergencia :Pessoa
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public Guid IdPessoa { get; set; }
        public string? NomePessoa { get; set; }
    
        public ContatoEmergencia(ContatoEmergenciaDto dto)
        {
            NomePessoa = dto.Nome;

            ContatoEmergencia.Telefone = dto.Telefone;
        }
    }
}