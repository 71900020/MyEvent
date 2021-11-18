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
    public class EventoController : ControllerBase
    {
        private readonly ILogger<EventoController> _logger;
        private readonly IEventoService _eventoService;

        public EventoController(ILogger<EventoController> logger,
            IEventoService eventoService)
        {
            _logger = logger;
            _eventoService = eventoService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarEvento(Evento evento)
        {
            try
            {
                _eventoService.CadastrarEvento(evento);
                return Ok("Evento cadastrado");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("usuario/{id:int}")]
        public async Task<IActionResult> BuscarEventoPorUsuario(int id)
        {
            try
            {
                var evento = _eventoService.BuscarEventosPorUsuario(id);
                return Ok(evento);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> BuscarEventoPorId(int id)
        {
            try
            {
                var evento = _eventoService.BuscarEventosPorId(id);
                return Ok(evento);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditarEvento(Evento evento)
        {
            try
            {
                var eventoEditado = _eventoService.EditarEvento(evento);
                return Ok(eventoEditado);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> RemoverEvento(int id)
        {
            try
            {
                _eventoService.RemoverEvento(id);
                return Ok("Evento excluído");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
