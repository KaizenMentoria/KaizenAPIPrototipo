using System;
using Microsoft.EntityFrameworkCore;

namespace KaizenAPIPrototipo.Models
{
    [Owned]
    public class Endereco
    {
        public Guid Id { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
    }
}