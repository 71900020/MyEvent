using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Interfaces
{
    public interface ILocalRepository
    {
        Local BuscarLocalPeloEvento(int idEvento);
    }
}
