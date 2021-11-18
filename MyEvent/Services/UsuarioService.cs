using MyEvent.Data.Interfaces;
using MyEvent.Models;
using MyEvent.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IBaseService<Usuario> _usuarioBaseService;
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IBaseService<Usuario> usuarioBaseService,
            IUsuarioRepository usuarioRepository)
        {
            _usuarioBaseService = usuarioBaseService;
            _usuarioRepository = usuarioRepository;
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            var existeUsuario = _usuarioRepository.ExisteUsuario(usuario.Login);
            if (!existeUsuario)
                _usuarioBaseService.Add(usuario);
        }

        public bool LoginValido(Usuario usuario)
        {
            return _usuarioRepository.LoginValido(usuario.Login, usuario.Senha);
        }
    }
}
