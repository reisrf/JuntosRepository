using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juntos.Domain.Model
{
    public class Login:Entity
    {
        public string userName { get; set; }
        public string password { get; set; }
        public virtual LoginStatus status { get; set; }

        public void doLogin() 
        {

        
        }

        public void doLogout()
        {


        }
    }
}
