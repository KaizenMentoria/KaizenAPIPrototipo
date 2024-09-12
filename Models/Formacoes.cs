using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaizenAPI.Enums;

namespace KaizenAPI.Models
{
    public class Formacoes
    {
        public Guid Id { get; set; }
        public TipoFormacao TipoFormacao { get; set; }
        public string? Descricao { get; set; }
    }
}