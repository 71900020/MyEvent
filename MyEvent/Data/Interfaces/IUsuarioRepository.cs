using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Interfaces
{
    public interface IUsuarioRepository
    {
        bool ExisteUsuario(string login);
        bool LoginValido(string login, string senha);
    }
}
