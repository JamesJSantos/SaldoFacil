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
    public class UsuarioService
    {
        private readonly MainContext _context;

        public UsuarioService(MainContext context)
        {
            _context = context;
        }

        public async Task<UsuarioViewModel> GetById(int id)
        {
            UsuarioViewModel usuario = new UsuarioViewModel();

            try
            {
                var usuarioPesquisado = await _context.Usuario.FirstOrDefaultAsync(u => u.Id == id);
                var enderecoUsuario = await _context.Endereco.Where(e => e.UsuarioId == usuarioPesquisado.Id).FirstOrDefaultAsync();

                usuario = new UsuarioViewModel
                {
                    Nome = usuarioPesquisado.Nome,
                    CPF = usuarioPesquisado.CPF,
                    Email = usuarioPesquisado.Email,
                    Sexo = usuarioPesquisado.Sexo,
                    DataNascimento = usuarioPesquisado.DataNascimento,
                    Telefone = usuarioPesquisado.Telefone,
                    Logradouro = enderecoUsuario.Logradouro,
                    CEP = enderecoUsuario.CEP,
                    Cidade = enderecoUsuario.Cidade,
                    Estado = enderecoUsuario.Estado,
                    Complemento = enderecoUsuario.Complemento,
                    Numero = enderecoUsuario.Numero
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuario;
        }

        public async Task Criar(UsuarioViewModel usuario)
        {
            try
            {              
                Usuario novoUsuario = new Usuario
                {
                    Nome = usuario.Nome,
                    CPF = usuario.CPF,
                    Email = usuario.Email,
                    Sexo = usuario.Sexo,
                    DataNascimento = usuario.DataNascimento,
                    Telefone = usuario.Telefone,                   
                };

                await _context.Usuario.AddAsync(novoUsuario);
                await _context.SaveChangesAsync();

                Endereco endereco = new Endereco
                {
                    Numero = usuario.Numero,
                    CEP = usuario.CEP,
                    Cidade = usuario.Cidade,
                    Complemento = usuario.Complemento,
                    Estado = usuario.Estado,
                    Logradouro = usuario.Logradouro,
                    Status = true,
                    UsuarioId = novoUsuario.Id
                };

                await _context.Endereco.AddAsync(endereco);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Editar(UsuarioViewModel viewModel)
        {
            try
            {
                var usuarioEditado = await _context.Usuario.FirstOrDefaultAsync(u => u.Id == viewModel.Id);
                var enderecoEditado = await _context.Endereco.FirstOrDefaultAsync(e => e.UsuarioId == viewModel.Id);

                usuarioEditado.Nome = viewModel.Nome;
                usuarioEditado.Sexo = viewModel.Sexo;
                usuarioEditado.Telefone = viewModel.Telefone;
                usuarioEditado.CPF = viewModel.CPF;
                usuarioEditado.DataNascimento = viewModel.DataNascimento;
                usuarioEditado.Email = viewModel.Email;

                enderecoEditado.CEP = viewModel.CEP;
                enderecoEditado.Cidade = viewModel.Cidade;
                enderecoEditado.Complemento = viewModel.Complemento;
                enderecoEditado.Estado = viewModel.Estado;
                enderecoEditado.Logradouro = viewModel.Logradouro;
                enderecoEditado.Numero = viewModel.Numero;

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
