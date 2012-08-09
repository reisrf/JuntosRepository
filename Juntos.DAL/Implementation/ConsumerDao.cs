using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.IDAL;

namespace Juntos.DAL.Implementation
{
    public class ConsumerDao : IBaseDao<Consumer>
    {

        public void Add(Consumer entidade)
        {

            JuntosContext.Instance.consumers.Add(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public void Update(Consumer entidade)
        {
            JuntosContext.Instance.SaveChanges();
        }

        public void Delete(Consumer entidade)
        {
            JuntosContext.Instance.consumers.Remove(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public IEnumerable<Consumer> ListByExpression(Func<Consumer, bool> expressaoDeConsulta)
        {
            return JuntosContext.Instance.consumers.Where(expressaoDeConsulta);
        }

        public List<Consumer> ListAll()
        {

            return JuntosContext.Instance.consumers.ToList();
        }

        public Consumer ListById(long id)
        {

            return JuntosContext.Instance.consumers.Where(a => a.Id == id).FirstOrDefault();

        }
    }
}
