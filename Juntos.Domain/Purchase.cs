using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juntos.Domain.Model
{
    public class Purchase:Entity
    {
        public DateTime purchaseDate { get; set; }
        public double totalAmount { get { return this.ComputePurchaseTotalAmount(); } }
        public virtual Consumer consumer { get; private set; }
        public virtual PurchaseStatus status { get; private set; }

        private List<Coupon> _coupons = new List<Coupon>();
        public virtual List<Coupon> coupons { get { return this._coupons; } private set { this._coupons = value; } }

        public virtual Payment payment { get; private set; }

        public Purchase(Consumer consumer)
        {
            this.consumer = consumer;
            this.status = PurchaseStatus.Open;
        }
        
        public double ComputePurchaseTotalAmount()
        {
            double result = 0;

            if (this.coupons.Count >= 0)
                this.coupons.ForEach(c => { result += c.price; });

            return result;

        }

        public void AddCoupon(Coupon parameter)
        {
            this._coupons.Add(parameter);
        }

        public Payment GeneratePayment(PaymentType type) 
        {
            Payment payment = new Payment(this, type);


            return payment;
        
        }

        public void PaymentResult(Payment parameter)
        { 
        
        
        }

        public PaymentStatus GetPaymentStatus()
        {
            //trocar
            return PaymentStatus.Waiting;
            
            
         }

    }
}
