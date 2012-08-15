using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;

namespace Juntos.Domain.Services.Interfaces
{
    public interface IPersonService<TPerson> : IBaseService<TPerson>
       where TPerson : Person
    {
        List<TPerson> FindByName(string parameter);
        TPerson FindByDocument(string parameter);
        bool CheckPassword(long personid, string parameter);
        TPerson FindByLogin(string param);
        
    }
}
