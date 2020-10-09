using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities.ViewModels
{
    public class SolicitacaoBloqueioViewModel
    {
        public int Id { get; set; }

        public string NumeroCartaoTransporte { get; set; }

        public int CartaoTransporteId { get; set; }

        public int MotivoBloqueioId { get; set; }

        public string MotivoBloqueioDescricao { get; set; }

        public int StatusPedidoId { get; set; }

        public string StatusPedidoDescricao { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataConclusao { get; set; }
    }
}
