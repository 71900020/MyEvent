using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services.Interfaces
{
    public interface IConvidadoService
    {
        void CadastrarConvidado(Convidado convidado);
        void RemoverConvidado(int idConvidado);
        Convidado EditarConvidado(Convidado convidado);
        IEnumerable<Convidado> BuscarConvidadosPorEvento(int idEvento);
        Convidado BuscarConvidadoPeloId(int idConvidado);

    }
}
