using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.IDAL;

namespace Juntos.DAL.Implementation
{
    public class TelephoneDao : IBaseDao<Telephone>
    {
        public void Add(Telephone entidade)
        {

            JuntosContext.Instance.telephones.Add(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public void Update(Telephone entidade)
        {
            JuntosContext.Instance.SaveChanges();
        }

        public void Delete(Telephone entidade)
        {
            JuntosContext.Instance.telephones.Remove(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public IEnumerable<Telephone> ListByExpression(Func<Telephone, bool> expressaoDeConsulta)
        {
            return JuntosContext.Instance.telephones.Where(expressaoDeConsulta);
        }

        public List<Telephone> ListAll()
        {

            return JuntosContext.Instance.telephones.ToList();
        }

        public Telephone ListById(long id)
        {

            return JuntosContext.Instance.telephones.Where(a => a.Id == id).FirstOrDefault();

        }
        
        

    }
}
