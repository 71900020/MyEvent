using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services.Interfaces
{
    public interface ILocalService
    {
        void CadastrarLocal(Local local);
        void RemoverLocal(int pkLocal);
        Local EditarLocal(Local local);
        Local BuscarLocalPeloEvento(int idEvento);
        Local BuscarLocalPeloId(int idlocal);
    }
}
