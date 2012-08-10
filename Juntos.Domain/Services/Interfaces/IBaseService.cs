using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;

namespace Juntos.Domain.Services.Interfaces
{
    public interface IBaseService<TEntity>
       where TEntity : Entity
    {
        void Add(TEntity entidade);
        void Update(TEntity entidade);
        void Delete(TEntity entidade);
        void Save(TEntity entidade);

        TEntity ListById(long id);
        List<TEntity> ListAll();
    }
}
