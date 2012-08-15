using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juntos.Domain.Model
{
    public class Consumer: Person
    {
        private List<Purchase> _purchases = new List<Purchase>();
        public virtual List<Purchase> purchases { get { return this._purchases; } private set { this._purchases = value; } }


        public void AddPurchase(Purchase parameter) {

            
            this.purchases.Add(parameter);
                       
        
        }
    }
}
