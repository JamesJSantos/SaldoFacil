//using SaldoFacil.API.Context;
//using SaldoFacil.API.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace SaldoFacil.API.Services
//{
//    public class SeedingService
//    {
      
//        private readonly MainContext _context;

//        public SeedingService(MainContext context)
//        {
//            _context = context;
//        }

//        public static void Seed()
//        {

//            if (_context.Usuario.Any())
//            {
//                return;
//            }

//            var usuario = new Usuario
//            {
//                Nome = "Vinicius Gimenes",
//                CPF = "930.648.301-55",
//                Email = "vinicius.gimenes@gmail.com",
//                DataNascimento = DateTime.Now,
//                Sexo = "Masculino",
//                Telefone = "13 98199-9999",
//                Status = true

//            };


//            if (_context.Endereco.Any())
//            {
//                return;
//            }

//            var endereco = new Endereco
//            {
//                Logradouro = "Rua 02",
//                Numero = "77",
//                Complemento = "Altos",
//                CEP = "11077-196",
//                Cidade = "Santos",
//                Estado = "São Paulo",
//                Status = true

//            };

//        _context.Usuario.Add(usuario);
//            endereco.UsuarioId = usuario.Id;
//            _context.SaveChanges();
//        }

//}
//}
