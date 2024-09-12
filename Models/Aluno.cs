using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using KaizenAPI.DTOs.Aluno;
using KaizenAPI.DTOs.Endereco;
using KaizenAPI.DTOs.Pessoa;
using KaizenAPI.DTOs.ContatoEmergencia;

namespace KaizenAPI.Models
{
    public class Aluno : Pessoa
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public string DiasAulasContratados { get; set; }
        public DateTime DataNascimento { get; set; }
        public new Endereco Endereco { get; set; }
        public ContatoEmergencia ContatoEmergencia { get; set; }
        public Responsavel Responsavel { get; set; }
        public Cobranca Cobranca { get; set; }
        public ICollection<Turma> Turmas { get; set; }
        public ICollection<Aula> Aulas { get; set; }
        public ICollection<DiarioBordo> DiariosBordo { get; set; }

        public Aluno(CreateAlunoDto novoAluno)
        {
            Id = Guid.NewGuid();
            Ativo = novoAluno.Ativo;

            // Acessando as propriedades do objeto Pessoa no DTO
            PrimeiroNome = novoAluno.Pessoa.PrimeiroNome;
            SegundoNome = novoAluno.Pessoa.SegundoNome;
            Sobrenome = novoAluno.Pessoa.Sobrenome;
            Cpf = novoAluno.Pessoa.Cpf;
            Rg = novoAluno.Pessoa.Rg;

            // Definindo as propriedades restantes
            DataNascimento = novoAluno.DataNascimento;
            ContatoEmergencia = novoAluno.ContatoEmergencia;
            DiasAulasContratados = novoAluno.DiasAulasContratados;

            // Aqui você pode criar a instância de Endereco a partir de um UpdateEnderecoDto, se necessário
            Endereco = new Endereco
            {
                Cep = novoAluno.Endereco.Cep,
                Numero = novoAluno.Endereco.Numero,
                Complemento = novoAluno.Endereco.Complemento
            };

            // Inicializando as coleções
            Turmas = new List<Turma>();
            Aulas = new List<Aula>();
            DiariosBordo = new List<DiarioBordo>();
        }
    }
}