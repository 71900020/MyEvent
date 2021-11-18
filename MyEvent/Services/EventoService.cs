using MyEvent.Data.Interfaces;
using MyEvent.Models;
using MyEvent.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services
{
    public class EventoService : IEventoService
    {
        private readonly IBaseService<Evento> _eventoBaseService;
        private readonly IEventoRepository _eventoRepository;
        public EventoService(IBaseService<Evento> eventoBaseService,
            IEventoRepository eventoRepository)
        {
            _eventoBaseService = eventoBaseService;
            _eventoRepository = eventoRepository;
        }

        public Evento BuscarEventosPorId(int idEvento)
        {
            return _eventoBaseService.GetById(idEvento);
        }

        public IEnumerable<Evento> BuscarEventosPorUsuario(int idUsuario)
        {
            return _eventoRepository.BuscarEventosPorUsuario(idUsuario);
        }

        public void CadastrarEvento(Evento evento)
        {
            _eventoBaseService.Add(evento);
        }

        public Evento EditarEvento(Evento evento)
        {
            return _eventoBaseService.Update(evento);
        }

        public void RemoverEvento(int id)
        {
            _eventoBaseService.Delete(id);
        }
    }
}
