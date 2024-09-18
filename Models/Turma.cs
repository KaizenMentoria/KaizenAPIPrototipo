using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaizenAPIPrototipo.Models
{
    public class Turma
    {
        public Guid Id { get; set; }
        public bool Ativa { get; set; }
        public string Codigo { get; set; }
        public Mentor Mentor { get; set; }
        public Coordenador Coordenador { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
    }
}