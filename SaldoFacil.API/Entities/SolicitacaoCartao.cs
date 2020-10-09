using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities
{
    public class SolicitacaoCartao
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

        public int CartaoTransporteId { get; set; }

        public CartaoTransporte CartaoTransporte { get; set; }

        public int MotivoBloqueioId { get; set; }

        public MotivoBloqueio MotivoBloqueio { get; set; }

        public int StatusPedidoId { get; set; }

        public StatusPedido StatusPedido { get; set; }
    }
}
