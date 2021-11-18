using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Interfaces
{
    public interface ITarefaRepository
    {
        IEnumerable<Tarefa> BuscarTarefasPorEvento(int idEvento);
        IEnumerable<Tarefa> BuscarTarefasRealizadasPorEvento(int idEvento);
        IEnumerable<Tarefa> BuscarTarefasNaoRealizadasPorEvento(int idEvento);
    }
}
