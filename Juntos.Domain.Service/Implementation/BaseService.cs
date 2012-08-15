using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.Domain.Services.Interfaces;
using Juntos.Infrastructure.Repository.Interfaces;
using Framework;

namespace Juntos.Domain.Services.Implementation
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity>
        where TEntity : Entity
    {
        private readonly IBaseRepository<TEntity> _repository;

        protected BaseService(IBaseRepository<TEntity> repository)
        {
            this._repository = repository;
        }

        public void Add(TEntity entidade)
        {
            this._repository.Add(entidade);
        }

        public void Update(TEntity entidade)
        {
            var persistido = this.FindById(entidade.Id);
            this._repository.Update(persistido.Hidratar(entidade));
        }

        public void Delete(TEntity entidade)
        {
            this._repository.Delete(entidade);
        }

        public void Save(TEntity entidade)
        {
            if (entidade.Id == 0)
            {
                this.Add(entidade);
            }
            else
            {
                this.Update(entidade);
            }
        }

        public TEntity FindById(long id)
        {
            return this._repository.FindByExpression(c => c.Id.Equals(id)).FirstOrDefault();
        }

        public List<TEntity> FindAll()
        {
            return this._repository.FindAll().ToList();
        }


        protected IBaseRepository<TEntity> Repository { get { return this._repository; } }
    }
}
