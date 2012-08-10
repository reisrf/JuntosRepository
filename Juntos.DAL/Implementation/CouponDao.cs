using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.DAL.Interfaces;

namespace Juntos.DAL.Implementation
{
    public class CouponDao : IBaseDao<Coupon>
    {
        public void Add(Coupon entidade)
        {

            JuntosContext.Instance.coupons.Add(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public void Update(Coupon entidade)
        {
            JuntosContext.Instance.SaveChanges();
        }

        public void Delete(Coupon entidade)
        {
            JuntosContext.Instance.coupons.Remove(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public IEnumerable<Coupon> ListByExpression(Func<Coupon, bool> expressaoDeConsulta)
        {
            return JuntosContext.Instance.coupons.Where(expressaoDeConsulta);
        }

        public List<Coupon> ListAll()
        {

            return JuntosContext.Instance.coupons.ToList();
        }

        public Coupon ListById(long id)
        {

            return JuntosContext.Instance.coupons.Where(a => a.Id == id).FirstOrDefault();

        }
        
        
    }
}
