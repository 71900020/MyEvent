using MyEvent.Data.Context;
using MyEvent.Data.Interfaces;
using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Repository
{
    public class LocalRepository : ILocalRepository
    {
        protected readonly SqlContext _sqlContext;
        public LocalRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public Local BuscarLocalPeloEvento(int idEvento)
        {
            var idLocal = _sqlContext.TBEvento.Where(c => c.PKEvento == idEvento).Select(c => c.FkLocal).FirstOrDefault();
            return _sqlContext.TBLocal.Where(c => c.PKLocal == idLocal).FirstOrDefault();
        }
    }
}
