using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Interfaces
{
    public interface IGastoRepository
    {
        IEnumerable<Gasto> BuscarGastosPorEvento(int idEvento);
        decimal GastosTotaisPorEvento(int idEvento);
    }
}
