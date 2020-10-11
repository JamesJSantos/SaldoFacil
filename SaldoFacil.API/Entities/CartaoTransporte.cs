using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities
{
    public class CartaoTransporte : BaseEntity
    {
        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

        public int TipoCartaoId { get; set; }

        public TipoCartao TipoCartao { get; set; }

        [MaxLength(15)]
        public string Numero { get; set; }

        public float Saldo { get; set; }

        public float Tarifa { get; set; }
    }
}
