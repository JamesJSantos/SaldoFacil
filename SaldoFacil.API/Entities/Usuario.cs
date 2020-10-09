using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities
{
    public class Usuario : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(14)]
        public string CPF { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Sexo { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        public ICollection<CartaoTransporte> CartõesTransporte { get; set; }

        //public Endereco Endereco { get; set; }

        //public int EnderecoId { get; set; }

        [Required]
        [MaxLength(14)]
        public string Telefone { get; set; }
    }
}
