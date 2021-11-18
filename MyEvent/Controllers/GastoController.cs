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
    public class GastoController : ControllerBase
    {
        private readonly ILogger<GastoController> _logger;
        private readonly IGastoService _gastoService;

        public GastoController(ILogger<GastoController> logger,
            IGastoService gastoService)
        {
            _logger = logger;
            _gastoService = gastoService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarGasto(Gasto gasto)
        {
            try
            {
                _gastoService.CadastrarGasto(gasto);
                return Ok("Gasto cadastrado");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("evento/{id:int}")]
        public async Task<IActionResult> BuscarGastosPorEvento(int id)
        {
            try
            {
                var gasto = _gastoService.BuscarGastosPorEvento(id);
                return Ok(gasto);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("evento/{id:int}/gastos-totais")]
        public async Task<IActionResult> BuscarGastosTotaisPorEvento(int id)
        {
            try
            {
                var gasto = _gastoService.GastosTotaisPorEvento(id);
                return Ok(gasto);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> BuscarGastoPorId(int id)
        {
            try
            {
                var gasto = _gastoService.BuscarGastosPorId(id);
                return Ok(gasto);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditarGasto(Gasto gasto)
        {
            try
            {
                var gastoEditado = _gastoService.EditarGasto(gasto);
                return Ok(gastoEditado);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> RemoverGasto(int id)
        {
            try
            {
                _gastoService.RemoverGasto(id);
                return Ok("Gasto excluído");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
