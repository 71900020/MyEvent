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
    public class LocalController : ControllerBase
    {
        private readonly ILogger<LocalController> _logger;
        private readonly ILocalService _localService;

        public LocalController(ILogger<LocalController> logger,
            ILocalService localService)
        {
            _logger = logger;
            _localService = localService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarLocal(Local local)
        {
            try
            {
                _localService.CadastrarLocal(local);
                return Ok("Local cadastrado");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditarLocal(Local local)
        {
            try
            {
                var localEditado = _localService.EditarLocal(local);
                return Ok(localEditado);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> RemoverLocal(int id)
        {
            try
            {
                _localService.RemoverLocal(id);
                return Ok("Local excluído");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("evento/{id:int}")]
        public async Task<IActionResult> BuscarLocalPorEvento(int id)
        {
            try
            {
                var local = _localService.BuscarLocalPeloEvento(id);
                return Ok(local);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> BuscarLocalPeloId(int id)
        {
            try
            {
                var local = _localService.BuscarLocalPeloId(id);
                return Ok(local);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
