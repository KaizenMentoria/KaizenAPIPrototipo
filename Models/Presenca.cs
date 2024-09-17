using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaizenAPI.Models;

namespace KaizenAPIPrototipo.Models
{
    public class Presenca
    {
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public bool Presente { get; set; }
        public Guid ReferenciaId { get; set; }
        public Aula Aula { get; set; }
    }
}