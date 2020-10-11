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
    public class MotivoBloqueioController : Controller
    {
        private readonly MotivoBloqueioService _service;

        public MotivoBloqueioController(MotivoBloqueioService service)
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

        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _service.GetAll();

            if (response == null)
                return NotFound("Nenhum fornecedor encontrado com o código informado.");

            return Ok(response);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] MotivoBloqueioViewModel request)
        {
            await _service.Criar(request);
            return Ok();
        }
    }
}
