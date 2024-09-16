using System;
using System.Collections.Generic;

namespace KaizenAPI.Models
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public ICollection<Endereco>? Enderecos { get; set; }

        public Aluno()
        {
            Enderecos = new List<Endereco>();
        }

        // Constructor with parameters matching mapped properties
        public Aluno(string nome, string email, DateTime dataNascimento, string telefone, ICollection<Endereco> enderecos)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Enderecos = enderecos;
        }
    }
}