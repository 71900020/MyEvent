using MyEvent.Data.Context;
using MyEvent.Data.Interfaces;
using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Repository
{
    public class ConvidadoRepository : IConvidadoRepository
    {
        protected readonly SqlContext _sqlContext;
        public ConvidadoRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public IEnumerable<Convidado> BuscarConvidadosPorEvento(int idEvento)
        {
            return _sqlContext.TBConvidado.Where(c => c.FKEvento == idEvento);
        }

        public int QtdConvidadosPorEvento(int idEvento)
        {
            return _sqlContext.TBConvidado.Where(c => c.FKEvento == idEvento).Count();
        }
    }
}
