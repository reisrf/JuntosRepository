using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juntos.Domain.Model
{
    public class Offer:Entity
    {
        public DateTime creationDate { get; private set; }
        public DateTime publishDate { get; private set; }
        public int  periodOfValidityOfOfferInDays { get; set; }
        public int periodOfValidityOfCouponInDays { get; set; }
        public string description { get; private set; }
        public string details { get; private set; }
        public int limitOfCupons { get; private set; }
        public double priceOfCupoun { get; private set; }
        public virtual OfferStatus status { get; private set; }


        public Offer() 
        {
            this.creationDate = DateTime.Now;
            this.publishDate = DateTime.Now;
            this.status = OfferStatus.Created;
                
        }
        
        
        public Coupon CreateCoupon()
        {
           
            Coupon coupon = new Coupon(this);
            
            return coupon;

        }
        public void Publish()
        {
            if (this.status == OfferStatus.Created)
                this.status = OfferStatus.Published;

        }

        public void End()
        {
            this.status = OfferStatus.Ended;

        }


        public DateTime ExpirationValidityOfCupom()
        {
            if (this.status == OfferStatus.Published)
            {
                return this.publishDate.AddDays(this.periodOfValidityOfCouponInDays);
            }
            else
            {
                throw new Exception("The Offer isn´t published yet or already ended");
            }
  
        }


        public DateTime ExpirationValidityOfOffer()
        {
            if (this.status != OfferStatus.Created)
            {
                return this.publishDate.AddDays(this.periodOfValidityOfOfferInDays);
            }
            else
            {
                throw new Exception("The Offer isn´t published yet");
            }

        }
    }
}
