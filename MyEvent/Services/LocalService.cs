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
            try
            {
                return _localRepository.BuscarLocalPeloEvento(idEvento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CadastrarLocal(Local local)
        {
            try
            {
                _localBaseService.Add(local);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Local EditarLocal(Local local)
        {
            try
            {
                return _localBaseService.Update(local);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool RemoverLocal(Local local)
        {
            try
            {
                _localBaseService.Delete(local.PKLocal);

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
