using MyEvent.Data.Interfaces;
using MyEvent.Models;
using MyEvent.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly IBaseService<Tarefa> _tarefaBaseService;
        private readonly ITarefaRepository _tarefaRepository;
        public TarefaService(IBaseService<Tarefa> tarefaBaseService,
            ITarefaRepository tarefaRepository)
        {
            _tarefaBaseService = tarefaBaseService;
            _tarefaRepository = tarefaRepository;
        }

        public IEnumerable<Tarefa> BuscarTarefasNaoRealizadasPorEvento(int idEvento)
        {
            return _tarefaRepository.BuscarTarefasNaoRealizadasPorEvento(idEvento);
        }

        public IEnumerable<Tarefa> BuscarTarefasPorEvento(int idEvento)
        {
            return _tarefaRepository.BuscarTarefasPorEvento(idEvento);
        }

        public Tarefa BuscarTarefasPorId(int idTarefa)
        {
            return _tarefaBaseService.GetById(idTarefa);
        }

        public IEnumerable<Tarefa> BuscarTarefasRealizadasPorEvento(int idEvento)
        {
            return _tarefaRepository.BuscarTarefasRealizadasPorEvento(idEvento);
        }

        public void CadastrarTarefa(Tarefa tarefa)
        {
            _tarefaBaseService.Add(tarefa);
        }

        public Tarefa EditarTarefa(Tarefa tarefa)
        {
            return _tarefaBaseService.Update(tarefa);
        }

        public void RemoverTarefa(int idTarefa)
        {
            _tarefaBaseService.Delete(idTarefa);
        }
    }
}
