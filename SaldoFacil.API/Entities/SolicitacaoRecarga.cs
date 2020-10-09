using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities
{
    public class SolicitacaoRecarga
    {
        public int Id { get; set; }

        public int CartaoId { get; set; }

        public CartaoTransporte CartaoTransporte { get; set; }

        public int StatusPedidoId { get; set; }

        public StatusPedido StatusPedido { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFinal { get; set; }

        public float Valor { get; set; }
    }
}
