using MyEvent.Data.Interfaces;
using MyEvent.Models;
using MyEvent.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services
{
    public class ConvidadoService : IConvidadoService
    {
        private readonly IBaseService<Convidado> _convidadoBaseService;
        private readonly IEventoRepository _eventoRepository;
        private readonly ILocalRepository _localRepository;
        private readonly IConvidadoRepository _convidadoRepository;
        public ConvidadoService(IBaseService<Convidado> convidadoBaseService,
            IEventoRepository eventoRepository,
            IConvidadoRepository convidadoRepository,
            ILocalRepository localRepository)
        {
            _convidadoBaseService = convidadoBaseService;
            _eventoRepository = eventoRepository;
            _convidadoRepository = convidadoRepository;
            _localRepository = localRepository;
        }

        public Convidado BuscarConvidadoPeloId(int idConvidado)
        {
            return _convidadoBaseService.GetById(idConvidado);
        }

        public IEnumerable<Convidado> BuscarConvidadosPorEvento(int idEvento)
        {
            return _convidadoRepository.BuscarConvidadosPorEvento(idEvento);
        }

        public void CadastrarConvidado(Convidado convidado)
        {
            var convidadoPodeEntrarNoEvento = ConvidadoPodeEntrarNoEvento(convidado);

            if (convidadoPodeEntrarNoEvento)
                _convidadoBaseService.Add(convidado);

        }

        public Convidado EditarConvidado(Convidado convidado)
        {
            return _convidadoBaseService.Update(convidado);
        }

        public void RemoverConvidado(int idConvidado)
        {
            _convidadoBaseService.Delete(idConvidado);
        }

        private bool ConvidadoPodeEntrarNoEvento(Convidado convidado)
        {
            var idadePermitida = _eventoRepository.ConvidadoTemIdadePermitida(convidado.FKEvento, convidado.Idade);
            var convidadosDoEvento = _convidadoRepository.QtdConvidadosPorEvento(convidado.FKEvento);
            var lotacaoMaxima = (convidadosDoEvento + 1) > _localRepository.BuscarLocalPeloEvento(convidado.FKEvento).Capacidade;

            if (idadePermitida && !lotacaoMaxima)
            {
                return true;
            }
            else if (!idadePermitida)
            {
                throw new Exception("Convidado não tem idade permitida para entrar no evento");
            }
            else
            {
                throw new Exception("Local do evento está com lotação máxima");
            }
        }
    }
}
