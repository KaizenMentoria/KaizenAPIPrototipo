using System;

namespace KaizenAPI.Models
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        // Parameterless constructor for EF Core
        public Aluno()
        {
        }

        // Constructor with parameters matching mapped properties
        public Aluno(string nome, string email, DateTime dataNascimento, string telefone, Endereco endereco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}