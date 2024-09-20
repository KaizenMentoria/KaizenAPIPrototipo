using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaizenAPIPrototipo.Enums;

namespace KaizenAPIPrototipo.Models
{
    public class Cobranca
    {
        public Guid Id { get; set; }
        public bool Pago { get; set; }
        public TipoPlano TipoPlano { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public Endereco EnderecoDeCobranca { get; set; }
        public FormasPagamento FormaDePagamento { get; set; }
    }
}