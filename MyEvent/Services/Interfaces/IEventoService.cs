using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services.Interfaces
{
    public interface IEventoService
    {
        void CadastrarEvento(Evento evento);
        void RemoverEvento(int pkEvento);
        Evento EditarEvento(Evento evento);
        IEnumerable<Evento> BuscarEventosPorUsuario(int idUsuario);
        Evento BuscarEventosPorId(int idEvento);
    }
}
