using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities.ViewModels
{
    public class CartaoTransporteViewModel
    {
        public int Id { get; set; }
        public int TipoCartaoId { get; set; }

        public TipoCartao TipoCartao { get; set; }

        public string Numero { get; set; }

        public float Saldo { get; set; }

        public float Tarifa { get; set; }
    }
}
