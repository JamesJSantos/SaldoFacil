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
    public class BloqueioCartaoController : Controller
    {
        private readonly BloqueioCartaoService _service;

        public BloqueioCartaoController(BloqueioCartaoService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("get-by-id/{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _service.GetSolicitacaoBloqueio(id);

            if (response == null)
                return NotFound("Erro.");

            return Ok(response);
        }

        [HttpGet]
        [Route("get-by-user-id/{userId}")]
        public async Task<IActionResult> GetAllByUserId([FromRoute] int userId)
        {
            var response = await _service.GetAllByUsuario(userId);

            if (response == null)
                return NotFound("Erro.");

            return Ok(response);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] SolicitacaoBloqueioViewModel request)
        {
            await _service.SolicitaBloqueio(request);
            return Ok();
        }
    }
}
