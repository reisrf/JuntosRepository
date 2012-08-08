using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juntos.Domain.Model
{
    public class Advertiser:Person
    {
        private List<Offer> _offers = new List<Offer>();
        public virtual List<Offer> offers { get { return this._offers; } private set { this._offers = value; } }

        public void AddOffer(Offer parameter)
        {


            this._offers.Add(parameter);


        }

    }
}
