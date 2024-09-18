using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaizenAPIPrototipo.Models
{
    public class Mentor : Pessoa
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string TipoMentor { get; set; }
        public ContatoEmergencia ContatoEmergencia { get; set; }
        public Coordenador Coordenador { get; set; }
        public List<Formacao> Formacoes { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
        public List<Aula> Aulas { get; set; }
        public List<DiarioBordo> DiariosBordo { get; set; }
        public InformacoesPagamento InformacoesPagamento { get; set; }
    }
}