using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services.Interfaces
{
    public interface IConvidadoService
    {
        bool CadastrarConvidado(Convidado convidado);
        bool RemoverConvidado(Convidado convidado);
        Convidado EditarConvidado(Convidado convidado);
        int QtdConvidadosPorEvento(int idEvento);
        IEnumerable<Convidado> BuscarConvidadosPorEvento(int idEvento);
    }
}
