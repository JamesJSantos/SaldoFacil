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
    public class TipoCartaoController : Controller
    {
        private readonly TipoCartaoService _service;

        public TipoCartaoController(TipoCartaoService service)
        {
            _service = service;
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
        public async Task<IActionResult> Create([FromBody] TipoCartaoViewModel request)
        {
            await _service.Criar(request);
            return Ok();
        }
    }
}
