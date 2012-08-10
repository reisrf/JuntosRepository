using System;
using System.Collections.Generic;
using Juntos.Domain.Model;


namespace Juntos.Infrastructure.Repository.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity entidade);
        void Update(TEntity entidade);
        void Delete(TEntity entidade);
        List<TEntity> ListByExpression(Func<TEntity, bool> expressaoDeConsulta);
        List<TEntity> ListAll();
        TEntity ListById(long id);
    }
}