using System;
using System.Collections.Generic;
using KaizenAPIPrototipo.Models;

namespace KaizenAPIPrototipo.Models
{
    public class Aluno : Pessoa
    {
        public Guid Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public ICollection<Endereco>? Enderecos { get; set; }

        public Aluno()
        {
            Enderecos = new List<Endereco>();
        }

        // Constructor with parameters matching mapped properties
        public Aluno(string primeiroNome, string sobrenome, string cpf, string rg, string telefone, string email, DateTime dataNascimento)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
            Enderecos = new List<Endereco>();
        }
    }
}