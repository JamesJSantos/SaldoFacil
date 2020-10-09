using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Entities
{
    public class LoginUsuario : BaseEntity
    {
        [ForeignKey("UsuarioCPF")]
        public string UsuarioCPF { get; set; }

        [ForeignKey("UsuarioEmail")]
        public string UsuarioEmail { get; set; }

        public Usuario Usuario { get; set; }

        public string Senha { get; set; }

        public string SenhaAntiga { get; set; }

        //public DateTime UltimoLogin { get; set; }
    }
}
