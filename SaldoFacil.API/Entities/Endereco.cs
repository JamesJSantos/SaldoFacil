using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities
{
    public class Endereco : BaseEntity
    {
        
        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

        [MaxLength(518)]
        public string Logradouro { get; set; }

        [MaxLength(10)]
        public string Numero { get; set; }

        [MaxLength(30)]
        public string Complemento { get; set; }

        [MaxLength(9)]
        public string CEP { get; set; }

        [MaxLength(30)]
        public string Cidade { get; set; }

        [MaxLength(30)]
        public string Estado { get; set; }
    }
}
