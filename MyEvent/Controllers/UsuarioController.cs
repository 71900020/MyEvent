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
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(ILogger<UsuarioController> logger,
            IUsuarioService usuarioService)
        {
            _logger = logger;
            _usuarioService = usuarioService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> FazerLogin(Usuario usuario)
        {
            try
            {
                var loginValido = _usuarioService.LoginValido(usuario);
                if (loginValido)
                    return Ok("Login realizado com sucesso");

                return Unauthorized("Usuário/senha inválido(s)");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario(Usuario usuario)
        {
            try
            {
                _usuarioService.CadastrarUsuario(usuario);
                return Ok("Usuário cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
