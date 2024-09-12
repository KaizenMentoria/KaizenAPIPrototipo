using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaizenAPI.DTOs.Endereco
{

    public record UpdateEnderecoDto(
        string Cep,
        string Numero,
        string Complemento
    );

}