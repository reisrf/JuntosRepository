using System;
using System.Collections.Generic;
using System.Linq;
using Juntos.Domain.Model;
using Juntos.Infrastructure.Repository.Interfaces;
using Juntos.DAL.Interfaces;

namespace Juntos.Infrastructure.Repository.Implementation
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Entity
    {
        private readonly IBaseDao<TEntity> _entidadeDao;

        protected BaseRepository(IBaseDao<TEntity> entidadeDao)
        {
            this._entidadeDao = entidadeDao;
        }

        public void Add(TEntity entidade)
        {
            this._entidadeDao.Add(entidade);
        }

        public void Update(TEntity entidade)
        {
            this._entidadeDao.Update(entidade);
        }

        public void Delete(TEntity entidade)
        {
            this._entidadeDao.Delete(entidade);
        }

        public List<TEntity> FindByExpression(Func<TEntity, bool> expressaoDeConsulta)
        {
            return this._entidadeDao.ListByExpression(expressaoDeConsulta).ToList();
        }

        public List<TEntity> FindAll()
        {
            return this._entidadeDao.ListAll().ToList();
        }

        public TEntity FindById(long id)
        {
            return this._entidadeDao.ListById(id);
        }
    }
}
