using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaizenAPIPrototipo.Enums;

namespace KaizenAPIPrototipo.Models
{
    public class Formacao
    {
        public Guid Id { get; set; }
        public TipoFormacao TipoFormacao { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }
}