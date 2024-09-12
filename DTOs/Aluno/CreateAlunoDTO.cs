using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaizenAPI.DTOs.Pessoa;
using KaizenAPI.DTOs.ContatoEmergencia;

namespace KaizenAPI.DTOs.Aluno
{

    public record CreateAlunoDto
    (
        PessoaDto Pessoa,
        ContatoEmergenciaDto ContatoEmergencia,
        string DiasAulasContratados,
        DateTime DataNascimento,
        bool Ativo = true
    );
}