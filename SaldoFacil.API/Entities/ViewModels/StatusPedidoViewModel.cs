using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities.ViewModels
{
    public class StatusPedidoViewModel
    {
        public int Id { get; set; }

        public string DescricaoStatus { get; set; }

        public bool Status { get; set; }
    }
}
