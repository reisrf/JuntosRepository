using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Services.Implementation;
using Juntos.Domain.Model;
using Juntos.Domain.Services.Interfaces;
using Juntos.Infrastructure.Repository.Interfaces;

namespace Juntos.Domain.Service.Implementation
{
    public abstract class PersonService<TPerson> : BaseService<TPerson>, IPersonService<TPerson>
        where TPerson : Person
    {
         protected PersonService(IBaseRepository<TPerson> repository) : base(repository)
        {
        }

         public List<TPerson> FindByName(string param)
        {
            return this.Repository.FindByExpression(e => e.name.Contains(param));
        }

         public TPerson FindByDocument(string param)
        {
            return this.Repository.FindByExpression(e => e.document.Equals(param)).FirstOrDefault();
        }

        public TPerson FindByLogin(string param)
        {
            return this.Repository.FindByExpression(e => e.login.Id.Equals(param)).FirstOrDefault();
        }

        public bool CheckPassword(long personId, string parameter) 
        {
            bool result = false;

            Person person = this.Repository.FindById(personId);

            if (person != null) 
            {
                if (person.login.password.Equals(parameter)) { result = true; }
            
            }


            return result;
        
        }


    }
}
