using Microsoft.EntityFrameworkCore;
using SaldoFacil.API.Context;
using SaldoFacil.API.Entities;
using SaldoFacil.API.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Services
{
    public class TipoCartaoService
    {
        private readonly MainContext _context;

        public TipoCartaoService(MainContext context)
        {
            _context = context;
        }

        public async Task Criar (TipoCartaoViewModel tipoCartao)
        {
            try
            {
                TipoCartao novoTipoCartao = new TipoCartao
                {
                    NomeTipo = tipoCartao.NomeTipo,
                    Status = true
                };

                await _context.TipoCartao.AddAsync(novoTipoCartao);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<TipoCartaoViewModel>> GetAll()
        {
            var listaTiposCartao = new List<TipoCartaoViewModel>();

            try
            {
                var tiposCartao = await _context.TipoCartao.Where(s => s.Status).ToListAsync();

                listaTiposCartao = tiposCartao.Select(m => new TipoCartaoViewModel
                {
                    NomeTipo = m.NomeTipo,
                    Id = m.Id,
                    Status = m.Status
                }).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return listaTiposCartao;
        }
    }
}
