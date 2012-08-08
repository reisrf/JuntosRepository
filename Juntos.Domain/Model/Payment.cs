using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juntos.Domain.Model
{
    public class Payment:Entity
    {
        public DateTime paymentDate;
        public double amount;
        public Guid transactionCode;
        public virtual Purchase purchase { get; private set; }
        public virtual PaymentStatus status { get; private set; }
        public virtual PaymentType type { get; private set; }


        public Payment(Purchase parameter, PaymentType type) 
        {

            this.purchase = parameter;
            this.paymentDate = DateTime.Now;
            this.amount = parameter.totalAmount;
            this.status = PaymentStatus.Waiting;
            this.type = type;
        
        
        }
        
        public void ProcessPayment()
        {

            //not implemented yet


        }

    }
}
