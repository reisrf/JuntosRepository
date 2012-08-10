using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;

namespace Juntos.DAL.Interfaces
{
    public interface IPersonDao<TPerson> : IBaseDao<TPerson>  
        where TPerson : Person
    {

    }
}
