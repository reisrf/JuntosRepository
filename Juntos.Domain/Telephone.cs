using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juntos.Domain.Model
{
    public class Telephone : Entity
    {
        public string internationalCode { get; set; }
        public string localCode { get; set; }
        public string number { get; set; }
    }
}
