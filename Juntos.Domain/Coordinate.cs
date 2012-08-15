using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juntos.Domain.Model
{
    public class Coordinate:Entity
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}
