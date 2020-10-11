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
    public class StatusPedidoController : Controller
    {
        private readonly StatusPedidoService _service;

        public StatusPedidoController(StatusPedidoService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] StatusPedidoViewModel request)
        {
            await _service.Criar(request);
            return Ok();
        }
    }
}
