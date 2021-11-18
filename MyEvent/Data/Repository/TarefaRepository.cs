using MyEvent.Data.Context;
using MyEvent.Data.Interfaces;
using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Repository
{
    public class TarefaRepository : ITarefaRepository
    {
        protected readonly SqlContext _sqlContext;
        public TarefaRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public IEnumerable<Tarefa> BuscarTarefasNaoRealizadasPorEvento(int idEvento)
        {
            return _sqlContext.TBTarefa.Where(c => c.FKEvento == idEvento && !c.FoiRealizado);
        }

        public IEnumerable<Tarefa> BuscarTarefasPorEvento(int idEvento)
        {
            return _sqlContext.TBTarefa.Where(c => c.FKEvento == idEvento);
        }

        public IEnumerable<Tarefa> BuscarTarefasRealizadasPorEvento(int idEvento)
        {
            return _sqlContext.TBTarefa.Where(c => c.FKEvento == idEvento && c.FoiRealizado);
        }
    }
}
