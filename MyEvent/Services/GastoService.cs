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

        public Gasto BuscarGastosPorId(int id)
        {
            return _gastoBaseService.GetById(id);
        }

        public void CadastrarGasto(Gasto gasto)
        {
            _gastoBaseService.Add(gasto);
        }

        public Gasto EditarGasto(Gasto gasto)
        {
            return _gastoBaseService.Update(gasto);
        }

        public decimal GastosTotaisPorEvento(int idEvento)
        {
            return _gastoRepository.GastosTotaisPorEvento(idEvento);
        }

        public void RemoverGasto(int id)
        {
            _gastoBaseService.Delete(id);
        }
    }
}
