using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities
{
    public class SolicitacaoBloqueio
    {
        public int Id { get; set; }

        public int CartaoTransporteId { get; set; }

        public CartaoTransporte CartaoTransporte { get; set; }

        public int MotivoBloqueioId { get; set; }

        public int StatusPedidoId { get; set; }

        public MotivoBloqueio MotivoBloqueio { get; set; }

        public StatusPedido StatusPedido { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public float Tarifa { get; set; }
    }
}
