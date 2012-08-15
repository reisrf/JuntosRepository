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
        List<TEntity> FindByExpression(Func<TEntity, bool> expressaoDeConsulta);
        List<TEntity> FindAll();
        TEntity FindById(long id);
    }
}