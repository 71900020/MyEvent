using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyEvent.Models;
using MyEvent.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly IUsuarioService _usuarioService;

        public LoginController(ILogger<LoginController> logger,
            IUsuarioService usuarioService)
        {
            _logger = logger;
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, Route("login")]
        public JsonResult FazerLogin(Usuario usuario)
        {
            var loginValido = _usuarioService.LoginValido(usuario);
            if (loginValido)
                return Json(new { success = true , usuario = usuario.Login});

            return Json(new { success = false });
        }

        [HttpPost, Route("cadastrar-usuario")]
        public JsonResult CadastrarUsuario(Usuario usuario)
        {
            try
            {
                _usuarioService.CadastrarUsuario(usuario);
                return Json(new { success = true, responseText = "Usuário cadastrado com sucesso" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message });
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
