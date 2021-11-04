using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services.Interfaces
{
    public interface ITarefaService
    {
        bool CadastrarTarefa(Tarefa tarefa);
        bool RemoverTarefa(Tarefa tarefa);
        Tarefa EditarTarefa(Tarefa tarefa);
        IEnumerable<Tarefa> BuscarTarefasPorEvento(int idEvento);
        int BuscarTarefasRealizadasPorEvento(int idEvento);
        int BuscarTarefasNaoRealizadasPorEvento(int idEvento);
    }
}
