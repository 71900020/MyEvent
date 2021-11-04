using MyEvent.Data.Context;
using MyEvent.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        protected readonly SqlContext _sqlContext;

        public UsuarioRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }
        public bool ExisteUsuario(string login)
        {
            var usuario = _sqlContext.TBUsuario.Where(c => c.Login == login);
            return usuario.Count() > 0;
        }

        public bool LoginValido(string login, string senha)
        {
            var loginValido = _sqlContext.TBUsuario.Where(c => c.Login == login && c.Senha == senha);
            return loginValido.Count() > 0;
        }
    }
}
