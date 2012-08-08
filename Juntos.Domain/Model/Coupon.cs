using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juntos.Domain.Model
{
    public class Coupon
    {
        public DateTime notValidAfter { get; private set; }
        public bool used { get; private set; }
        public DateTime useDate { get; private set; }
        public Guid couponCode { get; set; }
        public double price { get; private set; }
        public virtual Offer offer { get; private set; }

        public Coupon(Offer parameter)
        {
            this.notValidAfter = parameter.ExpirationValidityOfCupom();
            this.offer = parameter;
            this.price = parameter.priceOfCupoun;
            this.couponCode = Guid.NewGuid();
            this.used = false;

        }
        
        public void Use()
        {
            this.used = true;
            this.useDate = DateTime.Now;
        }

        

    }
}
