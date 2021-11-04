using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Interfaces
{
    public interface IEventoRepository
    {
        bool ConvidadoTemIdadePermitida(int idEvento, int idadeConvidado);
        IEnumerable<Evento> BuscarEventosPorUsuario(int idUsuario);
    }
}
