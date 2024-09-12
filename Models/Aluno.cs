using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using KaizenAPI.DTOs.Aluno;

namespace KaizenAPI.Models
{
    public class Aluno : Pessoa
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; } = true;
        public string DiasAulasContratados { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public ContatoEmergencia ContatoEmergencia { get; set; }
        public Responsavel Responsavel { get; set; }
        public Cobranca Cobranca { get; set; }
        public ICollection<Turma> Turmas { get; set; }
        public ICollection<Aula> Aulas { get; set; }
        public ICollection<DiarioBordo> DiariosBordo { get; set; }
    }
    public Aluno(CreateAlunoDto novoAluno)
        {
            Id = Guid.NewGuid();
            Ativo = novoAluno.Ativo;
            PrimeiroNome = novoAluno.pessoa.PrimeiroNome;
            SegundoNome = novoAluno.pessoa.SegundoNome;
            Sobrenome = novoAluno.pessoa.Sobrenome;
            Cpf = novoAluno.pessoa.Cpf;
            Rg = novoAluno.pessoa.Rg;
            DataNascimento = novoAluno.DataNascimento;
            ContatoEmergencia = novoAluno.ContatoEmergencia;
            Responsavel = novoAluno.Responsavel;
            Cobranca = novoAluno.Cobranca;
            Endereco = novoAluno.Endereco;  // Nova propriedade Endereço
            DiasAulasContratados = novoAluno.DiasAulasContratados;

            // Inicializando as coleções
            Turmas = novoAluno.Turmas ?? new List<Turma>();  // Inicializar com os dados fornecidos ou uma nova lista
            Aulas = novoAluno.Aulas ?? new List<Aula>();     // Inicializar com os dados fornecidos ou uma nova lista
            DiariosBordo = novoAluno.DiariosBordo ?? new List<DiarioBordo>(); // Inicializar com os dados fornecidos ou uma nova lista
        }
    }