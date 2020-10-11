using SaldoFacil.API.Context;
using SaldoFacil.API.Entities;
using SaldoFacil.API.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaldoFacil.API.Services
{
    public class StatusPedidoService
    {
        private readonly MainContext _context;

        public StatusPedidoService(MainContext context)
        {
            _context = context;
        }

        public async Task Criar(StatusPedidoViewModel statusPedido)
        {

            try
            {
                StatusPedido novoStatusPedido = new StatusPedido
                {
                    DescricaoStatus = statusPedido.DescricaoStatus,
                    Status = true
                };

                await _context.StatusPedido.AddAsync(novoStatusPedido);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
