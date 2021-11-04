using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services.Interfaces
{
    public interface ILocalService
    {
        bool CadastrarLocal(Local local);
        bool RemoverLocal(Local local);
        Local EditarLocal(Local local);
        Local BuscarLocalPeloEvento(int idEvento);
    }
}
