using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaldoFacil.API.Services;

namespace SaldoFacil.API.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class CartaoTransporteController : Controller
    {
        private readonly CartaoTransporteService _service;

        public CartaoTransporteController(CartaoTransporteService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("get-by-id/{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _service.GetById(id);

            if (response == null)
                return NotFound("Nenhum fornecedor encontrado com o código informado.");

            return Ok(response);
        }

        //[HttpPost]
        //[Route("create")]
        //public async Task<IActionResult> Create([FromBody] UsuarioViewModel request)
        //{
        //    await _service.Criar(request);
        //    return Ok();
        //}

        //[HttpPut]
        //[Route("edit")]
        //public async Task<IActionResult> Edit([FromBody] UsuarioViewModel request)
        //{
        //    await _service.Editar(request);
        //    return Ok();
        //}
    }
}
