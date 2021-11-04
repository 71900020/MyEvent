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

        public int BuscarTarefasNaoRealizadasPorEvento(int idEvento)
        {
            return _tarefaRepository.BuscarTarefasNaoRealizadasPorEvento(idEvento);
        }

        public IEnumerable<Tarefa> BuscarTarefasPorEvento(int idEvento)
        {
            return _tarefaRepository.BuscarTarefasPorEvento(idEvento);
        }

        public int BuscarTarefasRealizadasPorEvento(int idEvento)
        {
            return _tarefaRepository.BuscarTarefasRealizadasPorEvento(idEvento);
        }

        public bool CadastrarTarefa(Tarefa tarefa)
        {
            try
            {
                _tarefaBaseService.Add(tarefa);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Tarefa EditarTarefa(Tarefa tarefa)
        {
            try
            {
                return _tarefaBaseService.Update(tarefa);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool RemoverTarefa(Tarefa tarefa)
        {
            try
            {
                _tarefaBaseService.Delete(tarefa.PKTarefa);

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
