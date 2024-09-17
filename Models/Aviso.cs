using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaizenAPIPrototipo.Models
{
    public class Aviso
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public Guid IdCriador { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}