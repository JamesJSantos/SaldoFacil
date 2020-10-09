using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities
{
    public class TipoCartao : BaseEntity
    {
        [MaxLength(40)]
        public string NomeTipo { get; set; }
    }
}
