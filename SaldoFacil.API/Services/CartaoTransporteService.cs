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
    public class CartaoTransporteService
    {
        private readonly MainContext _context;

        public CartaoTransporteService(MainContext context)
        {
            _context = context;
        }

        public async Task<List<CartaoTransporteViewModel>> GetByUsuarioId(int usuarioId)
        {
            var list = new List<CartaoTransporteViewModel>();

            try
            {
                var cartoes = await _context.CartaoTransporte.Where(c => c.Usuario.Id == usuarioId && c.Status).ToListAsync();

                list = cartoes.Select(x => new CartaoTransporteViewModel
                {
                    Id = x.Id,
                    UsuarioId = x.UsuarioId,
                    Numero = x.Numero,
                    Saldo = x.Saldo,
                    Tarifa = x.Tarifa,
                    TipoCartaoId = x.TipoCartaoId
                }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public async Task Adicionar(CartaoTransporteViewModel cartao)
        {
            try
            {
                CartaoTransporte novoCartao = new CartaoTransporte
                {
                    UsuarioId = cartao.UsuarioId,
                    Numero = cartao.Numero,
                    Saldo = cartao.Saldo,
                    Tarifa = cartao.Tarifa,
                    TipoCartaoId = cartao.TipoCartaoId,
                    Status = true,
                };

                if (_context.CartaoTransporte.Any(x => x.Numero == cartao.Numero))
                {
                    throw new Exception("Cartão Transporte já cadastrado.");
                }

                await _context.CartaoTransporte.AddAsync(novoCartao);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AtualizaSaldo(CartaoTransporteViewModel cartao)
        {
            try
            {
                var cartaoNovoSaldo = await _context.CartaoTransporte.FirstOrDefaultAsync(c => c.Id == cartao.Id);
                cartaoNovoSaldo.Saldo = cartao.Saldo;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }       
    }
}
