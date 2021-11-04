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

        public IEnumerable<Evento> BuscarEventosPorUsuario(int idUsuario)
        {
            return _eventoRepository.BuscarEventosPorUsuario(idUsuario);
        }

        public bool CadastrarEvento(Evento evento)
        {
            try
            {
                _eventoBaseService.Add(evento);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Evento EditarEvento(Evento evento)
        {
            try
            {
                return _eventoBaseService.Update(evento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoverEvento(Evento evento)
        {
            try
            {
                _eventoBaseService.Delete(evento.PKEvento);

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
