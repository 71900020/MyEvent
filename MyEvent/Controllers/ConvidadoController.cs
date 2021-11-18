using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyEvent.Models;
using MyEvent.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConvidadoController : ControllerBase
    {
        private readonly ILogger<ConvidadoController> _logger;
        private readonly IConvidadoService _convidadoService;

        public ConvidadoController(ILogger<ConvidadoController> logger,
            IConvidadoService convidadoService)
        {
            _logger = logger;
            _convidadoService = convidadoService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarConvidado(Convidado convidado)
        {
            try
            {
                _convidadoService.CadastrarConvidado(convidado);
                return Ok("Convidado cadastrado");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditarConvidado(Convidado convidado)
        {
            try
            {
                var convidadoEditado = _convidadoService.EditarConvidado(convidado);
                return Ok(convidadoEditado);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> RemoverConvidado(int id)
        {
            try
            {
                _convidadoService.RemoverConvidado(id);
                return Ok("Convidado excluído");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("evento/{id:int}")]
        public async Task<IActionResult> BuscarConvidadoPorEvento(int id)
        {
            try
            {
                var convidado = _convidadoService.BuscarConvidadosPorEvento(id);
                return Ok(convidado);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> BuscarConvidadoPeloId(int id)
        {
            try
            {
                var convidado = _convidadoService.BuscarConvidadoPeloId(id);
                return Ok(convidado);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
