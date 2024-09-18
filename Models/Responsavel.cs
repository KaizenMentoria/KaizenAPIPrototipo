using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaizenAPIPrototipo.Models
{
    public class Responsavel : Pessoa
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public Guid ResponsavelPor { get; set; }
        public string NomePessoaResponsavel { get; set; }
    }
}