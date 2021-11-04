using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services.Interfaces
{
    public interface IEventoService
    {
        bool CadastrarEvento(Evento evento);
        bool RemoverEvento(Evento evento);
        Evento EditarEvento(Evento evento);
        IEnumerable<Evento> BuscarEventosPorUsuario(int idUsuario);
    }
}
