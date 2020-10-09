using Microsoft.EntityFrameworkCore;
using SaldoFacil.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Context
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
        }

        public MainContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;AttachDbFilename=[DataDirectory]\\Macondi.mdf;Trusted_Connection=True;");
            optionsBuilder.UseMySql("server=localhost;userid=root;password=echo_$PATH;database=SaldoFacil");
        }

        public DbSet<CartaoTransporte> CartaoTransporte { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<LoginUsuario> LoginUsuario { get; set; }

        public DbSet<MotivoBloqueio> MotivoBloqueio { get; set; }

        public DbSet<SolicitacaoBloqueio> SolicitacaoBloqueio { get; set; }

        public DbSet<SolicitacaoCartao> SolicitacaoCartao { get; set; }

        public DbSet<SolicitacaoRecarga> SolicitacaoRecarga { get; set; }

        public DbSet<StatusPedido> StatusPedido { get; set; }

        public DbSet<TipoCartao> TipoCartao { get; set; }
    }
}
