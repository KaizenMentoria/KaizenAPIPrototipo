using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaizenAPI.DTOs.Endereco
{
    public class UpdateEnderecoDTO
    {
        public record UpdateEnderecoDTO(
            string Cep,
            string Numero,
            string Complemento
        );
    }
}