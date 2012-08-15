using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Services.Implementation;
using Juntos.Domain.Model;
using Juntos.Infrastructure.Repository.Interfaces;

namespace Juntos.Domain.Service.Implementation
{
    public class CouponService : BaseService<Coupon>
    {

        public CouponService(ICouponRepository repository)
            : base(repository)
        {
        }


        public void MarkAsUsed(long couponId)
        {
            Coupon coupon = this.Repository.FindById(couponId);
            coupon.Use();
            this.Repository.Update(coupon);
        }
        
        List<Coupon> FindByOffer(long offerId)
        {
            return this.Repository.FindByExpression(c => c.offer.Id.Equals(offerId));
        }
    }
}
