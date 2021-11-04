using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Interfaces
{
    public interface IConvidadoRepository
    {
        int QtdConvidadosPorEvento(int idEvento);
        IEnumerable<Convidado> BuscarConvidadosPorEvento(int idEvento);
    }
}
