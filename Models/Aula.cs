using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaizenAPIPrototipo.Models;
using KaizenAPIPrototipo.Enums;

namespace KaizenAPIPrototipo.Models
{
    public class Aula
    {
        public Guid Id { get; set; }
        public bool Ativa { get; set; }
        public DateTime DataAula { get; set; }
        public TimeSpan HorarioInicio { get; set; }
        public TimeSpan HorarioFim { get; set; }
        public TipoAula TipoAula { get; set; }
        public Coordenador Coordenador { get; set; }
        public Mentor Mentor { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
        public ICollection<Presenca> PresencasAlunos { get; set; }
        public Presenca PresencaMentor { get; set; }
    }
}