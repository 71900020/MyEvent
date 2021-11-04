using MyEvent.Data.Interfaces;
using MyEvent.Models;
using MyEvent.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services
{
    public class GastoService : IGastoService
    {
        private readonly IBaseService<Gasto> _gastoBaseService;
        private readonly IGastoRepository _gastoRepository;
        public GastoService(IBaseService<Gasto> gastoBaseService,
            IGastoRepository gastoRepository)
        {
            _gastoBaseService = gastoBaseService;
            _gastoRepository = gastoRepository;
        }

        public IEnumerable<Gasto> BuscarGastosPorEvento(int idEvento)
        {
            return _gastoRepository.BuscarGastosPorEvento(idEvento);
        }

        public bool CadastrarGasto(Gasto gasto)
        {
            try
            {
                _gastoBaseService.Add(gasto);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Gasto EditarGasto(Gasto gasto)
        {
            try
            {
                return _gastoBaseService.Update(gasto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public decimal GastosTotaisPorEvento(int idEvento)
        {
            return _gastoRepository.GastosTotaisPorEvento(idEvento);
        }

        public bool RemoverGasto(Gasto gasto)
        {
            try
            {
                _gastoBaseService.Delete(gasto.PKGasto);

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
