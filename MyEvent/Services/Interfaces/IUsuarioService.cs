using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services.Interfaces
{
    public interface IUsuarioService
    {
        bool CadastrarUsuario(Usuario usuario);
        bool LoginValido(Usuario usuario);
    }
}
