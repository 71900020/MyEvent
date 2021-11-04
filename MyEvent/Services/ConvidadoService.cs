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

        public IEnumerable<Convidado> BuscarConvidadosPorEvento(int idEvento)
        {
            return _convidadoRepository.BuscarConvidadosPorEvento(idEvento);
        }

        public bool CadastrarConvidado(Convidado convidado)
        {
            try
            {
                var convidadoTemIdadePermitida = ConvidadoPodeEntrarNoEvento(convidado);

                if (convidadoTemIdadePermitida)
                {
                    _convidadoBaseService.Add(convidado);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Convidado EditarConvidado(Convidado convidado)
        {
            try
            {
                return _convidadoBaseService.Update(convidado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int QtdConvidadosPorEvento(int idEvento)
        {
            return _convidadoRepository.QtdConvidadosPorEvento(idEvento);
        }

        public bool RemoverConvidado(Convidado convidado)
        {
            try
            {
                _convidadoBaseService.Delete(convidado.PKConvidado);

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
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

            return false;
        }
    }
}
