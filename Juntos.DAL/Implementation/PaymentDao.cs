using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.IDAL;

namespace Juntos.DAL.Implementation
{
    public class PaymentDao : IBaseDao<Payment>
    {

        public void Add(Payment entidade)
        {

            JuntosContext.Instance.payments.Add(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public void Update(Payment entidade)
        {
            JuntosContext.Instance.SaveChanges();
        }

        public void Delete(Payment entidade)
        {
            JuntosContext.Instance.payments.Remove(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public IEnumerable<Payment> ListByExpression(Func<Payment, bool> expressaoDeConsulta)
        {
            return JuntosContext.Instance.payments.Where(expressaoDeConsulta);
        }

        public List<Payment> ListAll()
        {

            return JuntosContext.Instance.payments.ToList();
        }

        public Payment ListById(long id)
        {

            return JuntosContext.Instance.payments.Where(a => a.Id == id).FirstOrDefault();

        }
        
        
    }
}
