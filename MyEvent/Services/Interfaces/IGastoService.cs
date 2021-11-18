using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services.Interfaces
{
    public interface IGastoService
    {
        void CadastrarGasto(Gasto gasto);
        void RemoverGasto(int id);
        Gasto EditarGasto(Gasto gasto);
        IEnumerable<Gasto> BuscarGastosPorEvento(int idEvento);
        Gasto BuscarGastosPorId(int id);
        decimal GastosTotaisPorEvento(int idEvento);
    }
}
