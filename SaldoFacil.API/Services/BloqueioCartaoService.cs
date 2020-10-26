using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaldoFacil.API.Context;
using SaldoFacil.API.Entities;
using SaldoFacil.API.Entities.ViewModels;

namespace SaldoFacil.API.Services
{
    public class BloqueioCartaoService : Controller
    {
        private readonly MainContext _context;

        public BloqueioCartaoService(MainContext context)
        {
            _context = context;
        }

        public async Task<List<SolicitacaoBloqueioViewModel>> GetAllByUsuario (int usuarioId)
        {
            List<SolicitacaoBloqueioViewModel> solicitacoesBloqueio = new List<SolicitacaoBloqueioViewModel>();

            try
            {
                var lista = await _context.SolicitacaoBloqueio.Where(x => x.CartaoTransporte.UsuarioId == usuarioId).ToListAsync();
                solicitacoesBloqueio = lista.Select(x => new SolicitacaoBloqueioViewModel
                {
                    Id = x.Id,
                    NumeroCartaoTransporte = x.CartaoTransporte.Numero,
                    MotivoBloqueioDescricao = x.MotivoBloqueio.DescricaoMotivo,
                    //DataInicio = x.Eventos.First().DataMudancaStatus,
                    Eventos = x.Eventos.ToList(),                    
                }).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return solicitacoesBloqueio;
        }

        public async Task SolicitaBloqueio(SolicitacaoBloqueioViewModel solicitacao)
        {
            try
            {
                SolicitacaoBloqueio novaSolicitacao = new SolicitacaoBloqueio
                {
                    CartaoTransporteId = solicitacao.CartaoTransporteId,
                    MotivoBloqueioId = solicitacao.MotivoBloqueioId,
                };

                await _context.SolicitacaoBloqueio.AddAsync(novaSolicitacao);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<SolicitacaoBloqueioViewModel>> GetSolicitacaoBloqueio(int cartaoId)
        {
            var solicitacaoBloqueio = new List<SolicitacaoBloqueioViewModel>();

            try
            {
                var lista = await _context.SolicitacaoBloqueio.Include(w => w.MotivoBloqueio).Where(s => s.CartaoTransporteId == cartaoId).ToListAsync();

                solicitacaoBloqueio = lista.Select(x => new SolicitacaoBloqueioViewModel
                {
                    MotivoBloqueioDescricao = x.MotivoBloqueio.DescricaoMotivo,
                    NumeroCartaoTransporte = x.CartaoTransporte.Numero,
                    StatusPedidoDescricao = x.Eventos.Select(e => e.StatusPedido.DescricaoStatus).Last(),
                }).ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return solicitacaoBloqueio;
        }
    }
}
