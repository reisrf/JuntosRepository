using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juntos.Domain.Model
{
    public abstract class Entity
    {
        public long Id { get; set; }

        protected Entity()
        {
            this.Id = 0;
        }

        public bool IsTransient()
        {
            if (this.Id == 0)
                return true;

            return false;
        }
    }
}
