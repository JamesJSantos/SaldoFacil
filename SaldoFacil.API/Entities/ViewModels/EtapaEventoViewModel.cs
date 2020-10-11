using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities.ViewModels
{
    public class EtapaEventoViewModel
    {
        public int Id { get; set; }

        public int StatusPedidoId { get; set; }

        public StatusPedidoViewModel StatusPedido { get; set; }

        public DateTime DataMudancaStatus { get; set; }
    }
}
