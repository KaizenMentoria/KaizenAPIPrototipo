using System;
using Microsoft.EntityFrameworkCore;

namespace KaizenAPI.DTOs.Aluno;
public record CreateAlunoDTO
(
    string Nome,
    string Email,
    string Cpf,
    string DataNascimento,
    string Telefone,
    string Cep,
    string Complemento,
    string Numero
);
