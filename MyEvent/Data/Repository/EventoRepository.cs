using MyEvent.Data.Context;
using MyEvent.Data.Interfaces;
using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Repository
{
    public class EventoRepository : IEventoRepository
    {
        protected readonly SqlContext _sqlContext;
        public EventoRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public IEnumerable<Evento> BuscarEventosPorUsuario(int idUsuario)
        {
            return _sqlContext.TBEvento.Where(c => c.FkUsuario == idUsuario);
        }

        public bool ConvidadoTemIdadePermitida(int idEvento, int idadeConvidado)
        {
           return _sqlContext.TBEvento.Where(c => c.PKEvento == idEvento).Select(c => c.IdadeMinima).FirstOrDefault() <= idadeConvidado;
        }
    }
}
