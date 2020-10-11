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
    public class MotivoBloqueioService
    {
        private readonly MainContext _context;

        public MotivoBloqueioService(MainContext context)
        {
            _context = context;
        }

        public async Task Criar(MotivoBloqueioViewModel motivo)
        {
            try
            {
                MotivoBloqueio novoMotivoBloqueio = new MotivoBloqueio
                {
                    DescricaoMotivo = motivo.DescricaoMotivo
                };

                await _context.MotivoBloqueio.AddAsync(novoMotivoBloqueio);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<MotivoBloqueioViewModel>> GetAll ()
        {
            var listaMotivosBloqueio = new List<MotivoBloqueioViewModel>();

            try
            {
                var motivos = await _context.MotivoBloqueio.Where(s => s.Status).ToListAsync();

                listaMotivosBloqueio = motivos.Select(m => new MotivoBloqueioViewModel
                {
                    DescricaoMotivo = m.DescricaoMotivo,
                    Id = m.Id,
                    Status = m.Status
                }).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return listaMotivosBloqueio;
        }

        public async Task<MotivoBloqueioViewModel> GetById(int id)
        {
            var motivoBloqueio = new MotivoBloqueioViewModel();

            try
            {
                var motivo = await _context.MotivoBloqueio.FirstOrDefaultAsync(x => x.Id == id);

                motivoBloqueio.Id = motivo.Id;
                motivoBloqueio.DescricaoMotivo = motivo.DescricaoMotivo;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return motivoBloqueio;
        }
    }
}
