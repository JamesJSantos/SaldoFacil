using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities.ViewModels
{
    public class TipoCartaoViewModel
    {
        public int Id { get; set; }

        public string NomeTipo { get; set; }

        public bool Status { get; set; }
    }
}
