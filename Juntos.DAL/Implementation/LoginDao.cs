using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.IDAL;

namespace Juntos.DAL.Implementation
{
    public class LoginDao : IBaseDao<Login>
    {

        public void Add(Login entidade)
        {

            JuntosContext.Instance.logins.Add(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public void Update(Login entidade)
        {
            JuntosContext.Instance.SaveChanges();
        }

        public void Delete(Login entidade)
        {
            JuntosContext.Instance.logins.Remove(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public IEnumerable<Login> ListByExpression(Func<Login, bool> expressaoDeConsulta)
        {
            return JuntosContext.Instance.logins.Where(expressaoDeConsulta);
        }

        public List<Login> ListAll()
        {

            return JuntosContext.Instance.logins.ToList();
        }

        public Login ListById(long id)
        {

            return JuntosContext.Instance.logins.Where(a => a.Id == id).FirstOrDefault();

        }
        
        
    }
}
