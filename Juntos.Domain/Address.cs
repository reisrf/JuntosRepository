using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juntos.Domain.Model
{
    public class Address : Entity
    {

        public string street { get; set; }
        public string number { get; set; }
        public string extension { get; set; }
        public string county { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string country { get; set; }
        public Coordinate coordinate { get; set; }

    }
}
