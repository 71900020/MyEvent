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
    public class TarefaController : ControllerBase
    {
        private readonly ILogger<TarefaController> _logger;
        private readonly ITarefaService _tarefaService;

        public TarefaController(ILogger<TarefaController> logger,
            ITarefaService tarefaService)
        {
            _logger = logger;
            _tarefaService = tarefaService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarTarefa(Tarefa tarefa)
        {
            try
            {
                _tarefaService.CadastrarTarefa(tarefa);
                return Ok("Tarefa cadastrado");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("evento/{id:int}")]
        public async Task<IActionResult> BuscarTarefasPorEvento(int id)
        {
            try
            {
                var tarefa = _tarefaService.BuscarTarefasPorEvento(id);
                return Ok(tarefa);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("evento/{id:int}/realizadas")]
        public async Task<IActionResult> BuscarTarefasRealizadasPorEvento(int id)
        {
            try
            {
                var tarefa = _tarefaService.BuscarTarefasRealizadasPorEvento(id);
                return Ok(tarefa);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("evento/{id:int}/nao-realizadas")]
        public async Task<IActionResult> BuscarTarefasNaoRealizadasPorEvento(int id)
        {
            try
            {
                var tarefa = _tarefaService.BuscarTarefasNaoRealizadasPorEvento(id);
                return Ok(tarefa);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> BuscarTarefaPorId(int id)
        {
            try
            {
                var tarefa = _tarefaService.BuscarTarefasPorId(id);
                return Ok(tarefa);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditarTarefa(Tarefa tarefa)
        {
            try
            {
                var tarefaEditado = _tarefaService.EditarTarefa(tarefa);
                return Ok(tarefaEditado);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> RemoverTarefa(int id)
        {
            try
            {
                _tarefaService.RemoverTarefa(id);
                return Ok("Tarefa excluído");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
