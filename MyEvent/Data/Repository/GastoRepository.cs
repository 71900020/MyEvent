using MyEvent.Data.Context;
using MyEvent.Data.Interfaces;
using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Repository
{
    public class GastoRepository : IGastoRepository
    {
        protected readonly SqlContext _sqlContext;
        public GastoRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public IEnumerable<Gasto> BuscarGastosPorEvento(int idEvento)
        {
            return _sqlContext.TBGasto.Where(c => c.FKEvento == idEvento);
        }

        public decimal GastosTotaisPorEvento(int idEvento)
        {
            return _sqlContext.TBGasto.Where(c => c.FKEvento == idEvento).Sum(c => c.Valor);
        }
    }
}
