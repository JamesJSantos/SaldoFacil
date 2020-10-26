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

        public MotivoBloqueio MotivoBloqueio { get; set; }

        public ICollection<EtapaEvento> Eventos { get; set; }
    }
}
