using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaldoFacil.API.Entities.ViewModels;
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
        [Route("get-by-user-id/{userId}")]
        public async Task<IActionResult> GetById([FromRoute] int userId)
        {
            var response = await _service.GetByUsuarioId(userId);

            if (response == null)
                return NotFound("Nenhum fornecedor encontrado com o código informado.");

            return Ok(response);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] CartaoTransporteViewModel request)
        {
            await _service.Adicionar(request);
            return Ok();
        }
    }
}
