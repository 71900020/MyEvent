using MyEvent.Data.Interfaces;
using MyEvent.Models;
using MyEvent.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services
{
    public class LocalService : ILocalService
    {
        private readonly IBaseService<Local> _localBaseService;
        private readonly ILocalRepository _localRepository;
        public LocalService(IBaseService<Local> localBaseService,
            ILocalRepository localRepository)
        {
            _localBaseService = localBaseService;
            _localRepository = localRepository;
        }

        public Local BuscarLocalPeloEvento(int idEvento)
        {
            return _localRepository.BuscarLocalPeloEvento(idEvento);
        }

        public Local BuscarLocalPeloId(int idLocal)
        {
            return _localBaseService.GetById(idLocal);
        }

        public void CadastrarLocal(Local local)
        {
            _localBaseService.Add(local);
        }

        public Local EditarLocal(Local local)
        {
            return _localBaseService.Update(local);
        }

        public void RemoverLocal(int idLocal)
        {
            _localBaseService.Delete(idLocal);
        }
    }
}
