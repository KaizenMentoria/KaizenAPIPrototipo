using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaizenAPI.Models;

namespace KaizenAPIPrototipo.Models
{
    public class Coordenador : Pessoa
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataNascimento { get; set; }
        public ICollection<Aula> Aulas { get; set; }
        public ICollection<Mentor> Mentores { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
        public List<Formacao> Formacoes { get; set; }
        public List<Aviso> Avisos { get; set; }
    }
}