using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities.ViewModels
{
    public class MotivoBloqueioViewModel
    {
        public int Id { get; set; }

        public string DescricaoMotivo { get; set; }

        public bool Status { get; set; }
    }
}
