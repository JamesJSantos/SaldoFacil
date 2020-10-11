using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities
{
    public class EtapaEvento : BaseEntity
    {
        public int StatusPedidoId { get; set; }

        public StatusPedido StatusPedido { get; set; }

        public DateTime DataMudancaStatus { get; set; }
    }
}
