using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services.Interfaces
{
    public interface IGastoService
    {
        bool CadastrarGasto(Gasto gasto);
        bool RemoverGasto(Gasto gasto);
        Gasto EditarGasto(Gasto gasto);
        IEnumerable<Gasto> BuscarGastosPorEvento(int idEvento);
        decimal GastosTotaisPorEvento(int idEvento);
    }
}
