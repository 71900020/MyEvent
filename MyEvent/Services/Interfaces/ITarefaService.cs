using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services.Interfaces
{
    public interface ITarefaService
    {
        void CadastrarTarefa(Tarefa tarefa);
        void RemoverTarefa(int idTarefa);
        Tarefa EditarTarefa(Tarefa tarefa);
        IEnumerable<Tarefa> BuscarTarefasPorEvento(int idEvento);
        Tarefa BuscarTarefasPorId(int idTarefa);
        IEnumerable<Tarefa> BuscarTarefasRealizadasPorEvento(int idEvento);
        IEnumerable<Tarefa> BuscarTarefasNaoRealizadasPorEvento(int idEvento);
    }
}
