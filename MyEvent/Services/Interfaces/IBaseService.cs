using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Services.Interfaces
{
    public interface IBaseService<Entity> where Entity : class
    {
        Entity Add(Entity obj);

        void Delete(int id);

        IList<Entity> Get();

        Entity GetById(int id);

        Entity Update(Entity obj);
    }
}
